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

namespace Desktop.Met
{
    public partial class ListMetForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;

        public ListMetForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadMets();
        }

        private async void LoadMets()
        {
            var metsPageTask = _restaurantService.GetAllMet(new PageRequest(currentPage, defaultPageSize));
            var metPage = await metsPageTask;

            if (metPage == null)
            {
                MessageBox.Show("erreur ");
                return;
            }
            maxPage = metPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = metPage.Data;
            metDtGv.DataSource = bindingSource;
            metDtGv.Columns["Id"].Visible = false;




        }

        private void AddMetBtn_Click(object sender, EventArgs e)
        {
            var addMetForm = new AddMetForm();
            //addMetForm.Initialize(null);
            addMetForm.Show();

           // addMetForm.FormClosed += AaddMetForm_FormClosed;
        }

   
    }
}
