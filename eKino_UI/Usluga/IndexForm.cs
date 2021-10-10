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

namespace eKino_UI.Usluga
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UslugeRoute);

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = uslugeService.GetActionResponse("GetUslugeByIme", nazivTextBox.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                uslugeGrid.DataSource = response.Content.ReadAsAsync<List<Usluge>>().Result;
                uslugeGrid.ClearSelection();
            }
        }

        private void nazivTextBox_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {

            try
            {
                int uslugaID = Convert.ToInt32(uslugeGrid.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_usluge_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                HttpResponseMessage response = uslugeService.DeleteResponse(uslugaID);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.usluge_del, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
