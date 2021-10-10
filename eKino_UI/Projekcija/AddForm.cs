using eKino_API.Models;
using eKino_UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Projekcija
{
    public partial class AddForm : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper uslugeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UslugeRoute);
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);

        private void BindDvoraneCombo()
        {
            HttpResponseMessage response = dvoraneService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Dvorane> dvorane = response.Content.ReadAsAsync<List<Dvorane>>().Result;
                dvorane.Insert(0, new Dvorane());
                dvoraneList.DataSource = dvorane;
                dvoraneList.ValueMember = "DvoranaID";
                dvoraneList.DisplayMember = "Naziv";
            }
        }


        private void BindFilmoviCombo()
        {
            HttpResponseMessage response = filmoviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Filmovi> filmovi = response.Content.ReadAsAsync<List<Filmovi>>().Result;
                filmovi.Insert(0, new Filmovi());
                filmoviList.DataSource = filmovi;
                filmoviList.ValueMember = "FilmID";
                filmoviList.DisplayMember = "Naziv";
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindFilmoviCombo();
            BindDvoraneCombo();
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
            Projekcije projekcija = new Projekcije();

            projekcija.FilmID = Convert.ToInt32(filmoviList.SelectedValue);
            Usluge usluga = new Usluge();
            usluga.Naziv = (filmoviList.SelectedItem as Filmovi).Naziv;

            if (String.IsNullOrEmpty(cijenaTextBox.Text))
            {
                MessageBox.Show("Greska", "Cijena je obavezna", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            usluga.Cijena = Convert.ToInt32(cijenaTextBox.Text);
            HttpResponseMessage responseUsluga = uslugeService.PostResponse(usluga);
            if (responseUsluga.IsSuccessStatusCode)
            {
                usluga = responseUsluga.Content.ReadAsAsync<Usluge>().Result;
                projekcija.UslugaID = Convert.ToInt32(usluga.UslugaID);
            }
            else
            {
                MessageBox.Show("Error Code" + responseUsluga.StatusCode + " : Message - " + responseUsluga.ReasonPhrase);
            }
            projekcija.DvoranaID = Convert.ToInt32(dvoraneList.SelectedValue);
            projekcija.DatumProjekcije = dateTimePicker.Value;

            HttpResponseMessage response = projekcijeService.PostResponse(projekcija);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.add_projection_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void cijenaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cijenaTextBox.Text, "[^0-9]"))
            {
                cijenaTextBox.Text = cijenaTextBox.Text.Remove(cijenaTextBox.Text.Length - 1);
            }
        }
    }
}
