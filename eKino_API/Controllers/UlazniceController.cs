using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class UlazniceController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        [HttpPost]
        public IHttpActionResult PostUlaznice(Ulaznice ulaznica)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.Ulaznice.Add(ulaznica);

            var sjedalo = db.Sjedala.FirstOrDefault(x => x.SjedaloID == ulaznica.SjedaloID);

            if (sjedalo != null)
            {
                sjedalo.isZauzeto = true;
                db.Sjedala.AddOrUpdate(sjedalo);
            }
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = ulaznica.UlaznicaID }, ulaznica);
        }

        [HttpDelete]
        public IHttpActionResult DeleteUlaznice(int id)
        {
            Rezervacije rezervacija = db.Rezervacije.Find(id);
            if (rezervacija == null)
                return NotFound();
            db.Ulaznice.RemoveRange(db.Ulaznice.Where(x => x.RezervacijaID == rezervacija.RezervacijaID));

            var sjedala = db.Sjedala.Include(x=>x.Ulaznice).SelectMany(x => x.Ulaznice)
                .Where(x => x.RezervacijaID == id).Select(x => x.Sjedala);

            foreach (var sjedalo in sjedala)
            {
                sjedalo.isZauzeto = false;
                db.Sjedala.AddOrUpdate(sjedalo);
            }
            db.Rezervacije.Remove(rezervacija);
            db.SaveChanges();
            return Ok();
        }

    }
}
