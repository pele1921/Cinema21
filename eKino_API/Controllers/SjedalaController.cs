using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace eKino_API.Controllers
{
    public class SjedalaController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public IEnumerable<Sjedala> GetSjedalaByDvorana(int id)
        {
            return db.Sjedala.Where(x => x.DvoranaID == id);
        }
        [Route("api/sjedala/GetByRezervacija/{rezervacijaID}")]
        public List<Sjedala> GetSjedalaByRezervacija(int rezervacijaID) {
            return db.esp_Sjedala_GetByRezervacija(rezervacijaID).ToList();
        }

        [Route("api/sjedala/projekcija/{id}")]
        public IHttpActionResult GetSjedalaByProjekcija(int id)
        {
            var sjedala = db.Projekcije
                .Include(x => x.Dvorane)
                .Include(x => x.Dvorane.Sjedala)
                .FirstOrDefault(x => x.ProjekcijaID == id)
                ?.Dvorane
                ?.Sjedala.ToList();

            if (sjedala == null)
                return NotFound();

            return Ok(sjedala);
        }
        // 


    }
}
