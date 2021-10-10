using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class DvoraneController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Dvorane> GetDvorane()
        {
            return db.Dvorane.OrderBy(x => x.Naziv).ToList();
        }

        [HttpPost]
        [Route("api/dvorane/{id}/addsjedala/{brojsjedala}")]
        public IHttpActionResult AddSjedala(int id, int brojsjedala)
        {
            var sjedala = new List<Sjedala>();
            var redovi = brojsjedala / 10+2;
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sjedala.Add(new Sjedala()
                    {
                        DvoranaID = id,
                        isZauzeto = false,
                        PozicijaX = Convert.ToInt16(i),
                        PozicijaY = Convert.ToInt16(j),
                    });
                }
            }

            db.Sjedala.AddRange(sjedala);
            db.SaveChanges();

            return Ok(sjedala);
        }

        [Route("api/Dvorane/GetByNaziv/{naziv?}")]
        public List<Dvorane> GetByNaziv(string naziv="") {
            return db.esp_Dvorane_SelectByNaziv(naziv).ToList();
        }

        [Route("api/Dvorane/GetDvoranaByNaziv/{naziv?}")]
        public Dvorane GetDvoranaByNaziv(string naziv)
        {
            return db.esp_Dvorane_GetDvoranaByNaziv(naziv).FirstOrDefault();
        }

        public IHttpActionResult GetDvorane(int id)
        {
            Dvorane dvorana = db.Dvorane.Find(id);
            if (dvorana == null)
                return NotFound();
            return Ok(dvorana);
        }

        //POST
        public IHttpActionResult PostDvorane(Dvorane dvorana)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.Dvorane.Add(dvorana);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = dvorana.DvoranaID }, dvorana);
        }

        //PUT
        public IHttpActionResult PutDvorane(int id, Dvorane dvorana)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            if (id != dvorana.DvoranaID)
                return BadRequest();
            db.esp_Dvorane_Update(id, dvorana.Naziv, dvorana.Kapacitet);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteDvorane(int id)
        {
            Dvorane dvorana = db.Dvorane.Find(id);
            if (dvorana == null)
                return NotFound();
            db.Dvorane.Remove(dvorana);
            db.SaveChanges();
            return Ok(dvorana);
        }
    }
}
