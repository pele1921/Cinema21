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
    public partial class AddForm : Form
    {
        private WebAPIHelper uslugeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.UslugeRoute);

        public AddForm()
        {
            InitializeComponent();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nazivTextBox.Text))
                MessageBox.Show(Messages.usluge_naziv_err, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (string.IsNullOrEmpty(cijenaTextBox.Text))
                MessageBox.Show(Messages.usluge_cijena_err, "Poruka o grešci", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Usluge usluga = new Usluge();
            usluga.Naziv = nazivTextBox.Text.Trim();
            usluga.Cijena = Convert.ToInt32(cijenaTextBox.Text.Trim());
            HttpResponseMessage response = uslugeService.PostResponse(usluga);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.usluge_succ, "Poruka o uspjehu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);

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
