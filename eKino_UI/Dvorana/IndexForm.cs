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

namespace eKino_UI.Dvorana
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);

        public IndexForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {

            HttpResponseMessage response = dvoraneService.GetActionResponse("GetByNaziv", nazivDvoraneTextBox.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Dvorane> dvorane = response.Content.ReadAsAsync<List<Dvorane>>().Result;
                dvoraneGrid.DataSource = dvorane;
                dvoraneGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void nazivDvoraneTextBox_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                nazivDvoraneTextBox.Text = "";
                BindGrid();
            }
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            try
            {
                int dvoranaId = Convert.ToInt32(dvoraneGrid.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_dvorane_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = dvoraneService.DeleteResponse(dvoranaId);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_dvorane_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm f = new EditForm(Convert.ToInt32(dvoraneGrid.SelectedRows[0].Cells[0].Value));
                if (f.ShowDialog() == DialogResult.OK)
                {
                    nazivDvoraneTextBox.Text = "";
                    BindGrid();
                }
            }
            catch
            {
                MessageBox.Show(Messages.error, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}