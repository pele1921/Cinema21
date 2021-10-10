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
    public partial class MainForm : Form
    {
        private WebAPIHelper clanoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ClanoviRoute);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = clanoviService.GetActionResponse("GetByName", korisnickoImeTextBox.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                clanoviGrid.DataSource = response.Content.ReadAsAsync<List<Clanovi>>().Result;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }

        private void korisnickoImeTextBox_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void clanoviGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (Convert.ToBoolean(clanoviGrid.Rows[e.RowIndex].Cells[6].EditedFormattedValue) == true)
                {
                    HttpResponseMessage response = clanoviService.GetActionResponse("GetById", (clanoviGrid.Rows[e.RowIndex].Cells[0].Value).ToString());

                    if (response.IsSuccessStatusCode)
                    {
                        Clanovi clan = response.Content.ReadAsAsync<Clanovi>().Result;
                        response = clanoviService.PutResponse(Convert.ToInt32(clanoviGrid.Rows[e.RowIndex].Cells[0].Value), clan);
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
                else
                {
                    HttpResponseMessage response = clanoviService.DeleteResponse(Convert.ToInt32(clanoviGrid.Rows[e.RowIndex].Cells[0].Value));
                }
            }
        }

        private void clanoviGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexForm f = new IndexForm(Convert.ToInt32(clanoviGrid.SelectedRows[0].Cells[0].Value));
            f.Show();
        }
    }
}
