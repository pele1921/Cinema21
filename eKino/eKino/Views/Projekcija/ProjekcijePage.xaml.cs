using eKino_PCL;
using eKino_PCL.Model;
using eKino_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Views.Projekcija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjekcijePage : ContentPage
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.APIAddress, Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.APIAddress, Global.FilmoviRoute);

   
        public ProjekcijePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            HttpResponseMessage response = projekcijeService.GetActionResponse("GetByNazivFilma");
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                var projekcije = JsonConvert.DeserializeObject<List<Projekcije>>(jsonObject.Result);
                projekcijeList.ItemsSource = projekcije.ToList();
            }
            base.OnAppearing();
        }

        private void BindList()
        {
            try
            {
                HttpResponseMessage response = projekcijeService.GetActionResponse("GetByNazivFilma");

                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    var projekcije = JsonConvert.DeserializeObject<List<Projekcije>>(jsonObject.Result);
                    projekcijeList.ItemsSource = projekcije.Where(x=>x.DatumProjekcije.Day==datePicker.Date.Day && x.DatumProjekcije.Month == datePicker.Date.Month && x.DatumProjekcije.Year == datePicker.Date.Year).ToList();
                }
            }
            catch (Exception ex)
            {

                DisplayAlert(Messages.error, ex.Message, "OK");
            }
        }

        async public void projekcijeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                if (Global.prijavljeniClan == null)
                {
                    HttpResponseMessage response = filmoviService.GetActionResponse("GetByNaziv", (e.Item as Projekcije).Film);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonObject = response.Content.ReadAsStringAsync();
                        List<Filmovi> filmovi = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);
                        await Navigation.PushAsync(new Views.Film.FilmoviDetailsPage(filmovi[0].FilmID));
                    }
                }
                else
                {
                    var odgovor = await DisplayAlert("Izbor", "Odaberite", "Detalji filma", "Kreiranje rezervacije");
                    if (odgovor)
                    {
                        HttpResponseMessage response = filmoviService.GetActionResponse("GetByNaziv", (e.Item as Projekcije).Film);
                        if (response.IsSuccessStatusCode)
                        {
                            var jsonObject = response.Content.ReadAsStringAsync();
                            List<Filmovi> filmovi = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);
                            await Navigation.PushAsync(new Views.Film.FilmoviDetailsPage(filmovi[0].FilmID));
                        }
                    }
                    else
                    {
                        await this.Navigation.PushAsync(new Rezervacija.RezervacijaDetailsPage((e.Item as Projekcije).ProjekcijaID));
                    }
                }
            }
        }
        void datePicker_DateSelected(object sender, DateChangedEventArgs args)
        {
            BindList();
        }

    }
}