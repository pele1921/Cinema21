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

namespace eKino.Views.Rezervacija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaViewPage : ContentPage
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.APIAddress, Global.RezervacijeRoute);
        private WebAPIHelper ulazniceService = new WebAPIHelper(Global.APIAddress, Global.UlazniceRoute);
        private WebAPIHelper sjedalaService = new WebAPIHelper(Global.APIAddress, Global.SjedalaRoute);

        public int rezervacijaID;
        public RezervacijaViewPage(int id)
        {
            InitializeComponent();
            rezervacijaID = id;
        }
        protected override void OnAppearing()
        {
            if (Global.prijavljeniClan == null)
            {
                DisplayAlert("Greška", "Molimo prijavite se za nastavak", "OK");
                this.Navigation.PushAsync(new NavigationPage(new LoginPage()));
            }
            else
            {
                HttpResponseMessage response = rezervacijeService.GetActionResponse("GetDetails", rezervacijaID.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    RezervacijeDetails rezervacije = JsonConvert.DeserializeObject<RezervacijeDetails>(jsonObject.Result);
                    dvoranaLabel.Text = rezervacije.Dvorana;
                    filmLabel.Text = rezervacije.Naziv;
                    datumLabel.Text = rezervacije.DatumProjekcije.ToString();
                    FilmImage.Source = ImageSource.FromStream(() => new MemoryStream(rezervacije.SlikaThumb));
                    cijenaLabel.Text = rezervacije.Cijena.ToString() + "  BAM";

                    HttpResponseMessage sjedalaResponse = sjedalaService.GetActionResponse("GetByRezervacija", rezervacijaID.ToString());
                    if (sjedalaResponse.IsSuccessStatusCode)
                    {
                        jsonObject = sjedalaResponse.Content.ReadAsStringAsync();
                        List<Sjedala> sjedala = JsonConvert.DeserializeObject<List<Sjedala>>(jsonObject.Result);
                        foreach (Sjedala sjedalo in sjedala)
                        {
                            mjestoLabel.Text += (Convert.ToChar(65 + sjedalo.PozicijaX)).ToString() + sjedalo.PozicijaY.ToString() + " && ";
                        }
                        mjestoLabel.Text = mjestoLabel.Text.Remove(mjestoLabel.Text.Length - 3);
                    }
                }
                base.OnAppearing();
            }
        }

        async protected void otkaziButton_Clicked(object sender, EventArgs e)
        {

            var odgovor = await DisplayAlert("Upozorenje", "Želite li poništiti rezervaciju", "Da", "Ne");
            if (odgovor)
            {
                HttpResponseMessage response = ulazniceService.DeleteResponse(rezervacijaID);
                if (response.IsSuccessStatusCode)
                {
                    var vUpdatedPage = new RezervacijaMainPage(); Navigation.InsertPageBefore(vUpdatedPage, this);
                    await DisplayAlert("Uspjeh", "Uspješno ste poništili rezervaciju", "OK");
                    await Navigation.PopAsync();
                }
            }
        }
    }
}