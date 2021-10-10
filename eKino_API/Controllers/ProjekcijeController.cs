using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKino_API.Models;

namespace eKino_API.Controllers
{
    public class ProjekcijeController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Projekcije_All_Result> GetProjekcije()
        {
            return db.esp_Projekcije_SelectAll().ToList();
        }

        [Route("api/Projekcije/GetAll")]

        public List<Projekcije> GetAll() {
            return db.Projekcije.ToList();
        }
        public IHttpActionResult GetProjekcije(int id)
        {
            Projekcije projekcija = db.Projekcije.Find(id);

            if (projekcija == null)
            {
                return NotFound();
            }

            return Ok(projekcija);
        }

        [Route("api/Projekcije/GetProjekcija/{id?}")]

        public Projekcije GetProjekcija(int id)
        {
            Projekcije projekcija = db.Projekcije.Find(id);
            return projekcija;
        }

        [Route("api/Projekcije/GetCijena/{id?}")]

        public int GetCijena(int id)
        {
            return Convert.ToInt32(db.esp_Projekcije_GetCijena(id).FirstOrDefault());
        }

        [Route("api/Projekcije/GetByNazivFilma/{naziv?}")]
        public List<Projekcije_Result> GetByNazivFilma(string naziv = "")
        {
            return db.esp_Projekcije_SelectByNazivFilma(naziv).ToList();
        }

        [Route("api/Projekcije/GetByDvorana/{id?}")]
        public List<Projekcije_Dvorana_Result> GetByDvorana(int id = 0)
        {
            return db.esp_Projekcije_SelectByDvorana(id).ToList();
        }

        [Route("api/Projekcije/GetByUsluga/{id?}")]
        public List<Projekcije_Usluga_Result> GetByUsluga(int id = 0)
        {
            return db.esp_Projekcije_SelectByUsluga(id).ToList();
        }

        public IHttpActionResult PostProjekcije(Projekcije projekcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.esp_Projekcije_Insert(projekcija.FilmID, projekcija.DvoranaID, projekcija.UslugaID, projekcija.DatumProjekcije);

            return CreatedAtRoute("DefaultApi", new { id = projekcija.ProjekcijaID }, projekcija);
        }

        public IHttpActionResult PutProjekcije(int id, Projekcije projekcija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projekcija.ProjekcijaID)
            {
                return BadRequest();
            }

            db.esp_Projekcije_Update(id, projekcija.FilmID, projekcija.DvoranaID, projekcija.UslugaID, projekcija.DatumProjekcije);

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteProjekcije(int id)
        {
            Projekcije projekcije = db.Projekcije.Find(id);

            if (projekcije == null)
            {
                return NotFound();
            }
            projekcije.Aktivna = false;
            db.Projekcije.AddOrUpdate(projekcije);
            db.SaveChanges();

            return Ok(projekcije);
        }

        [Route("api/projekcije/{id}/sjedaloid/{coorX}/{coorY}")]
        public IHttpActionResult GetSjedaloID(int id, int coorX, int coorY)
        {

            var projekcija = db.Projekcije
                .Include(x => x.Dvorane)
                .Include(x => x.Dvorane.Projekcije)
                .Include(x => x.Dvorane.Sjedala)
                .FirstOrDefault(x => x.ProjekcijaID == id);

            if (projekcija == null)
                return NotFound();

            if (projekcija.Dvorane == null)
                return NotFound();

            var sjedalo = projekcija.Dvorane
                .Sjedala
                .FirstOrDefault(x => x.PozicijaX == coorX && x.PozicijaY == coorY);

            if (sjedalo == null)
                return NotFound();

            return Ok(sjedalo.SjedaloID);
        }

        [Route("api/Projekcije/GetGodine")]
        public List<int?> GetGodine()
        {
            return db.esp_Projekcije_SelectByGodina().ToList();
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