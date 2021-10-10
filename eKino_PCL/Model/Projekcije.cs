using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Projekcije
    {
        public int ProjekcijaID { get; set; }
        public string Film { get; set; }
        public string Dvorana { get; set; }
        public string Usluga { get; set; }
        public DateTime DatumProjekcije { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Aktivna { get; set; }
    }
}
