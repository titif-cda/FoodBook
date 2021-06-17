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
    /// <summary>
    /// Formulaire de la liste des mets (plats)
    /// </summary>
    /// 
    public partial class ListMetForm : Form
    {
        //initialisation des parametres
        private readonly IRestaurantService _restaurantService;
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;
        private Met selectedMet;
        

        public ListMetForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadMets(false);
           
            metDtGv.ReadOnly = true;
        }

        #region Evenements

        /// <summary>
        /// Fonction de chargement de la liste des mets dans la datagridView
        /// </summary>
        /// <param name="clearSelection">Indique que la ligne selectionnée est à désactivé</param>
        private async Task LoadMets(bool clearSelection = false)
        {
            var metsPageTask = _restaurantService.GetAllMet(new PageRequest(currentPage, defaultPageSize));
            //var metPage = await metsPageTask;
            Grisage();
            PageResponse<Met> metPage = await metsPageTask;
            if (metPage == null)
            {
                MessageBox.Show("erreur ");
                return;
            }
            else if(metPage.TotalPages < currentPage)
            {
                PreviousPage();
            }
            maxPage = metPage.TotalPages.GetValueOrDefault();
            bindingSource.DataSource = metPage.Data;
            metDtGv.DataSource = bindingSource;
            metDtGv.Columns["Id"].Visible = false;
            metDtGv.Columns["Description"].Visible = false;
            metDtGv.Columns["TypeRepas"].HeaderText = "Type de Repas";

            if(clearSelection)
            {
                metDtGv.ClearSelection();
            }

        }
        /// <summary>
        /// Boutton pour rafraichir la page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshMetBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
        /// <summary>
        /// Boutton pour supprimer un met
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteMetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Met met = metDtGv.CurrentRow.DataBoundItem as Met;
                await _restaurantService.DeleteMet(met);
                MessageBox.Show("Le plat : " + met.Libelle + " a été supprimé");
                RefreshPage();
            }
            catch (Exception)
            {

                MessageBox.Show("Le plat selectionné n'a pas été supprimé");
            }

        }
        /// <summary>
        /// Evenement au changement de clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void metDtGv_SelectionChanged(object sender, EventArgs e)
        {
            if (metDtGv.CurrentRow != null && selectedMet?.Id != (metDtGv.CurrentRow.DataBoundItem as Met).Id)
            {
                Met metSelected = (metDtGv.CurrentRow.DataBoundItem as Met);
                selectedMet = metSelected;
                int? metId = metSelected?.Id;
                if (metId != null)
                {
                    Met met = await _restaurantService.GetDetailsMet(metId.Value);

                    CurrentMetLbl.Text = met.Libelle;
                    CurrentDescLabel.Text = met.Description;
                    typeLbl.Text = met.TypeRepas?.Libelle;
                    if (met.ListDesIngredients?.Count() > 0)
                        //transforme la liste des ingredients en chaine de string
                        CurrentIngredientsLbl.Text = met.ListDesIngredients.Select(ingredientMet => $"{ingredientMet.Ingredient.Nom}( {ingredientMet.Quantite} )").Aggregate((s1, s2) => $"{s1}, {s2}");
                    else
                    {
                        CurrentIngredientsLbl.Text = "Aucun ingrédient renseigné";
                    }
                }
            }
        }
        /// <summary>
        /// Ajout d'un met au click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMetBtn_Click(object sender, EventArgs e)
        {
            using (var addMetForm = new CrudMetForm())
            {
                addMetForm.Initialize();
                addMetForm.ShowDialog();
                if (addMetForm.DialogResult == DialogResult.OK)
                {
                    LastPage();
                    
                }
            }
        }
        /// <summary>
        /// Bouton pour passer à la page suivante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextMetBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }
        /// <summary>
        /// Bouton pour passer à la page précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousMetBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }
        #endregion

       
        #region Mes Fonctions
        /// <summary>
        /// Fonction pour griser les boutton next et previous
        /// </summary>
        private void Grisage()
        {
            if (currentPage == 1)
            {
                PreviousMetBtn.Enabled = false;
            }
            else
            {
                PreviousMetBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                NextMetBtn.Enabled = false;
            }
            else
            {
                NextMetBtn.Enabled = true;
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
        /// Fonction pour passer à la dernière page
        /// </summary>
        private async Task LastPage()
        {
            await RefreshPage();
            currentPage = maxPage;
            await RefreshPage();
        }
        /// <summary>
        /// fonction pour rafraichir la page
        /// </summary>
        private async Task RefreshPage()
        {
            CurentPageMetLbl.Text = currentPage.ToString();
            //currentPageLabel.Text = currentPageLabel.ToString();
            await LoadMets();
        }
        #endregion

        private async void metDtGv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (metDtGv.SelectedRows.Count > 0)
            {
                Met selectedMet = (Met)metDtGv.SelectedRows[0].DataBoundItem;
                Met met = await _restaurantService.GetDetailsMet(selectedMet.Id);
                using (var modifyMetForm = new CrudMetForm())
                {
                    modifyMetForm.Initialize(met);
                    modifyMetForm.ShowDialog();
                }
            }

        }
    }
}
