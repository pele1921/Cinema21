using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Film
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void dodajZanrButton_Click(object sender, EventArgs e)
        {

            Zanr.AddFrom f = new Zanr.AddFrom();
            f.ShowDialog();
        }

        private void popisZanrovaButton_Click(object sender, EventArgs e)
        {
            Zanr.IndexForm f = new Zanr.IndexForm();
            f.ShowDialog();
        }
    }
}
