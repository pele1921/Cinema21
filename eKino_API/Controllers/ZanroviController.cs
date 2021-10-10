using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Description;

namespace eKino_API.Controllers
{
    public class ZanroviController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Zanrovi> GetZanrovi()
        {
            return db.Zanrovi.OrderBy(x => x.Naziv).ToList();
        }

        public IHttpActionResult GetZanrovi(int id)
        {
            Zanrovi zanrovi = db.Zanrovi.Find(id);

            if (zanrovi == null)
            {
                return NotFound();
            }

            return Ok(zanrovi);
        }

        public IHttpActionResult PostZanrovi(Zanrovi zanrovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            db.Zanrovi.Add(zanrovi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zanrovi.ZanrID }, zanrovi);
        }

        public IHttpActionResult PutZanrovi(int id, Zanrovi zanrovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (id != zanrovi.ZanrID)
            {
                return BadRequest();
            }

            db.esp_Zanrovi_Update(id, zanrovi.Naziv);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteZanrovi(int id)
        {
            Zanrovi zanrovi = db.Zanrovi.Find(id);

            if (zanrovi == null)
            {
                return NotFound();
            }

            List<FilmoviZanrovi> filmoviZanrovi = db.FilmoviZanrovi.Where(x => x.ZanrID == zanrovi.ZanrID).ToList();

            foreach (var i in filmoviZanrovi)
            {
                db.FilmoviZanrovi.Remove(i);
            }

            db.Zanrovi.Remove(zanrovi);
            db.SaveChanges();

            return Ok(zanrovi);
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
