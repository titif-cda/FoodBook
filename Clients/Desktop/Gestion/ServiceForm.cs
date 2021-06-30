using BLLC.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Gestion
{
    public partial class ServiceForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        private BindingSource bindingSourceService = new BindingSource();
        private BindingSource bindingSourceMet = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;
        private Service selectedService;

        public ServiceForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadServices();
            LoadListPlatsBox();
        }

        private async Task LoadServices(bool clearSelection = false)
        {
            var servicesPageTask = _restaurantService.GetAllService(new PageRequest(currentPage, defaultPageSize));
           
            Grisage();
            PageResponse<Service> servicePage = await servicesPageTask;
            if (servicePage == null)
            {
                MessageBox.Show("erreur ");
                return;
            }
            else if (servicePage.TotalPages < currentPage)
            {
                PreviousPage();
            }
            maxPage = servicePage.TotalPages.GetValueOrDefault();
            bindingSourceService.DataSource = servicePage.Data;
            serviceDtGv.DataSource = bindingSourceService;
            serviceDtGv.Columns["Id"].Visible = false;
            

            if (clearSelection)
            {
                serviceDtGv.ClearSelection();
            }

        }

        /// <summary>
        /// Fonction pour griser les boutton next et previous
        /// </summary>
        private void Grisage()
        {
            if (currentPage == 1)
            {
                previousServiceBtn.Enabled = false;
            }
            else
            {
                previousServiceBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                nextServiceBtn.Enabled = false;
            }
            else
            {
                nextServiceBtn.Enabled = true;
            }

        }
       
        
        /// <summary>
        /// Fonction pour passer à la page précédente
        /// </summary>
        private void PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshPage();
            }
        }
        /// <summary>
        /// Fonction pour passer à la page suivante
        /// </summary>
        private void NextPage()
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                RefreshPage();
            }
        }
        /// <summary>
        /// fonction pour aller à la derniere page
        /// </summary>
        private async Task LastPage()
        {
            await RefreshPage();
            currentPage = maxPage;
            await RefreshPage();
        }

        /// <summary>
        /// Boutton pour rafraichir la page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshServiceBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
        /// <summary>
        /// Bouton pour passer à la page précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
        /// <summary>
        /// Bouton pour passer à la page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }
        /// <summary>
        /// fonction pour rafraichir la page
        /// </summary>
        private async Task RefreshPage()
        {
            CurrentPageServiceLbl.Text = currentPage.ToString();
            //currentPageLabel.Text = currentPageLabel.ToString();
            await LoadServices();
        }

        private async void LoadListPlatsBox()
        {
            Task<PageResponse<Met>> listePlatsPageTask = _restaurantService.GetAllMet(new PageRequest(currentPage, defaultPageSize));
            PageResponse<Met> mets = await listePlatsPageTask;
            bindingSourceMet.DataSource = mets.Data;

        }

        private async void serviceDtGv_SelectionChanged(object sender, EventArgs e)
        {
            if (serviceDtGv.CurrentRow != null && serviceDtGv.CurrentRow.DataBoundItem != null && serviceDtGv.CurrentRow != null && selectedService?.Id != (serviceDtGv.CurrentRow.DataBoundItem as Service).Id)
            {
                Service serviceSelected = (serviceDtGv.CurrentRow.DataBoundItem as Service);
                selectedService = serviceSelected;
                int? serviceId = serviceSelected?.Id;
                if (serviceId != null)
                {
                    Service service = await _restaurantService.GetDetailsService(serviceId.Value);

                    if (service.ListPlats?.Count() > 0)
                    {
                      
                        entreeServiceLbl.Text = service.ListPlats.Where(metType => metType.TypeRepas.Id == 1).Select(met => met.Libelle).FirstOrDefault();
                        platServiceLbl.Text = service.ListPlats.Where(metType => metType.TypeRepas.Id == 2).Select(met => met.Libelle).FirstOrDefault();
                        dessertServiceLbl.Text = service.ListPlats.Where(metType => metType.TypeRepas.Id == 3).Select(met => met.Libelle).FirstOrDefault();
                    }
                    var serviceType = "";
                    if (service.Midi)
                    {
                        serviceLbl.Text = "Service du midi";
                        serviceType = "midi";
                    }
                    else
                    {
                        serviceLbl.Text = "Service du soir";
                        serviceType = "soir";
                    }
                    dateServiceLbl.Text = service.Date.ToString("dd MMMM yyyy");

                    titreServiceLbl.Text = "Service du " + service.Date.ToString("dddd dd MMM",CultureInfo.CreateSpecificCulture("fr-FR")) + " (" + serviceType.ToString() + ")";
                }
               
            }   
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            using (var crudServiceForm = new CrudServiceForm())
            {
                crudServiceForm.Initialize();
                crudServiceForm.ShowDialog();
                if (crudServiceForm.DialogResult == DialogResult.OK)
                {
                    LastPage();

                }
            }
            
        }

        private async  void serviceDtGv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (serviceDtGv.SelectedRows.Count > 0)
            {
                Service selectedService = (Service)serviceDtGv.SelectedRows[0].DataBoundItem;
                Service service = await _restaurantService.GetDetailsService(selectedService.Id);
                using (var modifyServiceForm = new CrudServiceForm())
                {
                    modifyServiceForm.Initialize(service);
                    var result = modifyServiceForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        RefreshPage();
                    }
                }
            }
        }
    }
}
