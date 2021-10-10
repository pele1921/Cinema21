using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void popisKorisnikaButton_Click(object sender, EventArgs e)
        {
            Korisnik.IndexForm f = new Korisnik.IndexForm();
            f.ShowDialog();
        }

        private void dodajKorisnikaButton_Click(object sender, EventArgs e)
        {
            Korisnik.AddForm f = new Korisnik.AddForm();
            f.ShowDialog();
        }

        private void popisFilmovaButton_Click(object sender, EventArgs e)
        {
            Film.IndexForm f = new Film.IndexForm();
            f.ShowDialog();
        }

        private void dodajFilmButton_Click(object sender, EventArgs e)
        {
            Film.AddForm f = new Film.AddForm();
            f.ShowDialog();
        }

        private void popisDvoranaButton_Click(object sender, EventArgs e)
        {
            Dvorana.IndexForm f = new Dvorana.IndexForm();
            f.ShowDialog();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Dvorana.AddForm f = new Dvorana.AddForm();
            f.ShowDialog();
        }

        private void popisProjekcijaButton_Click(object sender, EventArgs e)
        {
            Projekcija.IndexForm f = new Projekcija.IndexForm();
            f.ShowDialog();
        }

        private void dodajProjekcijuButton_Click(object sender, EventArgs e)
        {
            Projekcija.AddForm f = new Projekcija.AddForm();
            f.ShowDialog();
        }

        private void aktivneRezervacijeButton_Click(object sender, EventArgs e)
        {
            Rezervacija.IndexForm f = new Rezervacija.IndexForm();
            f.ShowDialog();
        }

        private void procesiraneRezervacijeButton_Click(object sender, EventArgs e)
        {
            Rezervacija.IndexProcesiraneForm f = new Rezervacija.IndexProcesiraneForm();
            f.ShowDialog();
        }
    }
}
