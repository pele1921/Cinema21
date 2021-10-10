using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Filmovi
    {
        public int FilmID { get; set; }
        public string Naziv { get; set; }
        public string IzvorniNaziv { get; set; }
        public short GodinaIzdavanja { get; set; }
        public short Trajanje { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Trailer { get; set; }
        public string Zanr { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }
        public bool Aktivan { get; set; }
    }
}
