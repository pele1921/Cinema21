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
    public partial class ProcessForm : Form
    {
        double ukupnoPotorseno = 0;

        List<esp_Rezervacije_GetKarte_Result> rezervacije;
        private WebAPIHelper rezervacijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijeRoute);
        public ProcessForm(int id, string ime)
        {
            InitializeComponent();
            imeTextBox.Text = ime;
            idTextBox.Text = id.ToString();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = rezervacijeService.GetActionResponse("GetKarte", imeTextBox.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                rezervacije = response.Content.ReadAsAsync<List<esp_Rezervacije_GetKarte_Result>>().Result;
                rezervacijeGrid.DataSource = rezervacije;
                foreach (DataGridViewRow dr in rezervacijeGrid.Rows)
                {
                    ukupnoPotorseno += Convert.ToDouble(dr.Cells[7].Value);
                }
                iznosTextBox.Text = ukupnoPotorseno.ToString() + " KM";
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {
            int selectedUlaznica = Convert.ToInt32(rezervacijeGrid.SelectedRows[0].Cells[0].Value);

            var responseUlaznica = rezervacijeService.GetActionResponse("GetKarteByUlaznica", selectedUlaznica.ToString());
            var ulaznica = responseUlaznica.Content.ReadAsAsync<List<esp_Rezervacije_GetKarte_Result>>().Result;

            HttpResponseMessage response = rezervacijeService.DeleteResponse("deleteulaznica", selectedUlaznica); 

            if (response.IsSuccessStatusCode)
            {

                MessageBox.Show(Messages.rezervacije_process_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Izvjestaji.ReportRezervacijeViewForm frm = new Izvjestaji.ReportRezervacijeViewForm();
                if (responseUlaznica.IsSuccessStatusCode)
                {
                    frm.aktivneRezervacije = ulaznica; 
                }
                frm.BrojNarudzbe = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + idTextBox.Text;
                frm.Ukupno = Convert.ToInt32(rezervacijeGrid.SelectedRows[0].Cells[7].Value).ToString() + " KM";
                frm.Kupac = imeTextBox.Text;
                frm.DatumPrikazivanja = rezervacije.FirstOrDefault().Vrijeme_Rezervacije.Hour.ToString()+":"+ rezervacije.FirstOrDefault().Vrijeme_Rezervacije.Minute.ToString()+":"+ rezervacije.FirstOrDefault().Vrijeme_Rezervacije.Second.ToString();
                frm.DatumPrintanja = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                frm.ShowDialog();
                this.Close();
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
    }
}
