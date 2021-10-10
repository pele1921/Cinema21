using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eKino_API.Models
{
    public partial class Filmovi
    {
        public List<Zanrovi> Zanrovi { get; set; }
    }
}