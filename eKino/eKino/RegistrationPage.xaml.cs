using eKino_PCL.Model;
using eKino_PCL.Util;
using eKino_PCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Mail;
using Newtonsoft.Json;

namespace eKino
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        private WebAPIHelper clanoviService = new WebAPIHelper(Global.APIAddress, Global.ClanoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.APIAddress, Global.ZanroviRoute);

        public RegistrationPage()
        {
            InitializeComponent();
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

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (!Valid())
                return;

            Clanovi clan = new Clanovi();
            clan.Ime = ImeInput.Text;
            clan.Prezime = PrezimeInput.Text;
            clan.Email = EmailInput.Text;
            clan.KorisnickoIme = KorisnickoImeInput.Text;
            clan.LozinkaSalt = UIHelper.GenerateSalt();
            clan.LozinkaHash = UIHelper.GenerateHash(clan.LozinkaSalt, LozinkaInput.Text);
            clan.Slika = null;
            clan.SlikaThumb = null;
            clan.Status = true;
            clan.DatumRegistracije = DateTime.Now;
            clan.ZanrID = zanroviPicker.SelectedIndex+1;

            HttpResponseMessage response = clanoviService.PostResponse(clan);

            if (response.IsSuccessStatusCode)
            {
                DisplayAlert(Messages.success, Messages.registration_succ, "OK");
                this.Navigation.PopAsync();
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
                    return false;
                }
            }


            if (zanroviPicker.SelectedIndex == -1)
            {
                DisplayAlert(Messages.error, Messages.zanr_req, "OK");
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
            

            if (string.IsNullOrEmpty(LozinkaInput.Text))
            {
                DisplayAlert(Messages.error, Messages.password_req, "OK");
                return false;
            }
            else if (LozinkaInput.Text.Length < 3)
            {
                DisplayAlert(Messages.success, Messages.password_len, "OK");
                return false;
            }


            return true;
        }
    }
}
