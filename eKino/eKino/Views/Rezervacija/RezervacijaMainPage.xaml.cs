using eKino_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eKino_PCL.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Views.Rezervacija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaMainPage : ContentPage
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.APIAddress, Global.RezervacijeRoute);
        private WebAPIHelper ulazniceService = new WebAPIHelper(Global.APIAddress, Global.UlazniceRoute);
        public RezervacijaMainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            if (Global.prijavljeniClan == null)
            {
                DisplayAlert("Greška", "Molimo prijavite se za nastavak.", "OK");

                this.Navigation.PushAsync(new LoginPage());
            }
            else
            {
                if (statusPicker.Items.Count() == 0)
                {
                    statusPicker.Items.Add("Aktivne rezervacije");
                    statusPicker.Items.Add("Procesirane rezervacije");
                    HttpResponseMessage response = rezervacijeService.GetActionResponse("GetAktivneByClanID", Global.prijavljeniClan.ClanID.ToString());
                    var jsonObject = response.Content.ReadAsStringAsync();
                    
                    List<RezervacijeClanovi> rezervacijeClanovi = JsonConvert.DeserializeObject<List<RezervacijeClanovi>>(jsonObject.Result);
                    rezervacijeList.ItemsSource = rezervacijeClanovi;
                    base.OnAppearing(); 
                }
            }
        }
        private void statusPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            if (statusPicker.SelectedItem != null)
            {
                if (statusPicker.SelectedIndex == 0)
                {
                    HttpResponseMessage response = rezervacijeService.GetActionResponse("GetAktivneByClanID", Global.prijavljeniClan.ClanID.ToString());
                    var jsonObject = response.Content.ReadAsStringAsync();

                    List<RezervacijeClanovi> rezervacijeClanovi = JsonConvert.DeserializeObject<List<RezervacijeClanovi>>(jsonObject.Result);
                    rezervacijeList.ItemsSource = rezervacijeClanovi;
                }
                if (statusPicker.SelectedIndex == 1)
                {
                    HttpResponseMessage response = rezervacijeService.GetActionResponse("GetProcesiraneByClanID", Global.prijavljeniClan.ClanID.ToString());
                    var jsonObject = response.Content.ReadAsStringAsync();

                    List<RezervacijeClanovi> rezervacijeClanovi = JsonConvert.DeserializeObject<List<RezervacijeClanovi>>(jsonObject.Result);
                    rezervacijeList.ItemsSource = rezervacijeClanovi;
                }
            }
        }

        async private void rezervacijaList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (statusPicker.SelectedIndex == 1)
            {
                if (e.Item != null)
                {
                    await this.Navigation.PushAsync(new Views.Film.FilmoviDetailsPage((e.Item as RezervacijeClanovi).FilmID));
                }
            }
            else
            {
                await this.Navigation.PushAsync(new Rezervacija.RezervacijaViewPage((e.Item as RezervacijeClanovi).RezervacijaID));

            }
        }
    }
}
