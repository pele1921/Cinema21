using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class ClanoviController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        [Route("api/Clanovi/GetById/{id}")]
        public Clanovi GetById(int id)
        {
            Clanovi clan = db.Clanovi.Find(id);
            return clan;
        }

        [Route("api/Clanovi/GetClan/{ime}")]
        public IHttpActionResult GetClan(string ime)
        {
            Clanovi c = db.Clanovi.Where(x => x.KorisnickoIme == ime).FirstOrDefault();

            if (c == null)
            {
                return NotFound();
            }

            return Ok(c);
        }

        [Route("api/Clanovi/GetByName/{naziv?}")]
        public List<Clanovi> GetByName(string naziv = "")
        {
            return db.esp_Clanovi_SelectByNaziv(naziv).ToList();
        }

        [HttpPost]
        public IHttpActionResult PostClanovi(Clanovi clan)
        {
            //db.esp_Clanovi_Insert(clan.Ime, clan.Prezime, clan.Email, DateTime.Now, clan.KorisnickoIme, clan.LozinkaHash, clan.LozinkaSalt, clan.Slika, clan.SlikaThumb);
            db.Clanovi.Add(clan);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult PutClanovi(int id, Clanovi clan)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (id != clan.ClanID)
                return BadRequest();


            db.Clanovi.AddOrUpdate(clan);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteClanovi(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.esp_Clanovi_StatusFalse(id);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
