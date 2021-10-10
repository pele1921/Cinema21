using eKino_PCL;
using eKino_PCL.Model;
using eKino_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Views.Film
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmoviDetailsPage : ContentPage
    {
        private WebAPIHelper ocjeneService = new WebAPIHelper(Global.APIAddress, Global.OcjeneRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.APIAddress, Global.FilmoviRoute);
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.APIAddress, Global.ProjekcijeRoute);

        private string trailerUrl;
        private Filmovi film;

        public FilmoviDetailsPage()
        {
            InitializeComponent();
        }

        public FilmoviDetailsPage(int filmId)
        {
            InitializeComponent();
            LoadPageData(filmId);
            if (Global.prijavljeniClan != null)
                GetRecommended(filmId);
            GetTrailerUrl(filmId);
        }

        private void GetRecommended(int filmId)
        {
            HttpResponseMessage recommendResponse = filmoviService.GetActionResponse($"RecommendFilm/{filmId.ToString()}", Global.prijavljeniClan.ClanID.ToString());
            if (recommendResponse.IsSuccessStatusCode)
            {
                var jsonFilmovi = recommendResponse.Content.ReadAsStringAsync();
                List<RecommendedFilmovi> recommendedFilmovi = JsonConvert.DeserializeObject<List<RecommendedFilmovi>>(jsonFilmovi.Result);
                filmoviList.ItemsSource = recommendedFilmovi;
            }
        }

        protected override void OnAppearing()
        {
            FilmRatings.ItemsSource = new List<string> { "Ne sviđa mi se", "Nije loše", "U redu je", "Odlična je", "Preporučujem" };
            if (Global.prijavljeniClan == null)
            {
                preporukaLabel.IsVisible = false;
            }
            base.OnAppearing();
        }

        private void LoadPageData(int filmId)
        {
            HttpResponseMessage response = filmoviService.GetResponse(filmId.ToString());
            HttpResponseMessage responseCijena = filmoviService.GetActionResponse("GetProsjek", filmId.ToString());
            var jsonCijena = responseCijena.Content.ReadAsStringAsync();
            int cijena = JsonConvert.DeserializeObject<int>(jsonCijena.Result);

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                film = JsonConvert.DeserializeObject<Filmovi>(jsonObject.Result);

                NazivLabel.Text = "Naziv: " + film.Naziv;
                IzvorniNazivLabel.Text = "Izvorni naziv: " + film.IzvorniNaziv;
                GodinaIzdavanjaLabel.Text = "Godina izdavanja: " + film.GodinaIzdavanja.ToString() + " god.";
                TrajanjeLabel.Text = "Trajane: " + film.Trajanje.ToString() + " min.";
                ProsjecnaOcjenaLabel.Text = "Prosječna ocjena: " + cijena.ToString();
                OpisLabel.Text = "Opis: " + film.Opis;
                FilmImage.Source = ImageSource.FromStream(() => new MemoryStream(film.SlikaThumb));
            }

            if (Global.prijavljeniClan == null)
            {
                FilmRatings.IsVisible = false;
                FilmRate.IsVisible = false;
            }
         

            HttpResponseMessage responseProjekcije = projekcijeService.GetActionResponse("GetByNazivFilma", film.Naziv.Substring(0,3));
            if (responseProjekcije.IsSuccessStatusCode)
            {
                
                var jsonObject = responseProjekcije.Content.ReadAsStringAsync();
                List<Projekcije> projekcije = JsonConvert.DeserializeObject<List<Projekcije>>(jsonObject.Result);
                projekcijeList.ItemsSource = projekcije;
                if (projekcije.Count == 0)
                    soon.IsVisible = true;
                else
                    soon.IsVisible = false;

            }

            if (Global.prijavljeniClan != null)
            {
                HttpResponseMessage responseFilmovi = filmoviService.GetActionResponse("GetByClan", Global.prijavljeniClan.ClanID.ToString());
                if (responseFilmovi.IsSuccessStatusCode)
                {
                    var jsonObject = responseFilmovi.Content.ReadAsStringAsync();
                    List<Filmovi> pogledaniFilmovi = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);

                    if (pogledaniFilmovi.Any(x => x.FilmID == film.FilmID))
                        rating.IsVisible = true;
                }
            }
        }

        private void GetTrailerUrl(int filmId)
        {
            HttpResponseMessage response = filmoviService.GetResponse(filmId.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                Filmovi filmovi = JsonConvert.DeserializeObject<Filmovi>(jsonObject.Result);

                trailerUrl = filmovi.Trailer;
            }
        }

        private void TrailerShow_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Views.Film.TrailerPage(trailerUrl));
        }

        private void FilmRate_Clicked(object sender, EventArgs e)
        {
            if (FilmRatings.SelectedIndex == -1)
            {
                return;
            }

            Ocjene ocjena = new Ocjene();
            ocjena.FilmID = film.FilmID;
            ocjena.ClanID = Global.prijavljeniClan.ClanID;
            ocjena.Ocjena = FilmRatings.SelectedIndex + 1;

            HttpResponseMessage response = ocjeneService.PostResponse(ocjena);

            if (response.IsSuccessStatusCode)
            {
                DisplayAlert(Messages.success, Messages.rating_succ, "OK");
            }
        }

        private void projekcijeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (Global.prijavljeniClan == null)
            {
                DisplayAlert("Greška", "Molimo prijavite se za nastavak.", "OK");

                this.Navigation.PushAsync(new LoginPage());
            }
            else if (e.Item != null)
            {
                this.Navigation.PushAsync(new Views.Rezervacija.RezervacijaDetailsPage((e.Item as Projekcije).ProjekcijaID));
            }
        }

        private void filmoviList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {

                this.Navigation.PushAsync(new Views.Film.FilmoviDetailsPage((e.Item as RecommendedFilmovi).FilmID));
            }
        }

    }
}