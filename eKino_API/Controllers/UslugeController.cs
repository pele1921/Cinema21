using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class UslugeController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Usluge> GetUsluge()
        {
            return db.Usluge.OrderBy(x => x.Naziv).ToList();
        }

        [Route("api/usluge/GetUslugeByIme/{naziv?}")]
        public List<Usluge> GetUslugeByIme(string naziv="")
        {
            return db.esp_Usluge_GetByName(naziv).ToList();
           

        }

        public IHttpActionResult PostUsluge(Usluge usluga)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.Usluge.Add(usluga);
            db.SaveChanges();
            return Ok(usluga);
        }

        public IHttpActionResult DeleteUsluge(int id) {
            Usluge usluga = db.Usluge.Find(id);
            if (usluga == null)
                return NotFound();
            db.Usluge.Remove(usluga);
            db.SaveChanges();
            return Ok(usluga);
        }
    }
}
