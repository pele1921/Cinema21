using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using eKino_API.Models;
using eKino_UI.Utilities;
using System.Configuration;
using System.IO;

namespace eKino_UI.Film
{
    public partial class EditForm : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        private Filmovi film { get; set; }

        private void FillForm()
        {
            nazivInput.Text = film.Naziv;
            izvorniNazivInput.Text = film.IzvorniNaziv;
            godinaIzdavanjaInput.Text = film.GodinaIzdavanja.ToString();
            trajanjeInput.Text = film.Trajanje.ToString();
            opisInput.Text = film.Opis;
            trailerInput.Text = film.Trailer;

            if (film.SlikaThumb != null)
            {
                slikaPictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(film.SlikaThumb));
            }
        }

        public EditForm(int id)
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = filmoviService.GetResponse(id.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                film = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                film = response.Content.ReadAsAsync<Filmovi>().Result;
                FillForm();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = zanroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                zanroviList.DataSource = response.Content.ReadAsAsync<List<Zanrovi>>().Result;
                zanroviList.DisplayMember = "Naziv";
                zanroviList.ClearSelected();
            }

            List<string> list = GetCheckedItems();

            for (int count = 0; count < zanroviList.Items.Count; count++)
            {
                Zanrovi temp = zanroviList.Items[count] as Zanrovi;

                if (list.Contains(temp.Naziv))
                {
                    zanroviList.SetItemChecked(count, true);
                }
            }
        }

        private List<string> GetCheckedItems()
        {
            List<string> list = new List<string>();

            foreach (var i in film.FilmoviZanrovi)
            {
                list.Add(i.Zanrovi.Naziv);
            }

            return list;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite odustati", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (film != null)
                {
                    film.Naziv = nazivInput.Text;
                    film.IzvorniNaziv = izvorniNazivInput.Text;
                    film.GodinaIzdavanja = Convert.ToInt16(godinaIzdavanjaInput.Text);
                    film.Trajanje = Convert.ToInt16(trajanjeInput.Text);
                    film.Opis = opisInput.Text;
                    film.Trailer = trailerInput.Text;
                    film.Zanrovi = zanroviList.CheckedItems.Cast<Zanrovi>().ToList();

                    HttpResponseMessage response = filmoviService.PutResponse(film.FilmID, film);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.edit_movie_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            slikaInput.Text = openFileDialog.FileName;

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

        private void slikaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(trailerInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(trailerInput, Messages.movie_trailer_req);
            }
            else
            {
                errorProvider.SetError(trailerInput, null);
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
        #endregion
    }
}
