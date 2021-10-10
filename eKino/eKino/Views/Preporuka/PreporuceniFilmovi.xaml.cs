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

namespace eKino.Views.Preporuka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreporuceniFilmovi : ContentPage
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.APIAddress, Global.FilmoviRoute);

        public PreporuceniFilmovi()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            if (Global.prijavljeniClan == null)
            {
                HttpResponseMessage response = filmoviService.GetActionResponse("NajboljeOcijenjeni");
                var jsonObject = response.Content.ReadAsStringAsync();
                var filmovi = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);
                filmoviList.ItemsSource = filmovi.ToList();
            }
            else
            {
                HttpResponseMessage response = filmoviService.GetActionResponse("PreporuceniByZanr", Global.prijavljeniClan.ClanID.ToString());
                var jsonObject = response.Content.ReadAsStringAsync();

                filmoviList.ItemsSource = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);
            }
            base.OnAppearing();

        }

        private void filmoviList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new Views.Film.FilmoviDetailsPage((e.Item as Filmovi).FilmID));
            }
        }
    }
}