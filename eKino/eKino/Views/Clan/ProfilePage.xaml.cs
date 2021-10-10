using eKino_PCL;
using eKino_PCL.Model;
using eKino_PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Views.Clan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private WebAPIHelper clanoviService = new WebAPIHelper(Global.APIAddress, Global.ClanoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.APIAddress, Global.ZanroviRoute);

        private Clanovi clan = Global.prijavljeniClan;

        public ProfilePage()
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
                LoadPageData();
            }

            base.OnAppearing();
        }
        private void LoadPageData()
        {
            HttpResponseMessage response = clanoviService.GetActionResponse("GetById", Global.prijavljeniClan.ClanID.ToString());

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                Clanovi clan = JsonConvert.DeserializeObject<Clanovi>(jsonObject.Result);

                ImeInput.Text = clan.Ime;
                PrezimeInput.Text = clan.Prezime;
                EmailInput.Text = clan.Email;
                KorisnickoImeInput.Text = clan.KorisnickoIme;
                StaraLozinkaInput.Text = "";
                NovaLozinkaInput.Text = "";
            }
            response = zanroviService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Zanrovi> zanrovi = JsonConvert.DeserializeObject<List<Zanrovi>>(jsonObject.Result);

                zanroviPicker.ItemsSource = zanrovi;
                zanroviPicker.ItemDisplayBinding = new Binding("Naziv");
                zanroviPicker.SelectedIndex = clan.ZanrID - 1;
            }


        }

        private bool Valid()
        {
            if (string.IsNullOrEmpty(ImeInput.Text))
            {
                DisplayAlert(Messages.error, Messages.fname_req, "OK");
                return false;
            }

            if (string.IsNullOrEmpty(PrezimeInput.Text))
            {
                DisplayAlert(Messages.error, Messages.lname_req, "OK");
                return false;
            }

            if (string.IsNullOrEmpty(KorisnickoImeInput.Text))
            {
                DisplayAlert(Messages.error, Messages.username_req, "OK");
                return false;
            }
            else if (KorisnickoImeInput.Text.Length < 3)
            {
                DisplayAlert(Messages.error, Messages.username_err, "OK");
                return false;
            }

            if (string.IsNullOrEmpty(EmailInput.Text))
            {
                DisplayAlert(Messages.error, Messages.email_req, "OK");
                return false;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(EmailInput.Text);
                }
                catch (FormatException)
                {
                    DisplayAlert(Messages.error, Messages.email_err, "OK");
                    return false; ;
                }
            }

            if (!string.IsNullOrEmpty(StaraLozinkaInput.Text) && !string.IsNullOrEmpty(NovaLozinkaInput.Text))
            {
                if (UIHelper.GenerateHash(clan.LozinkaSalt, StaraLozinkaInput.Text) != clan.LozinkaHash)
                {
                    DisplayAlert(Messages.success, Messages.password_err, "OK");
                    return false;
                }
                else if (NovaLozinkaInput.Text.Length < 3)
                {
                    DisplayAlert(Messages.success, Messages.password_len, "OK");
                    return false;
                }
            }

            return true;
        }

        private void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            if (!Valid())
                return;

            clan.Ime = ImeInput.Text;
            clan.Prezime = PrezimeInput.Text;
            clan.Email = EmailInput.Text;
            clan.KorisnickoIme = KorisnickoImeInput.Text;
            clan.ZanrID = zanroviPicker.SelectedIndex + 1;
            if (!String.IsNullOrEmpty(NovaLozinkaInput.Text))
            {
                clan.LozinkaSalt = UIHelper.GenerateSalt();
                clan.LozinkaHash = UIHelper.GenerateHash(clan.LozinkaSalt, NovaLozinkaInput.Text);
            }

            HttpResponseMessage response = clanoviService.PutResponse(clan.ClanID, clan);

            if (response.IsSuccessStatusCode)
            {
                DisplayAlert(Messages.success, Messages.user_update_succ, "OK");
                LoadPageData();
            }
            else
            {
                DisplayAlert(Messages.error, Messages.user_update_err, "OK");
            }
        }
    }
}
