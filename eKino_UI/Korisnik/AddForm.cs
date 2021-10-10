using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eKino_UI.Utilities;
using System.Configuration;
using eKino_API.Models;
using System.Net.Http;
using System.IO;
using System.Net.Mail;

namespace eKino_UI.Korisnik
{
    public partial class AddForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        private Korisnici korisnik = new Korisnici();

        private void BindUlogeList()
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ulogeList.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ulogeList.DisplayMember = "Naziv";
                ulogeList.ClearSelected();
            }
        }

        public AddForm()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindUlogeList();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (korisnik == null)
                {
                    korisnik = new Korisnici();
                }

                korisnik.Ime = imeInput.Text;
                korisnik.Prezime = prezimeInput.Text;
                korisnik.Email = emailInput.Text;
                korisnik.Telefon = telefonInput.Text;
                korisnik.KorisnickoIme = korisnickoImeInput.Text;
                korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                korisnik.LozinkaHash = UIHelper.GenerateHash(korisnik.LozinkaSalt, lozinkaInput.Text);
                korisnik.Status = true;
                korisnik.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                HttpResponseMessage response = korisniciService.PostResponse(korisnik);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string msg = response.ReasonPhrase;

                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                    {
                        msg = Messages.ResourceManager.GetString(response.ReasonPhrase);
                    }

                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + msg);
                }
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                korisnik.Slika = File.ReadAllBytes(slikaInput.Text);
                Image orgImage = Image.FromFile(slikaInput.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth, resizedImgHeight));

                    if (resizedImg.Width > croppedImgWidth && resizedImg.Height > croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        slikaPictureBox.Image = croppedImg;

                        MemoryStream ms = new MemoryStream();
                        croppedImg.Save(ms, orgImage.RawFormat);

                        korisnik.SlikaThumb = ms.ToArray();
                    }
                    else
                    {
                        MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.msg_war, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        slikaInput.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.msg_war, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    slikaInput.Text = null;
                }
            }
            catch (Exception)
            {
                korisnik.Slika = null;
                korisnik.SlikaThumb = null;
                slikaInput.Text = null;
                slikaPictureBox.Image = null;
            }
        }

        #region Validation
        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(imeInput, null);
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Messages.lname_req);
            }
            else
            {
                errorProvider.SetError(prezimeInput, null);
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Messages.email_req);
            }
            else
            {
                if (String.IsNullOrEmpty(emailInput.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Messages.email_req);
                }
                else
                {
                    try
                    {
                        MailAddress mail = new MailAddress(emailInput.Text);
                        errorProvider.SetError(emailInput, null);

                    }
                    catch (FormatException)
                    {
                        e.Cancel = true;
                        errorProvider.SetError(emailInput, Messages.email_err);
                    }
                }
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, Messages.fname_req);
            }
            else
            {
                errorProvider.SetError(telefonInput, null);
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.username_req);
            }
            else if (korisnickoImeInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Messages.username_err);
            }
            else
                errorProvider.SetError(korisnickoImeInput, null);
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.password_req);
            }
            else if (korisnickoImeInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Messages.password_err);
            }
            else
                errorProvider.SetError(lozinkaInput, null);
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Messages.roles_req);
            }
            else
                errorProvider.SetError(ulogeList, null);
        }
        #endregion
    }
}

