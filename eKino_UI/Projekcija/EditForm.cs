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
    public partial class EditForm : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper uslugeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UslugeRoute);
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);

        private Projekcije projekcija { get; set; }

        private void BindDvoraneCombo()
        {
            HttpResponseMessage response = dvoraneService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                dvoraneList.DataSource = response.Content.ReadAsAsync<List<Dvorane>>().Result;
                dvoraneList.ValueMember = "DvoranaID";
                dvoraneList.DisplayMember = "Naziv";
            }
        }

        private void BindUslugeCombo()
        {
            HttpResponseMessage response = uslugeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                uslugeList.DataSource = response.Content.ReadAsAsync<List<Usluge>>().Result;
                uslugeList.ValueMember = "UslugaID";
                uslugeList.DisplayMember = "Naziv";
            }
        }

        private void BindFilmoviCombo()
        {
            HttpResponseMessage response = filmoviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                filmoviList.DataSource = response.Content.ReadAsAsync<List<Filmovi>>().Result;
                filmoviList.ValueMember = "FilmID";
                filmoviList.DisplayMember = "Naziv";
            }
        }

        public EditForm(int id)
        {
            InitializeComponent();

            HttpResponseMessage response = projekcijeService.GetResponse(id.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                projekcija = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                projekcija = response.Content.ReadAsAsync<Projekcije>().Result;
            }
        }

        private void FillForm()
        {
            filmoviList.SelectedValue = projekcija.FilmID;
            uslugeList.SelectedValue = projekcija.UslugaID;
            dvoraneList.SelectedValue = projekcija.DvoranaID;
            dateTimePicker.Value = projekcija.DatumProjekcije;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BindFilmoviCombo();
            BindUslugeCombo();
            BindDvoraneCombo();

            FillForm();
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
            if (projekcija != null)
            {
                projekcija.FilmID = Convert.ToInt32(filmoviList.SelectedValue);
                projekcija.UslugaID = Convert.ToInt32(uslugeList.SelectedValue);
                projekcija.DvoranaID = Convert.ToInt32(dvoraneList.SelectedValue);
                projekcija.DatumProjekcije = dateTimePicker.Value;

                HttpResponseMessage response = projekcijeService.PutResponse(projekcija.ProjekcijaID, projekcija);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_projection_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }
    }
}
