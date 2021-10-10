using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class RezervacijeDetails
    {
        public byte[] SlikaThumb { get; set; }
        public string Naziv { get; set; }
        public System.DateTime DatumProjekcije { get; set; }
        public string Dvorana { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public Nullable<int> Broj_Ulaznica { get; set; }
        public short Red { get; set; }
        public short Mjesto { get; set; }
    }
}
