using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Korisnici> GetKorisnici()
        {
            return db.Korisnici.ToList();
        }

        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);

            var korisniciUloge = db.KorisniciUloge.Where(x => x.KorisnikID == id).Include(x => x.Uloge).ToList();

            korisnici.KorisniciUloge = korisniciUloge;

            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        [Route("api/Korisnici/GetByIme/{ime?}")]
        public List<Korisnici_Result> GetByIme(string ime = "")
        {
            return db.esp_Korisnici_SelectByImePrezime(ime).ToList();
        }

        [Route("api/Korisnici/GetByKorisnickoIme/{korisnickoIme}")]
        public IHttpActionResult GetByKorisnickoIme(string korisnickoIme)
        {
            Korisnici korisnici = db.esp_Korisnici_SelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                korisnici.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(korisnici.Ime, korisnici.Prezime, korisnici.Email, korisnici.Telefon, korisnici.KorisnickoIme, korisnici.LozinkaSalt, korisnici.LozinkaHash, korisnici.Slika, korisnici.SlikaThumb).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Utilities.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            foreach (var item in korisnici.Uloge)
            {
                db.esp_KorisniciUloge_Insert(korisnici.KorisnikID, item.UlogaID);
            }

            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }

        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }
            db.KorisniciUloge.RemoveRange(db.KorisniciUloge.Where(x => x.KorisnikID == korisnici.KorisnikID));
            try
            {
                db.esp_Korisnici_Update(id, korisnici.Ime, korisnici.Prezime, korisnici.Email, korisnici.Telefon, korisnici.KorisnickoIme, korisnici.LozinkaSalt, korisnici.LozinkaHash, korisnici.Status, korisnici.Slika, korisnici.SlikaThumb);
            }
            catch (EntityException ex)
            {

                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Utilities.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }

            foreach (var item in korisnici.Uloge)
            {
                db.esp_KorisniciUloge_Insert(korisnici.KorisnikID, item.UlogaID);
            }
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        private HttpResponseException CreateHttpExceptionMessage(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                ReasonPhrase = reason,
                StatusCode = code,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }

        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);

            if (korisnici == null)
            {
                return NotFound();
            }

            korisnici.Status = false;
            db.SaveChanges();

            return Ok(korisnici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
