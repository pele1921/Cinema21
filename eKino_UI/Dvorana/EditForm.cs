using eKino_API.Models;
using eKino_UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Dvorana
{
    public partial class EditForm : Form
    {
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);
        private eKino_API.Models.Dvorane dvorana { get; set; }
        public EditForm(int dvoranaId)
        {
            this.AutoValidate = AutoValidate.Disable;
            InitializeComponent();
            HttpResponseMessage response = dvoraneService.GetResponse(dvoranaId.ToString());

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                dvorana = null;
            }
            else
            {
                dvorana = response.Content.ReadAsAsync<Dvorane>().Result;
                FillForm();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        void FillForm()
        {
            nazivTextBox.Text = dvorana.Naziv;
        }
        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                HttpResponseMessage responseMessage = dvoraneService.GetActionResponse("GetDvoranaByNaziv", nazivTextBox.Text.Trim());

                Dvorane dvoranaStara = new Dvorane();
                dvoranaStara = responseMessage.Content.ReadAsAsync<Dvorane>().Result;
                if (dvoranaStara != null && dvorana.Naziv != nazivTextBox.Text)
                    MessageBox.Show(Messages.dvorane_name_err, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    dvorana.Naziv = nazivTextBox.Text;
                    HttpResponseMessage response = dvoraneService.PutResponse(dvorana.DvoranaID, dvorana);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.dvorane_update_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
            }

        }

        #region validacija
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTextBox, Messages.dvorane_name_req);
            }
            else if (nazivTextBox.Text.Length < 3 || nazivTextBox.Text.Length > 15)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTextBox, Messages.dvorane_name_length);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(nazivTextBox, "");
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
    }
}
#endregion