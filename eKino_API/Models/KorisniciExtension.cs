using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eKino_API.Models
{
    public partial class Korisnici
    {
        public List<Uloge> Uloge { get; set; }
    }
}