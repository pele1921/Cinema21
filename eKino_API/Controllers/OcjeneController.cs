using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class OcjeneController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        [HttpPost]
        public IHttpActionResult PostOcjene(Ocjene ocjene)
        {
            db.esp_Ocjene_Insert(ocjene.FilmID, ocjene.ClanID, ocjene.Ocjena);

            return CreatedAtRoute("DefaultApi", new { id = ocjene.OcjenaID }, ocjene);
        }

       
    }
}
