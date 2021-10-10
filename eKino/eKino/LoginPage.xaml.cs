using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKino_PCL;
using eKino_PCL.Util;
using eKino_PCL.Model;
using Newtonsoft.Json;

namespace eKino
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private WebAPIHelper clanoviService = new WebAPIHelper(Global.APIAddress, Global.ClanoviRoute);

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KorisnickoImeInput.Text) || string.IsNullOrEmpty(LozinkaInput.Text))
            {
                DisplayAlert(Messages.error, Messages.login_req, "OK");
                return;
            }

            HttpResponseMessage response = clanoviService.GetActionResponse("GetClan", KorisnickoImeInput.Text);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                DisplayAlert(Messages.error, Messages.login_user_err, "OK");
            }
            else if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                Clanovi clan = JsonConvert.DeserializeObject<Clanovi>(jsonObject.Result);

                if (clan.LozinkaHash == UIHelper.GenerateHash(clan.LozinkaSalt, LozinkaInput.Text) && clan != null)
                {
                    Global.prijavljeniClan = clan;
                    this.Navigation.PushAsync(new Views.Projekcija.ProjekcijePage());
                }
                else
                {
                    DisplayAlert(Messages.error, Messages.login_pass_err, "OK");
                    LozinkaInput.Text = String.Empty;
                }
            }
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RegistrationPage());
        }
    }
}
