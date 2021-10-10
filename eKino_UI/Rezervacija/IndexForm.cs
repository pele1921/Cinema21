using eKino_API.Models;
using eKino_UI.Utilities;
using MoreLinq;
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

namespace eKino_UI.Rezervacija
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        private List<esp_Rezervacije_GetByKorisnickoIme_Result> sveRezervacije;
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
            
            HttpResponseMessage response = rezervacijeService.GetActionResponse("GetByKorisnickoIme", imeTextBox.Text);

            if (response.IsSuccessStatusCode)
            {
                var rezervacije = response.Content.ReadAsAsync<List<esp_Rezervacije_GetByKorisnickoIme_Result>>().Result;
                sveRezervacije = rezervacije;
                rezervacijeGrid.DataSource = rezervacije;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
           
            HttpResponseMessage responseFilmovi = filmoviService.GetResponse();

            if (responseFilmovi.IsSuccessStatusCode)
            {
                List<Filmovi> lista = responseFilmovi.Content.ReadAsAsync<List<Filmovi>>().Result;
                filmoviCombo.DisplayMember = "Naziv";
                filmoviCombo.ValueMember = "FilmID";
                lista.Insert(0, new Filmovi { Naziv = "<Izaberite film>" });
                filmoviCombo.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

            HttpResponseMessage responseZanrovi = zanroviService.GetResponse();

            if (responseZanrovi.IsSuccessStatusCode)
            {
                List<Zanrovi> lista = responseZanrovi.Content.ReadAsAsync<List<Zanrovi>>().Result;
                zanroviCombo.DisplayMember = "Naziv";
                zanroviCombo.ValueMember = "ZanrID";
                lista.Insert(0, new Zanrovi { Naziv = "<Izaberite žanr>" });
                zanroviCombo.DataSource = lista;
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {
            Pretraga();

        }

        private void rezervacijeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clan.IndexForm f = new Clan.IndexForm(Convert.ToInt32(rezervacijeGrid.SelectedRows[0].Cells[0].Value));
            f.Show();
        }

        private void filmoviCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            if (filmoviCombo.SelectedIndex == 0 && String.IsNullOrEmpty(imeTextBox.Text) && zanroviCombo.SelectedIndex == 0)
                rezervacijeGrid.DataSource = sveRezervacije;
            else if (filmoviCombo.SelectedIndex == 0 && String.IsNullOrEmpty(imeTextBox.Text))
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where(x => x.Zanr.ToLower() == zanroviCombo.Text.ToLower()).ToList();
            }
            else if (filmoviCombo.SelectedIndex == 0 && zanroviCombo.SelectedIndex == 0)
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where
                       (x => x.Korisnicko_Ime.ToLower() == imeTextBox.Text.ToLower()).ToList();
            }
            else if (String.IsNullOrEmpty(imeTextBox.Text) && zanroviCombo.SelectedIndex == 0)
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where(x => x.Naziv_Filma.ToLower() == filmoviCombo.Text.ToLower()).ToList();
            }
            else if (filmoviCombo.SelectedIndex == 0)
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where
                          (x => x.Zanr.ToLower() == zanroviCombo.Text.ToLower() && x.Korisnicko_Ime.ToLower().StartsWith(imeTextBox.Text.Trim().ToLower()))
                          .ToList();
            }
            else if (zanroviCombo.SelectedIndex == 0)
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where
                         (x => x.Naziv_Filma.ToLower() == filmoviCombo.Text.ToLower() && x.Korisnicko_Ime.ToLower().StartsWith(imeTextBox.Text.Trim().ToLower()))
                         .ToList();
            }
            else if (String.IsNullOrEmpty(imeTextBox.Text))
            {
                rezervacijeGrid.DataSource = sveRezervacije.Where
                         (x => x.Naziv_Filma.ToLower() == filmoviCombo.Text.ToLower() && x.Zanr.ToLower() == zanroviCombo.Text.ToLower())
                         .ToList();
            }
            else {
                rezervacijeGrid.DataSource = sveRezervacije.Where
                         (x => x.Naziv_Filma.ToLower() == filmoviCombo.Text.ToLower() && x.Zanr.ToLower() == zanroviCombo.Text.ToLower() && x.Korisnicko_Ime.ToLower().StartsWith(imeTextBox.Text.Trim().ToLower()))
                         .ToList();
            }
            
        }

        private void zanroviCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

    }
}
