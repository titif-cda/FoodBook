using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class ClientForm : Form
    {
        private readonly IClientService _clientService;
        private int currentPage = 1;
        private int defaultPageSize = 10;
        private int maxPage;
        private BindingSource bindingSource = new BindingSource();
        public ClientForm()
        {
            _clientService = new ClientService();
            InitializeComponent();
            this.LoadClients();
        }

        private async void LoadClients()
        {
            Task<PageResponse<Client>> clientPageTask = _clientService.GetAllClients(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Client> clientPage = await clientPageTask;
            maxPage = clientPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = clientPage.Data;

            ClientdataGridView.DataSource = bindingSource;
            Grisage();

        }
        private void Grisage()
        {
            if (currentPage == 1)
            {
                previousBtn.Enabled = false;
            }
            else
            {
                previousBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                nextBtn.Enabled = false;
            }
            else
            {
                nextBtn.Enabled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextPage();
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
            currentPageLabel.Text = currentPage.ToString();

            //currentPageLabel.Text = currentPageLabel.ToString();
            this.LoadClients();
        }
    }
}
