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

namespace eKino.Views.Film
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmoviPage : ContentPage
	{
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.APIAddress, Global.ZanroviRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.APIAddress, Global.FilmoviRoute);

        public FilmoviPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = zanroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Zanrovi> zanrovi = JsonConvert.DeserializeObject<List<Zanrovi>>(jsonObject.Result);

                zanroviPicker.ItemsSource = zanrovi;
                zanroviPicker.ItemDisplayBinding = new Binding("Naziv");
            }

            base.OnAppearing();
        }

        private void zanroviPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zanroviPicker.SelectedItem != null)
            {
                int zanrId = (zanroviPicker.SelectedItem as Zanrovi).ZanrID;

                HttpResponseMessage response = filmoviService.GetActionResponse("GetByZanr", zanrId.ToString());

                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    var filmovi = JsonConvert.DeserializeObject<List<Filmovi>>(jsonObject.Result);

                    filmoviList.ItemsSource = filmovi.Where(x => x.Aktivan == true).ToList();
                }
            }

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