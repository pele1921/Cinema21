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

namespace eKino_UI.Zanr
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        public IndexForm()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = zanroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                zanroviDataGridView.DataSource = response.Content.ReadAsAsync<List<Zanrovi>>().Result;
                zanroviDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void noviZanrButton_Click(object sender, EventArgs e)
        {
            Zanr.AddFrom f = new Zanr.AddFrom();
            f.ShowDialog();
            BindGrid();
        }

        private void izmijeniZanrButton_Click(object sender, EventArgs e)
        {
            Zanr.EditForm f = new Zanr.EditForm(Convert.ToInt32(zanroviDataGridView.SelectedRows[0].Cells[0].Value));
            f.ShowDialog();
            BindGrid();
        }

        private void obrisiZanrButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(zanroviDataGridView.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_genre_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                HttpResponseMessage response = zanroviService.DeleteResponse(id);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.del_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
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
    }
}
