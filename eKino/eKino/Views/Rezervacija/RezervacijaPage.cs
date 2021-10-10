using eKino_PCL;
using eKino_PCL.Model;
using eKino_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace eKino.Views.Rezervacija
{
    public class RezervacijaDetailsPage : ContentPage
    {

        private WebAPIHelper dvoraneService = new WebAPIHelper(Global.APIAddress, Global.DvoraneRoute);
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.APIAddress, Global.ProjekcijeRoute);
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.APIAddress, Global.RezervacijeRoute);
        private WebAPIHelper ulazniceService = new WebAPIHelper(Global.APIAddress, Global.UlazniceRoute);
        private WebAPIHelper sjedalaService = new WebAPIHelper(Global.APIAddress, Global.SjedalaRoute);


        Entry VrijemeText = new Entry() { IsEnabled = false };
        Entry CijenaText = new Entry() { IsEnabled = false };
        public RezervacijaDetailsPage(int projekcijaID)
        {
            //ScrollView scrollView = new ScrollView();
            StackLayout stek = new StackLayout();
            var grid = new Grid() { Padding = 7, HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand };
            #region grid

            HttpResponseMessage responseSjedala = sjedalaService.GetActionResponse("projekcija", projekcijaID.ToString());

            var sjedalaJsonObject = responseSjedala.Content.ReadAsStringAsync().Result;

            var sjedalaList = JsonConvert.DeserializeObject<List<Sjedala>>(sjedalaJsonObject);

            var xMax = sjedalaList.Max(x => x.PozicijaX);
            var yMax = sjedalaList.Max(x => x.PozicijaY);

            for (int i = 0; i < xMax + 1; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(8, GridUnitType.Auto) });
            }

            for (int i = 0; i < yMax + 1; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(120) });
            }

            #endregion

            Label sjedalo = new Label() { Text = "Sjedalo : " };
            Label VrijemePrikazivanja = new Label() { Text = "Vrijeme prikazivanja : " };
            Label Cijena = new Label() { Text = "Cijena : " };
            Entry sjedaloText = new Entry() { IsEnabled = false };
            Button potvrda = new Button() { Text = "Potvrdi" };
            Label brojUlaznicaLabel = new Label() { Text = "Broj ulaznica:" };
            Entry brojUlaznica = new Entry() { IsEnabled = false };
            #region sjedala

            HttpResponseMessage responseCijena = projekcijeService.GetActionResponse("GetCijena", projekcijaID.ToString());
            var jsonCijena = responseCijena.Content.ReadAsStringAsync();
            int cijena = JsonConvert.DeserializeObject<int>(jsonCijena.Result);


            List<Button> sjedalas = new List<Button>();
            foreach (var item in sjedalaList)
            {
                sjedalas.Add(new Button()
                {
                    IsEnabled = !item.isZauzeto,
                    BackgroundColor = item.isZauzeto ? Color.IndianRed : Color.LightGray,
                    Text = $"{Convert.ToChar(65 + Convert.ToInt32(item.PozicijaX))}{item.PozicijaY}",
                    WidthRequest = 30,
                    HeightRequest = 30
                });

            }

            List<string> imenaSjedala = new List<string>();
            foreach (var button in sjedalas)
            {
                button.Clicked += delegate
                {
                    if (imenaSjedala.Contains(button.Text))
                    {
                        imenaSjedala.Remove(button.Text);
                        CijenaText.Text = (imenaSjedala.Count * cijena).ToString();
                        brojUlaznica.Text = imenaSjedala.Count().ToString();
                        button.BackgroundColor = button.BackgroundColor == Color.IndianRed ? Color.LightGray : Color.IndianRed;
                        sjedaloText.Text = string.Join<string>(" & ", imenaSjedala);

                    }
                    else if (imenaSjedala.Count() < 3)
                    {
                        imenaSjedala.Add(button.Text);
                        CijenaText.Text = (imenaSjedala.Count * cijena).ToString();
                        button.BackgroundColor = button.BackgroundColor == Color.IndianRed ? Color.LightGray : Color.IndianRed;
                        sjedaloText.Text = string.Join<string>(" & ", imenaSjedala);
                        brojUlaznica.Text = imenaSjedala.Count().ToString();
                    }
                };
                var x = Convert.ToInt32(button.Text.ElementAt(0)) - 65;
                var y = (button.Text.ElementAt(1));

                grid.Children.Add(button, int.Parse(y.ToString()), x);
            }


            #endregion

            HttpResponseMessage responseProjekcija = projekcijeService.GetActionResponse("GetProjekcija", projekcijaID.ToString());
            if (responseProjekcija.IsSuccessStatusCode)
            {
                var jsonObject = responseProjekcija.Content.ReadAsStringAsync();
                Projekcije projekcija = JsonConvert.DeserializeObject<Projekcije>(jsonObject.Result);
                VrijemeText.Text = projekcija.DatumProjekcije.ToString();
            }

            Rezervacije rezervacija = new Rezervacije();
            rezervacija.Status = false;
            rezervacija.VrijemeRezervacije = DateTime.Now;
            rezervacija.ClanID = Global.prijavljeniClan.ClanID;

            potvrda.Clicked += delegate
            {
                if (CijenaText.Text == null)
                    DisplayAlert("Greška", Messages.rezervacija_err, "OK");
                else
                {
                    var sjedalaZaUlaznice = new List<int>();
                    foreach (var item in imenaSjedala)
                    {
                        var x = item.ElementAt(0) - 65;
                        var y = int.Parse(item.ElementAt(1).ToString());

                        var getSjedalo = projekcijeService.RawActionResponse($"{projekcijaID}/sjedaloid/{x}/{y}");
                        sjedalaZaUlaznice.Add(JsonConvert.DeserializeObject<int>(getSjedalo.Content.ReadAsStringAsync().Result));
                    }

                    HttpResponseMessage responseRezervacija = rezervacijeService.PostResponse(rezervacija);
                    var jsonResult = responseRezervacija.Content.ReadAsStringAsync();
                    Rezervacije rez = JsonConvert.DeserializeObject<Rezervacije>(jsonResult.Result);
                    if (responseProjekcija.IsSuccessStatusCode)
                    {

                        foreach (var item in sjedalaZaUlaznice)
                        {
                            var insertUlaznica = new Ulaznice()
                            {
                                SjedaloID = item,
                                ProjekcijaID = projekcijaID,
                                RezervacijaID = rez.RezervacijaID,
                            };
                            HttpResponseMessage createUlaznicaResponse = ulazniceService.PostResponse(insertUlaznica);
                        }
                        DisplayAlert("Uspjeh", Messages.rezervacija_succ, "OK");
                        this.Navigation.PushAsync(new Rezervacija.RezervacijaMainPage());
                    }
                }
            };



            stek.Children.Add(grid);
            Grid podaci = new Grid();
            podaci.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Auto) });
            podaci.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Auto) });
            podaci.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Auto) });
            podaci.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Auto) });

            podaci.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
            podaci.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
            podaci.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });





            podaci.Children.Add(sjedalo, 0, 0);
            podaci.Children.Add(VrijemePrikazivanja, 0, 1);
            podaci.Children.Add(Cijena, 0, 2);
            podaci.Children.Add(sjedaloText, 1, 0);
            podaci.Children.Add(VrijemeText, 1, 1);
            podaci.Children.Add(CijenaText, 1, 2);
            podaci.Children.Add(brojUlaznicaLabel, 0, 3);
            podaci.Children.Add(brojUlaznica, 1, 3);

            podaci.Children.Add(potvrda, 2, 3);
            stek.Children.Add(podaci);
            stek.Children.Add(potvrda);
            Content = new ScrollView { Content = stek };
        }
    }
}