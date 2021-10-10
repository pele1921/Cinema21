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

namespace eKino_UI.Clan
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper clanoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ClanoviRoute);
        private WebAPIHelper rezervacijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijeRoute);

        public IndexForm(int clanId)
        {
            InitializeComponent();
            clanIdLabel.Text = clanId.ToString();
        }
        private void FillForm()
        {
            HttpResponseMessage response = clanoviService.GetActionResponse("GetById", clanIdLabel.Text);
            if (response.IsSuccessStatusCode)
            {
                Clanovi clan = response.Content.ReadAsAsync<Clanovi>().Result;

                imeTextBox.Text = clan.Ime;
                prezimeTextBox.Text = clan.Prezime;
                emailTextBox.Text = clan.Email;
                datumTextBox.Text = clan.DatumRegistracije.ToString();
                korisnickoTextBox.Text = clan.KorisnickoIme;
                if (clan.Status)
                    statusTextBox.Text = "Aktivan";
                else
                    statusTextBox.Text = "Neaktivan";

                if (clan.Slika != null)
                {
                    pictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(clan.Slika));
                }
                //  MemoryStream mStream = new MemoryStream();
                //  byte[] pData = clan.Slika;
                //  mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //   Bitmap bm = new Bitmap(mStream, false);

                // pictureBox1.Image = bm;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void IndexForm_Load(object sender, EventArgs e)
        {
            FillForm();
            BindGrid();
            ukupnoTextBox.Visible = false;
            ukupnoLabel.Visible = false;
        }

        private void BindGrid()
        {
            HttpResponseMessage response = rezervacijeService.GetActionResponse("GetByClanovi", korisnickoTextBox.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                rezervacijeGrid.DataSource = response.Content.ReadAsAsync<List<esp_Rezervacije_GetByClanovi_Result>>().Result;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void aktivneButton_Click(object sender, EventArgs e)
        {
            BindGrid();
            procesirajButton.Visible = true;
            ukupnoTextBox.Visible = false;
            ukupnoLabel.Visible = false;

        }

        private void procesiraneButton_Click(object sender, EventArgs e)
        {
            procesirajButton.Visible = false;
            HttpResponseMessage response = rezervacijeService.GetActionResponse("GetProcesirane", korisnickoTextBox.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                rezervacijeGrid.DataSource = response.Content.ReadAsAsync<List<esp_Rezervacije_GetProcesirane_Result>>().Result;
                double ukupnoPotorseno = 0;
                foreach (DataGridViewRow dr in rezervacijeGrid.Rows)
                {
                    ukupnoPotorseno += Convert.ToDouble(dr.Cells[10].Value);
                }
                ukupnoTextBox.Text = ukupnoPotorseno.ToString() + " KM";
                ukupnoTextBox.Visible = true;
                ukupnoLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {
            if (rezervacijeGrid.RowCount < 1)
                MessageBox.Show(Messages.rezervacije_process_fail, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ProcessForm f = new ProcessForm(Convert.ToInt32(clanIdLabel.Text), korisnickoTextBox.Text);
                if (f.ShowDialog() == DialogResult.OK)
                    BindGrid();
            }
        }
    }
}
