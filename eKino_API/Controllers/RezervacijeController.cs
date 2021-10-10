using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using System.Data.Entity.Migrations;

namespace eKino_API.Controllers
{
    public class RezervacijeController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        [Route("api/Rezervacije/GetByClanovi/{naziv?}")]
        public List<esp_Rezervacije_GetByClanovi_Result> GetByClanovi(string naziv = "")
        {
            return db.esp_Rezervacije_GetByClanovi(naziv).ToList();
        }

        [Route("api/Rezervacije/GetKarte/{naziv?}")]
        public List<esp_Rezervacije_GetKarte_Result> GetKarte(string naziv = "")
        {
            return db.esp_Rezervacije_GetKarte(naziv).ToList();

        }

        [Route("api/Rezervacije/GetKarteByUlaznica/{ulaznicaID}")]
        public List<esp_Rezervacije_GetKarte_Result> GetKarteByUlaznica(int ulaznicaID)
        {
            return db.esp_Rezervacije_GetKartuByUlaznica(ulaznicaID).ToList();
        }

        [Route("api/Rezervacije/GetByFilmovi/{naziv?}")]
        public List<esp_Rezervacije_GetByKorisnickoIme_Result> GetByFilmovi(string naziv = "")
        {
            return db.esp_Rezervacije_GetByFilmovi(naziv).ToList();
        }

        [Route("api/Rezervacije/GetByKorisnickoIme/{naziv?}")]
        public List<esp_Rezervacije_GetByKorisnickoIme_Result> GetByKorisnickoIme(string naziv = "")
        {
            return db.esp_Rezervacije_GetByKorisnickoIme(naziv).ToList();
        }

        [Route("api/Rezervacije/GetDetails/{rezervacijaID?}")]
        public esp_Rezervacije_GetDetails_Result GetByFilmovi(int rezervacijaID)
        {
            return db.esp_Rezervacije_GetDetails(rezervacijaID).FirstOrDefault();
        }

        [Route("api/Rezervacije/GetByZanr/{naziv?}")]
        public List<esp_Rezervacije_GetByKorisnickoIme_Result> GetByZanr(string naziv = "")
        {
            return db.esp_Rezervacije_GetByZanrovi(naziv).ToList();
        }

        [Route("api/Rezervacije/GetByClanID/{id}")]
        public List<esp_Rezervacije_GetByClanID_Result> GetByClanID(int id)
        {
            return db.esp_Rezervacije_GetByClanID(id).ToList();
        }

        [Route("api/Rezervacije/GetAktivneByClanID/{id}")]
        public List<esp_Rezervacije_GetAktivneByClanID_Result> GetAktivneByClanID(int id)
        {
            return db.esp_Rezervacije_GetAktivneByClanID(id).ToList();
        }

        [Route("api/Rezervacije/GetProcesiraneByClanID/{id}")]
        public List<esp_Rezervacije_GetProcesiraneByClanID_Result> GetProcesiraneByClanID(int id)
        {
            return db.esp_Rezervacije_GetProcesiraneByClanID(id).ToList();
        }
        [Route("api/Rezervacije/GetProcesirane/{naziv?}")]
        public List<esp_Rezervacije_GetProcesirane_Result> GetProcesirane(string naziv = "")
        {
            return db.esp_Rezervacije_GetProcesirane(naziv).ToList();
        }
        public Rezervacije PostRezervacije(Rezervacije rezervacija)
        {
            rezervacija.Status = true;
            db.Rezervacije.Add(rezervacija);
            db.SaveChanges();
            return rezervacija;
        }

        [Route("api/Rezervacije/GetZarada")]
        public IEnumerable<esp_Rezervacije_GetUkupnoByYear_Result> GetZarada()
        {
            return db.esp_Rezervacije_GetUkupnoByYear();
        }

        public IHttpActionResult DeleteRezervacije(int id)
        {
            var ulaznice = db.Ulaznice.Include(x => x.Sjedala).Include(x => x.Rezervacije).Where(x => x.Rezervacije.ClanID == id).ToList();

            var sjedala = ulaznice.Select(x => x.Sjedala);

            foreach (var sjedalo in sjedala)
            {
                sjedalo.isZauzeto = false;
                db.Sjedala.AddOrUpdate(sjedalo);
            }

            db.esp_Rezervacije_UpdateStatus(id);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("api/rezervacije/deleteulaznica/{id}")]
        public IHttpActionResult DeleteUlaznica(int id)
        {

            var ulaznica = db.Ulaznice.Include(x => x.Sjedala).FirstOrDefault(x => x.UlaznicaID == id);

            if (ulaznica == null)
                return NotFound();

         //   ulaznica.Sjedala.isZauzeto = false;
            ulaznica.Procesirano = true;

            db.Ulaznice.AddOrUpdate(ulaznica);

            var rezervacija = db.Rezervacije.Include(x => x.Ulaznice)
                .FirstOrDefault(x => x.RezervacijaID == ulaznica.RezervacijaID);

            if (!rezervacija.Ulaznice.Any(x => !x.Procesirano))
            {
                rezervacija.Status = false;
                db.Rezervacije.AddOrUpdate(rezervacija);
            }
            db.SaveChanges();

            return Ok(ulaznica);
        }
    }
}
