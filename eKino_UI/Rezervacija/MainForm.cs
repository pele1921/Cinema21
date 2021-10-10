using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Rezervacija
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aktivneRezervacije_Click(object sender, EventArgs e)
        {
            IndexForm f = new IndexForm();
            f.Show();
        }

        private void procesiraneRezervacije_Click(object sender, EventArgs e)
        {
            IndexProcesiraneForm f = new IndexProcesiraneForm();
            f.Show();
        }
    }
}
