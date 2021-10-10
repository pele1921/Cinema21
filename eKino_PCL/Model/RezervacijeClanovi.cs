using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class RezervacijeClanovi
    {
        public int RezervacijaID { get; set; }
        public string Naziv { get; set; }
        public short Trajanje { get; set; }
        public System.DateTime VrijemeRezervacije { get; set; }
        public byte[] SlikaThumb { get; set; }
        public Nullable<int> Ulaznica { get; set; }
        public int FilmID { get; set; }
    }
}
