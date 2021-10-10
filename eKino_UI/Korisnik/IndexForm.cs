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
using System.Net.Http;
using eKino_API.Models;

namespace eKino_UI.Korisnik
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisniciRoute);

        public IndexForm()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetByIme", traziInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                korisniciDataGridView.DataSource = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                korisniciDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void noviKorisnikButton_Click(object sender, EventArgs e)
        {
            Korisnik.AddForm f = new Korisnik.AddForm();
            f.ShowDialog();
            BindGrid();
        }

        private void izmijeniKorisnikButton_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik.EditForm f = new Korisnik.EditForm(Convert.ToInt32(korisniciDataGridView.SelectedRows[0].Cells[0].Value));
                f.ShowDialog();
                BindGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void obrisiKorisnikaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(korisniciDataGridView.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_usr_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = korisniciService.DeleteResponse(id);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
