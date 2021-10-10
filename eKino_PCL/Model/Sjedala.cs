using System;
using System.Collections.Generic;
using System.Text;

namespace eKino_PCL.Model
{
    public class Sjedala
    {
        public int SjedaloID { get; set; }
        public int DvoranaID { get; set; }
        public short PozicijaX { get; set; }
        public short PozicijaY { get; set; }
        public bool isZauzeto { get; set; }
    }
}
