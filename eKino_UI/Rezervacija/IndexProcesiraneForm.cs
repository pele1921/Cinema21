using eKino_API.Models;
using eKino_UI.Utilities;
using MoreLinq;
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

namespace eKino_UI.Rezervacija
{
    public partial class IndexProcesiraneForm : Form
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijeRoute);

        public IndexProcesiraneForm()
        {
            InitializeComponent();
        }

        private void IndexProcesiraneForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = rezervacijeService.GetActionResponse("GetProcesirane", imeTextBox.Text.Trim()); 

            if (response.IsSuccessStatusCode)
            {
                var rezervacije = response.Content.ReadAsAsync<List<esp_Rezervacije_GetProcesirane_Result>>().Result;
                rezervacijeGrid.DataSource = rezervacije.DistinctBy(x => x.RezervacijaID).ToList();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void rezervacijeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clan.IndexForm f = new Clan.IndexForm(Convert.ToInt32(rezervacijeGrid.SelectedRows[0].Cells[1].Value));
            f.Show();
        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
