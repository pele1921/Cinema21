using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class RecommendedFilmovi
    {
        public int FilmID { get; set; }
        public string Naziv { get; set; }
        public string IzvorniNaziv { get; set; }
        public short GodinaIzdavanja { get; set; }
        public short Trajanje { get; set; }
        public byte[] SlikaThumb { get; set; }

    }
}
