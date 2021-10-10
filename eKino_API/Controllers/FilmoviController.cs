using eKino_API.Models;
using eKino_API.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Http.Description;

namespace eKino_API.Controllers
{
    public class FilmoviController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Filmovi> GetFilmovi()
        {
            return db.Filmovi.ToList();
        }

        public IHttpActionResult GetFilmovi(int id)
        {
            Filmovi filmovi = db.Filmovi.Find(id);

            var filmoviZanrovi = db.FilmoviZanrovi.Where(x => x.FilmID == id).Include(x => x.Zanrovi).ToList();

            filmovi.FilmoviZanrovi = filmoviZanrovi;

            if (filmovi == null)
            {
                return NotFound();
            }

            return Ok(filmovi);
        }

        [Route("api/Filmovi/GetNajbolji")]
        public List<Filmovi> GetNajbolji()
        {
            List<Filmovi> filmovi = (from f in db.Filmovi join o in db.Ocjene on f.FilmID equals o.FilmID select f).ToList();

            List<Filmovi> najbolji = filmovi.OrderByDescending(x => x.Ocjene.Average(y => y.Ocjena)).ToList();
            return najbolji;
        }

        [Route("api/Filmovi/GetByNaziv/{naziv?}")]
        public List<Filmovi_Result> GetByNaziv(string naziv = "")
        {
            return db.esp_Filmovi_SelectByNaziv(naziv).ToList();
        }

        [Route("api/Filmovi/GetByClan/{clanID}")]
        public IHttpActionResult GetByNaziv(int clanID)
        {
            var filmovi = db.Ulaznice
                .Include(x => x.Rezervacije)
                .Include(x => x.Projekcije.Filmovi.Ocjene)
                .Where(x => x.Rezervacije.ClanID == clanID && !x.Projekcije.Filmovi.Ocjene.Any(y => y.ClanID == clanID))
                .Select(x => x.Projekcije.Filmovi)
                .ToList();

            return Ok(filmovi); //filmove koje je clan pogledao
        }

        [Route("api/Filmovi/GetByZarada/{godina?}")]
        public List<Filmovi_Zarada_Result> GetByZarada(int godina = 0)
        {
            return db.esp_Filmovi_SelectByZarada(godina).ToList();
        }

        [Route("api/Filmovi/RecommendFilm/{id}/{clanid}")]
        public List<Filmovi> GetRecommendFilm(int id, int clanid)
        {
            Recommender r = new Recommender();
            return r.getSlicneFilmove(id, clanid).Take(3).ToList();
        }

        [Route("api/Filmovi/PreporuceniByZanr/{clanID}")]
        public List<Filmovi> GetPreporuceniByZanr(int clanID)
        {
            Clanovi clan = db.Clanovi.Find(clanID);
            if (clan == null)
                return null;
            Recommender r = new Recommender();
            return r.PreporuceniByZanr(clan);
        }

        [Route("api/Filmovi/GetById/{id?}")]
        public List<Filmovi_GetByID_Result> GetByID(int id)
        {
            return db.esp_Filmovi_GetByID(id).ToList();
        }

        [HttpGet]
        [Route("api/Filmovi/SearchFilm/{zanrID}/{naziv?}")]
        public List<esp_Filmovi_Search_Result> SearchFilm(int zanrID, string naziv = "")
        {
            return db.esp_Filmovi_Search(naziv, zanrID).ToList();

        }

        [Route("api/Filmovi/GetByZanr/{id?}")]
        public List<Filmovi_Zanr_Result> GetByZanr(int id = 0)
        {
            return db.esp_Filmovi_SelectByZanr(id).ToList();
        }

        public IHttpActionResult PostFilmovi(Filmovi filmovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            filmovi.FilmID = Convert.ToInt32(db.esp_Filmovi_Insert(filmovi.Naziv, filmovi.IzvorniNaziv, filmovi.GodinaIzdavanja, filmovi.Trajanje, filmovi.Opis, filmovi.Slika, filmovi.SlikaThumb, filmovi.Trailer).FirstOrDefault());

            foreach (var item in filmovi.Zanrovi)
            {
                db.esp_FilmoviZanrovi_Insert(filmovi.FilmID, item.ZanrID);
            }

            return CreatedAtRoute("DefaultApi", new { id = filmovi.FilmID }, filmovi);
        }

        public IHttpActionResult PutFilmovi(int id, Filmovi filmovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != filmovi.FilmID)
            {
                return BadRequest();
            }

            //db.esp_Filmovi_Update(filmovi.FilmID, filmovi.Naziv, filmovi.IzvorniNaziv, filmovi.GodinaIzdavanja, filmovi.Trajanje, filmovi.Opis, filmovi.Slika, filmovi.SlikaThumb, filmovi.Trailer);

            var film = db.Filmovi.FirstOrDefault(x => x.FilmID == id);


            db.FilmoviZanrovi.RemoveRange(db.FilmoviZanrovi.Where(x => x.FilmID == id));

            db.Filmovi.AddOrUpdate(filmovi);

            db.FilmoviZanrovi.AddRange(filmovi.Zanrovi.Select(x => new FilmoviZanrovi() { FilmID = id, ZanrID = x.ZanrID }));




            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteFilmovi(int id)
        {
            Filmovi filmovi = db.Filmovi.Find(id);
            if (filmovi == null)
            {
                return NotFound();
            }
            filmovi.Aktivan = false;
            db.Filmovi.AddOrUpdate(filmovi);
            List<Projekcije> projekcije = db.Projekcije.Where(x => x.FilmID == id).ToList();
            if (projekcije != null)
            {
                foreach (var projekcija in projekcije)
                {
                    projekcija.Aktivna = false;
                    db.Projekcije.AddOrUpdate(projekcija);
                }
            }
            db.SaveChanges();

            return Ok(filmovi);
        }

        [Route("api/Filmovi/GetProsjek/{filmID?}")]
        public int GetProsjek(int filmID)
        {
            return Convert.ToInt32(db.esp_Filmovi_GetProsjek(filmID).FirstOrDefault());
        }
        [HttpGet]
        [Route("api/Filmovi/NajboljeOcijenjeni")]
        public List<Filmovi> NajboljeOcijenjeni()
        {
            return db.Filmovi
                .Include(x => x.Ocjene)
                .OrderByDescending(x => x.Ocjene
                    .Average(y => y.Ocjena))
                .Take(5 > db.Filmovi.Count() ? db.Filmovi.Count() : 5)
                .ToList();
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
