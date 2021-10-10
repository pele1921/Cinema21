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
    public partial class EditForm : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        private Zanrovi zanr { get; set; }

        public EditForm(int id)
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = zanroviService.GetResponse(id.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                zanr = null;
            }
            else if (response.IsSuccessStatusCode)
            {
                zanr = response.Content.ReadAsAsync<Zanrovi>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            nazivInput.Text = zanr.Naziv;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite odustati", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (zanr != null)
                {
                    zanr.Naziv = nazivInput.Text;
                   
                    HttpResponseMessage response = zanroviService.PutResponse(zanr.ZanrID, zanr);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.edit_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
            }
        }

        #region Validation
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text.Trim()))
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
