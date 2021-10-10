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
    public partial class ReportRezervacijeViewForm : Form
    {
        public List<esp_Rezervacije_GetKarte_Result> aktivneRezervacije { get; set; }
        public string Kupac { get; set; }
        public string Ukupno { get; set; }
        public string BrojNarudzbe { get; set; }
        public string DatumPrintanja { get; set; }
        public string DatumPrikazivanja { get; set; }
        public ReportRezervacijeViewForm()
        {
            InitializeComponent();
        }

        private void ReportRezervacijeViewForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRezervacije", aktivneRezervacije);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Kupac", Kupac));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojNarudzbe", BrojNarudzbe));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Ukupno", Ukupno));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumPrintanja", DatumPrintanja));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumPrikazivanja", DatumPrikazivanja));


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
