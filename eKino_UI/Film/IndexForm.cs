using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eKino_UI.Utilities;
using System.Configuration;
using System.Net.Http;
using eKino_API.Models;

namespace eKino_UI.Film
{
    public partial class IndexForm : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.FilmoviRoute);
        private WebAPIHelper zanroviService = new WebAPIHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZanroviRoute);

        private void BindGrid()
        {
            HttpResponseMessage response = filmoviService.GetActionResponse("GetByNaziv", traziInput.Text);

            if (response.IsSuccessStatusCode)
            {
                var filmovi = response.Content.ReadAsAsync<List<Filmovi>>().Result;
                filmoviDataGridView.DataSource = filmovi.Where(x => x.Aktivan == true).ToList();
                filmoviDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void BindZanroviList()
        {
            HttpResponseMessage response = zanroviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Zanrovi> list = response.Content.ReadAsAsync<List<Zanrovi>>().Result;
                list.Insert(0, new Zanrovi { Naziv = "" });

                zanroviList.DataSource = list;
                zanroviList.ValueMember = "ZanrID";
                zanroviList.DisplayMember = "Naziv";
            }
        }

        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindZanroviList();
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Film.AddForm f = new AddForm();
            f.ShowDialog();
            BindGrid();
        }

        private void izmijeniFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Film.EditForm f = new Film.EditForm(Convert.ToInt32(filmoviDataGridView.SelectedRows[0].Cells[0].Value));
                f.ShowDialog();
                BindGrid();
            }
            catch (Exception)
            {

                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void obrisiFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(filmoviDataGridView.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_movie_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = filmoviService.DeleteResponse(id);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_movie_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(Messages.row_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zanroviList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (zanroviList.SelectedIndex == 0)
                BindGrid();
            else if (String.IsNullOrEmpty(traziInput.Text))
            {
                HttpResponseMessage response = filmoviService.GetActionResponse("GetByZanr", zanroviList.SelectedValue.ToString());

                if (response.IsSuccessStatusCode)
                {
                    filmoviDataGridView.DataSource = response.Content.ReadAsAsync<List<Filmovi_Result>>().Result;
                    filmoviDataGridView.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Error Code - " + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
            else
                Pretraga();
        }

        private void Pretraga()
        {
            if (String.IsNullOrEmpty(traziInput.Text) && zanroviList.SelectedIndex == 0)
                BindGrid();
            else
            {
                if (!String.IsNullOrEmpty(traziInput.Text) && zanroviList.SelectedIndex == 0)
                    BindGrid();
                else
                {
                    HttpResponseMessage response = filmoviService.GetActionResponse("SearchFilm/" + (zanroviList.SelectedItem as Zanrovi).ZanrID.ToString(), traziInput.Text);
                    if (response.IsSuccessStatusCode)
                    {
                        filmoviDataGridView.DataSource = response.Content.ReadAsAsync<List<esp_Filmovi_Search_Result>>().Result;
                    }
                }
            }
        }
    }
}