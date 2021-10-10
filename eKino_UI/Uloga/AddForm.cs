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
    public partial class AddForm : Form
    {
        private WebAPIHelper ulogeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UlogeRoute);

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Uloge uloga = new Uloge();
                uloga.Naziv = ulogaTextBox.Text;
                uloga.Opis = opisTextBox.Text;
                HttpResponseMessage response = ulogeService.PostResponse(uloga);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspjeh", "Uspješno ste dodali novu ulogu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
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

        #region Validation
        private void ulogaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ulogaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(ulogaTextBox,"Polje je obavezno");
            }
            else
            {
                errorProvider1.SetError(ulogaTextBox, null);
            }
        }

        private void opisTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(opisTextBox, "Polje je obavezno");
            }
            else
            {
                errorProvider1.SetError(opisTextBox, null);
            }
        }
        #endregion

      
    }
}