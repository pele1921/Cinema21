using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Ocjene
    {
        public int OcjenaID { get; set; }
        public int FilmID { get; set; }
        public int ClanID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Ocjena { get; set; }
    }
}
