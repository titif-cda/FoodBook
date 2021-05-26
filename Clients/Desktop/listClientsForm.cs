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
using Desktop.Extensions;
namespace Desktop
{
    public partial class listClientsForm : Form
    {
        private readonly IClientService _clientService = new ClientService();
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
   
	
        private int defaultPageSize;
        private int maxPage;
        public listClientsForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            clientTlp.DoubleBuffer(true);
            Responsive();
            LoadClients();

        }

        private async void LoadClients()
        {
            clientTlp.Controls.Clear();

            Task<PageResponse<Client>> clientPageTask = _clientService.GetAllClients(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Client> clientPage = await clientPageTask;
            maxPage = clientPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = clientPage.Data;
            foreach (var client in clientPage.Data )
            {
                var widgetClient = new ClientsControl(client);
                widgetClient.DoubleClick += WidgetClient_DoubleClick;
                clientTlp.Controls.Add(widgetClient);  
                    
            }
            
            Grisage();

        }

        private void WidgetClient_DoubleClick(object sender, EventArgs e)
        {
            ClientsControl widgetClient = sender as ClientsControl;

            DialogResult r = new crudClientForm(widgetClient.CurrentClient).ShowDialog();
            if(r == DialogResult.OK)
            {
                RefreshPage();
            }
        }

        
        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

       

        private void RefreshPage()
        {
            CurentPageLbl.Text = currentPage.ToString();
            this.LoadClients();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                RefreshPage();
            }
        }

        private void PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshPage();
            }
        }

        private void RefreshClientBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void Grisage()
        {
            if (currentPage == 1)
            {
                PreviousBtn.Enabled = false;
            }
            else
            {
                PreviousBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                NextBtn.Enabled = false;
            }
            else
            {
                NextBtn.Enabled = true;
            }
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {

            DialogResult r = new crudClientForm(null).ShowDialog();
            if (r == DialogResult.OK)
            {
                RefreshPage();
            }
        }

        private void Responsive()
        {
            if (this.Height >= 500 && this.Width >=900)
            {
                defaultPageSize = 24;
            }
            else
            {
                defaultPageSize = 6;
            }
        }

        private void listClientsForm_SizeChanged(object sender, EventArgs e)
        {
            Responsive();
        }
    }
}
