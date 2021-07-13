using BLLC.Services;
using BO.DTO.Responses;
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
namespace Desktop.Gestion
{
    public partial class CommandeForm : Form
    {
		private readonly ICommandeService _commandeService;
		private BindingSource bindingSourceCommande = new BindingSource();
		private BindingSource bindingSourceCommandePrice = new BindingSource();

		public CommandeForm()
        {
			_commandeService = new CommandeService();
			InitializeComponent();
			
		}
		public async void LoadCommande()
		{
            DateTime dateSelected;
            dateSelected = DateSelectDTP.Value;
            
            DateTime firstDate = dateSelected.Date.GetFirstDateOfWeek(DayOfWeek.Monday);
            DateTime lastDate = dateSelected.Date.GetLastDateOfWeek(DayOfWeek.Sunday);
            //Task<CommandeDto> commandeTask = _commandeService.GetCommande();
            Task<CommandeDto> commandeTask = _commandeService.GetCommandeByDate(firstDate, lastDate);
            CommandeDto commande = await commandeTask;
            if (commande !=null)
            {
                bindingSourceCommande.DataSource = commande.ListIngredientQteDTOs;
                montantTotalLbl.Text = commande.TotalPrix.ToString();
                aCommanderDTGV.DataSource = bindingSourceCommande;
                aCommanderDTGV.ClearSelection();
            }
            else
            {
                MessageBox.Show("Aucune réservations n'est faite pour la semaine du : " + firstDate.ToString("dd MM yyyy") +" au "+ lastDate.ToString("dd MM yyyy"));

            }
			
        }

        public void DateSelectDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSelected;
            dateSelected = DateSelectDTP.Value;
           
            DateTime firstDate = dateSelected.Date.GetFirstDateOfWeek(DayOfWeek.Monday);
            DateTime lastDate = dateSelected.Date.GetLastDateOfWeek(DayOfWeek.Sunday);
           
            label1.Text = firstDate.ToString("dddd dd MMM");
            label2.Text = lastDate.ToString("dddd dd MMM");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCommande();
        }
    }
}
