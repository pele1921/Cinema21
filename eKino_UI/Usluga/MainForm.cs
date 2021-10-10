using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Usluga
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void popisUslugaButton_Click(object sender, EventArgs e)
        {
            Usluga.IndexForm f = new Usluga.IndexForm();
            f.ShowDialog();
        }

        private void dodajUsluguButton_Click(object sender, EventArgs e)
        {
            Usluga.AddForm f = new Usluga.AddForm();
            f.ShowDialog();
        }
    }
}
