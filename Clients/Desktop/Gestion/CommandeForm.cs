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
			LoadCommande();
		}
		public async void LoadCommande()
		{
			Task<CommandeDto> commandeTask = _commandeService.GetCommande();
			CommandeDto commande = await commandeTask;
			bindingSourceCommande.DataSource = commande.ListIngredientQteDTOs;
			montantTotalLbl.Text = commande.TotalPrix.ToString();


			dataGridView1.DataSource = bindingSourceCommande;

		}


		private async void btnAfficher_Click(object sender, EventArgs e)
		{
			try
			{



				await _commandeService.GetCommande();
				MessageBox.Show("Voici la commande");
			}
			catch (Exception)
			{

				MessageBox.Show("Votre commande ne peut etre visualisée");
			}
		}
	}
}
