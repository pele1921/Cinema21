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

namespace eKino_UI.Uloga
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

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
            HttpResponseMessage response = ulogeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ulogeGrid.DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
            }
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite obrisati ulogu", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ulogeGrid.SelectedRows != null)
                {
                    HttpResponseMessage response = ulogeService.DeleteResponse(Convert.ToInt32(ulogeGrid.SelectedRows[0].Cells[0].Value));
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Uspjeh", "Uspješno ste obrisali ulogu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Greška", "Korisnik posjeduje tu ulogu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Greska", "Morate označiti red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Uloga.AddForm f = new Uloga.AddForm();
            f.ShowDialog();
            BindGrid();
        }
    }
}
