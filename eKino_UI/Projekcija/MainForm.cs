using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Projekcija
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void popisKorisnikaButton_Click(object sender, EventArgs e)
        {
            Projekcija.IndexForm f = new Projekcija.IndexForm();
            f.ShowDialog();
        }

        private void dodajKorisnikaButton_Click(object sender, EventArgs e)
        {
            Projekcija.AddForm f = new Projekcija.AddForm();
            f.ShowDialog();
        }
    }
}
