using eKino_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MoreLinq;

namespace eKino_API.Utilities
{
    public class Recommender
    {
        eKinoEntities db = new eKinoEntities();
        Dictionary<int, List<Ocjene>> filmovi = new Dictionary<int, List<Ocjene>>();

        public List<Filmovi> getSlicneFilmove(int filmID, int clanId)
        {
            var clan = db.Clanovi.Find(clanId);

            UcitajFilmove(filmID);


            List<Ocjene> ocjenePosmatranogFilma = db.Ocjene.Where(x => x.FilmID == filmID).OrderBy(x => x.ClanID).ToList();
            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<Filmovi> preporuceniFilmovi = new List<Filmovi>();


            var pogledaniFilmovi = db.Ulaznice
                .Include(x => x.Rezervacije)
                .Include(x => x.Projekcije)
                .Include(x => x.Projekcije.Filmovi)
                .Where(x => x.Rezervacije.ClanID == clanId)
                .Select(x => x.Projekcije.Filmovi).AsEnumerable()
                .DistinctBy(x => x.FilmID)
                .ToList();

            IEnumerable<Filmovi> filtriranifilmovi = db.Filmovi.Include(x => x.Ocjene).ToList();

            filtriranifilmovi = filtriranifilmovi.Except(pogledaniFilmovi).Except(filtriranifilmovi.Where(x => x.FilmID == filmID));


            foreach (var film in filtriranifilmovi)
            {
                foreach (Ocjene ocjene in ocjenePosmatranogFilma)
                {
                    if (film.Ocjene.Any(x => x.ClanID == ocjene.ClanID))
                    {
                        zajednickeOcjene1.Add(ocjene);
                        zajednickeOcjene2.Add(film.Ocjene.First(x => x.ClanID == ocjene.ClanID));
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.3)
                    preporuceniFilmovi.Add(filtriranifilmovi.FirstOrDefault(x => x.FilmID == film.FilmID));
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            if (preporuceniFilmovi.Count < 3)
                preporuceniFilmovi.AddRange(filtriranifilmovi.Except(preporuceniFilmovi).Take(3 > filtriranifilmovi.Count() ? filtriranifilmovi.Count() : 3 - preporuceniFilmovi.Count));

            return preporuceniFilmovi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;

        }

        private void UcitajFilmove(int filmID)
        {
            List<Filmovi> aktivniFilmovi = db.Filmovi.Where(x => x.FilmID != filmID && x.Aktivan).ToList();
            List<Ocjene> ocjene = new List<Ocjene>();

            foreach (Filmovi film in aktivniFilmovi)
            {
                ocjene = db.Ocjene.Where(x => x.FilmID == film.FilmID).OrderBy(x => x.ClanID).ToList();
                if (ocjene.Count > 0)
                    filmovi.Add(film.FilmID, ocjene);
            }
        }

        public List<Filmovi> PreporuceniByZanr(Clanovi clan)
        {

            var filmoviByZanr = db.Filmovi
                .Include(x => x.FilmoviZanrovi)
                .Include(x => x.Ocjene)
                .Where(x => x.FilmoviZanrovi.Count(y => y.ZanrID == clan.ZanrID) > 0).ToList();

            var odgledaniFilmovi = db.Ulaznice.Include(x => x.Rezervacije)
                .Include(x => x.Projekcije)
                .Where(x => x.Rezervacije.ClanID == clan.ClanID)
                .Select(x => x.Projekcije.Filmovi)
                .Include(x => x.Ocjene)
                .ToList();

            var nePogledaniFilmovi = filmoviByZanr
                .Except(odgledaniFilmovi)
                .OrderByDescending(x => x.Ocjene.Any() ? x.Ocjene.Average(y => y.Ocjena) : 0.0)
                .Take(2)
                .ToList();

            if (nePogledaniFilmovi.Count() < 5)
            {

                var sviFilmovi = db.Filmovi.Include(x => x.Ocjene).OrderByDescending(x => x.Ocjene.Average(y => y.Ocjena)).ToList();

                sviFilmovi = sviFilmovi
                    .Except(odgledaniFilmovi)
                    .Except(nePogledaniFilmovi)
                    .OrderByDescending(x => x.Ocjene.Any() ? x.Ocjene.Average(y => y.Ocjena) : 0.0)
                    .ToList();


                nePogledaniFilmovi.AddRange(sviFilmovi);
            }

            return nePogledaniFilmovi.OrderByDescending(x => x.Ocjene.Any() ? x.Ocjene.Average(y => y.Ocjena) : 0.0).Take(5).ToList();

        }
    }
}