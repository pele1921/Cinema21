using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Rezervacije
    {
        public int RezervacijaID { get; set; }
        public System.DateTime VrijemeRezervacije { get; set; }
        public string Napomena { get; set; }
        public int ClanID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
