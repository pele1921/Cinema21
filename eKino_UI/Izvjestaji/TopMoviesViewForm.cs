using eKino_API.Models;
using eKino_UI.Utilities;
using Microsoft.Reporting.WinForms;
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

namespace eKino_UI.Izvjestaji
{
    public partial class TopMoviesViewForm : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);

        public List<Filmovi_Zarada_Result> result { get; set; }

        public TopMoviesViewForm(List<Filmovi_Zarada_Result> list)
        {
            InitializeComponent();

            result = list;
        }

        private void TopMoviesViewForm_Load(object sender, EventArgs e)
        {
            BindGodineCombo();
            BindReport();
        }

        private void BindReport()
        {
            ReportDataSource rds = new ReportDataSource("dsTopMovies", result);

            if (reportViewer1.LocalReport.DataSources.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Clear();
            }

            reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SetParameters(new ReportParameter("Godina", godineList.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void BindGodineCombo()
        {
            HttpResponseMessage response = projekcijeService.GetActionResponse("GetGodine");

            if (response.IsSuccessStatusCode)
            {
                List<int?> list = response.Content.ReadAsAsync<List<int?>>().Result;
                list.Insert(0, 0000);

                godineList.DataSource = list;
                godineList.DisplayMember = "Godina";
            }
        }

        private void godineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpResponseMessage response = filmoviService.GetActionResponse("GetByZarada", godineList.SelectedValue.ToString());

            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsAsync<List<Filmovi_Zarada_Result>>().Result;
            }

            BindReport();
        }
    }
}
