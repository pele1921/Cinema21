using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eKino_UI
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }

        #region API Routes
        public const string KorisniciRoute = "api/Korisnici";
        public const string UlogeRoute = "api/Uloge";
        public const string FilmoviRoute = "api/Filmovi";
        public const string ZanroviRoute = "api/Zanrovi";
        public const string ProjekcijeRoute = "api/Projekcije";
        public const string UslugeRoute = "api/Usluge";
        public const string VrsteRoute = "api/Vrste";

        public const string DvoraneRoute = "api/Dvorane";
        public const string RezervacijeRoute = "api/Rezervacije";
        public const string ClanoviRoute = "api/Clanovi";

        #endregion
    }
}
