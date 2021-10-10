using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eKino_API.Controllers
{
    public class UlogeController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        public List<Uloge> GetUloge()
        {
            return db.Uloge.ToList();
        }

        public IHttpActionResult DeleteResponse(int id)
        {
            Uloge uloga = db.Uloge.Find(id);
            if (uloga == null)
                return NotFound();
            db.Uloge.Remove(uloga);
            db.SaveChanges();
            return Ok();

        }

        public IHttpActionResult PostResponse(Uloge uloga)
        {
            db.Uloge.Add(uloga);
            db.SaveChanges();
            return Ok();
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
