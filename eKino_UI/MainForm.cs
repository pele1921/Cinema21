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

namespace eKino_UI
{
    public partial class MainForm : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);

        private void Clear()
        {
            if (contentPanel.Controls.Count > 0)
            {
                contentPanel.Controls.Clear();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartForm f = new StartForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void korisniciButton_Click(object sender, EventArgs e)
        {
            Clear();

            Korisnik.MainForm f = new Korisnik.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void dvoraneButton_Click(object sender, EventArgs e)
        {
            Clear();

            Dvorana.MainForm f = new Dvorana.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void rezervacijeButton_Click(object sender, EventArgs e)
        {
            Clear();

            Rezervacija.MainForm f = new Rezervacija.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void clanoviButton_Click(object sender, EventArgs e)
        {
            Clear();

            Clan.MainForm f = new Clan.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void filmoviButton_Click(object sender, EventArgs e)
        {
            Clear();

            Film.MainForm f = new Film.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void projekcijeButton_Click(object sender, EventArgs e)
        {
            Clear();

            Projekcija.MainForm f = new Projekcija.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void pocetnaButton_Click(object sender, EventArgs e)
        {
            Clear();

            StartForm f = new StartForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }

        private void izvjestajButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = filmoviService.GetActionResponse("GetByZarada");

            if (response.IsSuccessStatusCode)
            {
                List<Filmovi_Zarada_Result> list = response.Content.ReadAsAsync< List<Filmovi_Zarada_Result>> ().Result;

                Izvjestaji.TopMoviesViewForm f = new Izvjestaji.TopMoviesViewForm(list);
                f.Show();
            }
        }

        private void uslugaButton_Click(object sender, EventArgs e)
        {
            Clear();

            Usluga.MainForm f = new Usluga.MainForm();
            f.TopLevel = false;
            f.Parent = contentPanel;
            f.Left = (this.contentPanel.Width - f.Width) / 2;
            f.Top = (this.contentPanel.Height - f.Height) / 2;
            f.Show();
        }
    }
}
