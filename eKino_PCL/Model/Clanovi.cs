using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Clanovi
    {
        public int ClanID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public System.DateTime DatumRegistracije { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int ZanrID { get; set; }
    }
}
