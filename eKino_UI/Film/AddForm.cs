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
using System.Collections;

namespace eKino_UI.Film
{
    public partial class AddForm : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);
        private Filmovi film = new Filmovi();

        public AddForm()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindZanroviCombo();
        }

        private void BindZanroviCombo()
        {
            HttpResponseMessage response = zanroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                zanroviList.DataSource = response.Content.ReadAsAsync<List<Zanrovi>>().Result;
                zanroviList.ValueMember = "ZanrID";
                zanroviList.DisplayMember = "Naziv";
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite odustati", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                filmOpenFileDialog.ShowDialog();
                slikaInput.Text = filmOpenFileDialog.FileName;

                film.Slika = File.ReadAllBytes(slikaInput.Text);
                Image orgImage = Image.FromFile(slikaInput.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidthFilm"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeightFilm"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidthFilm"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeightFilm"]);

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

                        film.SlikaThumb = ms.ToArray();
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
                film.Slika = null;
                film.SlikaThumb = null;
                slikaInput.Text = null;
                slikaPictureBox.Image = null;
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (film == null)
                {
                    film = new Filmovi();
                }

                film.Naziv = nazivInput.Text;
                film.IzvorniNaziv = izvorniNazivInput.Text;
                film.GodinaIzdavanja = Convert.ToInt16(godinaIzdavanjaInput.Text);
                film.Trajanje = Convert.ToInt16(trajanjeInput.Text);
                film.Opis = opisInput.Text;
                film.Trailer = trailerInput.Text;
                film.Zanrovi = zanroviList.CheckedItems.Cast<Zanrovi>().ToList();

                HttpResponseMessage response = filmoviService.PostResponse(film);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_movie_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.StatusCode);
                } 
            }
        }

        #region Validation
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.movie_name_req);
            }
            else
            {
                errorProvider.SetError(nazivInput, null);
            }
        }

        private void izvorniNazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(izvorniNazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(izvorniNazivInput, Messages.movie_org_req);
            }
            else
            {
                errorProvider.SetError(izvorniNazivInput, null);
            }
        }

        private void zanroviList_Validating(object sender, CancelEventArgs e)
        {
            if (zanroviList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(zanroviList, Messages.genre_req);
            }
            else
                errorProvider.SetError(zanroviList, null);
        }

        private void godinaIzdavanjaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(godinaIzdavanjaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(godinaIzdavanjaInput, Messages.movie_year_req);
            }
            else
            {
                errorProvider.SetError(godinaIzdavanjaInput, null);
            }
        }

        private void trajanjeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(trajanjeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(trajanjeInput, Messages.movie_duration_req);
            }
            else
            {
                errorProvider.SetError(trajanjeInput, null);
            }
        }

        private void opisInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(opisInput, Messages.movie_desc_req);
            }
            else
            {
                errorProvider.SetError(opisInput, null);
            }
        }

        private void trailerInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(trailerInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(trailerInput, Messages.movie_trailer_req);
            }
            else if(!ValidationHelper.YoutubeURL(trailerInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(trailerInput, Messages.movie_trailer_err);
            }
            else if (ValidationHelper.YoutubeURL(trailerInput.Text))
            {
                trailerInput.Text = YoutubeUrlConverter.ToEmbedUrl(trailerInput.Text);
            }
            else
            {
                errorProvider.SetError(trailerInput, null);
            }
        }

        private void slikaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(slikaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(slikaInput, Messages.slika_req);
            }
            else
            {
                errorProvider.SetError(slikaInput, null);
            }
        }
    }
    #endregion
}
