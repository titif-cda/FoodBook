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

namespace Desktop.Gestion
{
    public partial class reservationsForm : Form
    {
        private readonly IClientService _clientService = new ClientService();
        private BindingSource bindingSourceReservation = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;
        private Reservation selectedReservation;

        public reservationsForm()
        {
            InitializeComponent();
            LoadReservation();
        }

        private async void LoadReservation(bool clearSelection = false)
        {
            Task<PageResponse<Reservation>>  resaPageTask = _clientService.GetAllReservations(new PageRequest(currentPage, defaultPageSize));
            try
            {
                PageResponse<Reservation> resaPage = await resaPageTask;
                if (resaPage == null)
                {
                    ErrorMessage();
                    return;
                }
                maxPage = resaPage.TotalPages.GetValueOrDefault();
                bindingSourceReservation.DataSource = resaPage.Data;
                reservationDtGv.DataSource = bindingSourceReservation;
                reservationDtGv.Columns["Id"].Visible = false;
               
            }
            catch
            {
                ErrorMessage();
            }
            
        }

        private void PreviousPage()
        {
            throw new NotImplementedException();
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Erreur: Comunication impossible avec le service distant.");
            return;
        }
    }
}
