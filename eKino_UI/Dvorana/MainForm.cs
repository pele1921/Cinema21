using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Dvorana
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void popisDvoranaButton_Click(object sender, EventArgs e)
        {
            IndexForm f = new IndexForm();
            f.Show();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
