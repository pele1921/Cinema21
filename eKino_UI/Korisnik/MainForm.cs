using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Korisnik
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void popisUlogaButton_Click(object sender, EventArgs e)
        {
            Uloga.IndexForm f = new Uloga.IndexForm();
            f.ShowDialog();
        }

        private void dodajUloguButton_Click(object sender, EventArgs e)
        {
            Uloga.AddForm f = new Uloga.AddForm();
            f.ShowDialog();
        }
    }
}
