using eKino_PCL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKino
{
    class Global
    {
        public const string APIAddress = "http://localhost:58465/";

        public static Clanovi prijavljeniClan { get; set; }

        #region API Routes
        public const string KorisniciRoute = "api/Korisnici";
        public const string UlogeRoute = "api/Uloge";
        public const string FilmoviRoute = "api/Filmovi";
        public const string ZanroviRoute = "api/Zanrovi";
        public const string ProjekcijeRoute = "api/Projekcije";
        public const string UslugeRoute = "api/Usluge";
        public const string OcjeneRoute = "api/Ocjene";

        public const string DvoraneRoute = "api/Dvorane";
        public const string RezervacijeRoute = "api/Rezervacije";
        public const string ClanoviRoute = "api/Clanovi";
        public const string SjedalaRoute = "api/Sjedala";
        public static string UlazniceRoute = "api/Ulaznice";
        #endregion
    }
}
