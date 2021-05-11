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
    public partial class listClients : Form
    {
        private readonly IClientService _clientService;
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 10;
        private int maxPage;
        public listClients()
        {
            InitializeComponent();
            LoadClients();
        }

        private async void LoadClients()
        {
            Task<PageResponse<Client>> clientPageTask = _clientService.GetAllClients(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Client> clientPage = await clientPageTask;
            maxPage = clientPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = clientPage.Data;
            foreach (var item in clientPage.Data )
            {
                clientFlp.Controls.Add(this);  
                    
            }
            //Task<PageResponse<Client>> clientPageTask = _clientService.GetAllClients(new PageRequest(currentPage, defaultPageSize));
            //PageResponse<Client> clientPage = await clientPageTask;
            //maxPage = clientPage.TotalPages.GetValueOrDefault();
            //bindingSource.DataSource = clientPage.Data;

            //ClientdataGridView.DataSource = bindingSource;
            //Grisage();

        }
    }
}
