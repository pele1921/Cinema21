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
    public partial class AddForm : Form
    {
        private WebAPIHelper dvoraneService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.DvoraneRoute);
        public AddForm()
        {

            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                HttpResponseMessage responseMessage = dvoraneService.GetActionResponse("GetDvoranaByNaziv", nazivTextBox.Text.Trim());

                Dvorane dvorana = new Dvorane();
                dvorana = responseMessage.Content.ReadAsAsync<Dvorane>().Result;
                if (dvorana != null)
                    MessageBox.Show(Messages.dvorane_name_err, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Dvorane novaDvorana = new Dvorane();
                    novaDvorana.Naziv = nazivTextBox.Text;
                    novaDvorana.Kapacitet = Convert.ToInt16(kapacitetTextBox.Text);

                    HttpResponseMessage response = dvoraneService.PostResponse(novaDvorana);
                    var Dvorana = response.Content.ReadAsAsync<Dvorane>();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.dvorane_add_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HttpResponseMessage sjedalaDvorane =
                            dvoraneService.PostResponse($"/api/dvorane/{Dvorana.Result.DvoranaID}/addsjedala/{novaDvorana.Kapacitet}", null);
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
                errorProvider.SetError(nazivTextBox, null);
            }


        }

        private void kapacitetInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(kapacitetTextBox.Text) || Convert.ToInt32(kapacitetTextBox.Text) > 400 || Convert.ToInt32(kapacitetTextBox.Text) < 20)
            {
                e.Cancel = true;
                errorProvider.SetError(kapacitetTextBox, Messages.dvorane_capacity);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(kapacitetTextBox, null);
            }
        }

        private void kapacitetTextBox_KeyPress(object sender, KeyPressEventArgs e) // smo brojevi
        {
            base.OnKeyPress(e);
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
#endregion