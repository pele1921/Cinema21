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
    public partial class AddFrom : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        private Zanrovi zanr = new Zanrovi();

        public AddFrom()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
        }

        private void odustaniButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite odustati", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void spremiButton_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (zanr == null)
                {
                    zanr = new Zanrovi();
                }

                zanr.Naziv = nazivInput.Text;

                HttpResponseMessage response = zanroviService.PostResponse(zanr);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        #region Validation
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.genre_name_req);
            }
            else if (nazivInput.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Messages.genre_name_err);
            }
            else
                errorProvider.SetError(nazivInput, null);
        }
        #endregion
    }
}
