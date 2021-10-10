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
	public partial class RecommenderPage : ContentPage
	{
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.APIAddress, Global.FilmoviRoute);

        public int filmID;
		public RecommenderPage (int id)
		{
			InitializeComponent ();
            filmID = id;

            HttpResponseMessage recommendResponse = filmoviService.GetActionResponse("RecommendFilm", filmID.ToString());
            if (recommendResponse.IsSuccessStatusCode)
            {
                var jsonFilmovi = recommendResponse.Content.ReadAsStringAsync();
                List<RecommendedFilmovi> recommendedFilmovi = JsonConvert.DeserializeObject<List<RecommendedFilmovi>>(jsonFilmovi.Result);
                filmoviList.ItemsSource = recommendedFilmovi;
            }
        }
    }
}