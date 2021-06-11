using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using Desktop.Mets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Mets
{
    public partial class ListMetForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 4;
        private int maxPage;

        public ListMetForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadMets();
            metDtGv.ReadOnly = true;
        }

        private async void LoadMets()
        {
            var metsPageTask = _restaurantService.GetAllMet(new PageRequest(currentPage, defaultPageSize));
            //var metPage = await metsPageTask;
            PageResponse<Met> metPage = await metsPageTask;
            if (metPage == null)
            {
                MessageBox.Show("erreur ");
                return;
            }
            maxPage = metPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = metPage.Data;
            metDtGv.DataSource = bindingSource;
            metDtGv.Columns["Id"].Visible = false;
            metDtGv.Columns["Description"].Visible = false;
            metDtGv.Columns["TypeRepas"].HeaderText = "Type de Repas";

        }

        private void AddMetBtn_Click(object sender, EventArgs e)
        {
            var addMetForm = new AddMetForm();
            addMetForm.Show();
        }

        private void NextMetBtn_Click(object sender, EventArgs e)
        {
                NextPage();
        }

        private void PreviousMetBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
        private void PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshPage();
            }
        }
        private void NextPage()
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                RefreshPage();
            }
        }

        private void RefreshPage()
        {
            CurentPageMetLbl.Text = currentPage.ToString();
            //currentPageLabel.Text = currentPageLabel.ToString();
            this.LoadMets();
        }

        private void RefreshMetBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }
}
