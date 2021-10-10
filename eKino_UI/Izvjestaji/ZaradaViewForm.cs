using eKino_API.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino_UI.Izvjestaji
{
    public partial class ZaradaViewForm : Form
    {
        public IEnumerable <esp_Rezervacije_GetUkupnoByYear_Result> rezultat { get; set; }
        public ZaradaViewForm(IEnumerable<esp_Rezervacije_GetUkupnoByYear_Result> rez)
        {
            InitializeComponent();
            rezultat = rez;
        }

        private void ZaradaViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRezervacijeZarada",rezultat);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Godina", "2018"));
            this.reportViewer1.RefreshReport();
        }
    }
}
