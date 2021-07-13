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

        private async void reservationDtGv_SelectionChanged(object sender, EventArgs e)
        {
            if (reservationDtGv.CurrentRow != null && selectedReservation?.Id != (reservationDtGv.CurrentRow.DataBoundItem as Reservation ).Id)
            {
                Reservation reservationSelected = (reservationDtGv.CurrentRow.DataBoundItem as Reservation);
                selectedReservation = reservationSelected;
                int? resaId = reservationSelected.Id;
                if (resaId != null)
                {
                    Reservation reservation = await _clientService.GetDetailsResa(resaId.Value);

                    resaNomLbl.Text = reservation.Client.Nom;
                    resaPrenomLbl.Text = reservation.Client.Prenom;
                    resaNbLbl.Text =  reservation.Nb.ToString() + " plats réservés ";
                    dateServiceLbl.Text = reservation.Service.Date?.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));

                    if (reservation.Service.Midi)
                    {
                        serviceResaLbl.Text = "Service du Midi";
                    }
                    else
                    {
                        serviceResaLbl.Text = "Service du Soir";                        
                    }
                    titreReservationLbl.Text = "Réservation du " + reservation.Date?.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR")) ;
                }

            }
        }
    }
}
