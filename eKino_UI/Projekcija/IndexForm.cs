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
    public partial class IndexForm : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProjekcijeRoute);
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);
        private WebAPIHelper uslugeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UslugeRoute);
        private List<Projekcije_Result> sveProjekcije;
        private void BindGrid()
        {
            try
            {
                HttpResponseMessage response = projekcijeService.GetActionResponse("GetByNazivFilma", traziInput.Text);

                if (response.IsSuccessStatusCode)
                {
                    var projekcije = response.Content.ReadAsAsync<List<Projekcije_Result>>().Result;

                    projekcijeDataGridView.DataSource = projekcije.Where(x => x.Aktivna == true && x.DatumProjekcije.Date == (dateTimePicker1.Value.Date)).ToList();
                    projekcijeDataGridView.ClearSelection();
                    if (String.IsNullOrEmpty(traziInput.Text))
                        sveProjekcije = projekcije;
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = projekcijeService.GetActionResponse("GetByNazivFilma", traziInput.Text);

            if (response.IsSuccessStatusCode)
            {
                var projekcije = response.Content.ReadAsAsync<List<Projekcije_Result>>().Result;
                projekcijeDataGridView.DataSource = projekcije.ToList();
                sveProjekcije = projekcije.ToList();
            }
        }


        private void novaProjekcijaButton_Click(object sender, EventArgs e)
        {
            Projekcija.AddForm f = new Projekcija.AddForm();
            f.ShowDialog();
            BindGrid();
        }

        private void izmijeniProjekcijuButton_Click(object sender, EventArgs e)
        {
            try
            {
                Projekcija.EditForm f = new Projekcija.EditForm(Convert.ToInt32(projekcijeDataGridView.SelectedRows[0].Cells[0].Value));
                f.ShowDialog();
                BindGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void obrisiProjekcijuButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(projekcijeDataGridView.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_projection_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = projekcijeService.DeleteResponse(id);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_projection_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    } 
                }
            }
            catch (Exception)
            {

                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(traziInput.Text))
          projekcijeDataGridView.DataSource =  sveProjekcije.Where(x => x.DatumProjekcije.Date == (dateTimePicker1.Value.Date)).ToList();
            else
                projekcijeDataGridView.DataSource = sveProjekcije.Where(x =>x.Film.ToLower().Contains(traziInput.Text.ToLower()) && x.DatumProjekcije.Date == (dateTimePicker1.Value.Date)).ToList();

        }

        private void traziInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
