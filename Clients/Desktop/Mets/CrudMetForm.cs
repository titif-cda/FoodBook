﻿using BLLC.Services;
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

namespace Desktop.Mets
{
    public partial class CrudMetForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        public bool isCreation = false;
        //Binding sources
        private BindingSource bindingSourceDeLaListeDesIngredients = new BindingSource();
        private BindingSource bindingSourceTypeRepas = new BindingSource();
        private BindingSource bindingSourceListeIngredientParPlats = new BindingSource();

        //Initialise une liste d'ingrédients côté client.
        private readonly List<MetsIngredients> AllIngredientsListe = new();
       
        //Initialise les parametres du DTO 
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;
        public int test;
        Met CurrentMet;
        public CrudMetForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
            LoadIngredient();
            LoadListBox();
            ListeIngredientsDtGv.ReadOnly = true;
           
            ListeIngredientparPlatDGV.ReadOnly = true;

        }

        private async void LoadIngredient()
        {

            Task<PageResponse<Ingredient>> ingredientPageTask = _restaurantService.GetAllIngredients(new PageRequest(currentPage, defaultPageSize));
            try
            {
                PageResponse<Ingredient> ingredientPage = await ingredientPageTask;
                if (ingredientPage == null)
                {
                    ErrorMessage();
                    return;
                }
                maxPage = ingredientPage.TotalPages.GetValueOrDefault();
                bindingSourceDeLaListeDesIngredients.DataSource = ingredientPage.Data;
                ListeIngredientsDtGv.DataSource = bindingSourceDeLaListeDesIngredients;
                ListeIngredientsDtGv.Columns["Id"].Visible = false;
                ListeIngredientsDtGv.ClearSelection();

            }
            catch
            {
                ErrorMessage();
            }


        }

        private void LoadListOfIngredient(MetsIngredients ingredientsParMets)
        {
            ListeIngredientparPlatDGV.DataSource = null;
            if (ingredientsParMets != null)
            {
                AllIngredientsListe.Add(ingredientsParMets);
            }

            bindingSourceListeIngredientParPlats.DataSource = AllIngredientsListe;
            ListeIngredientparPlatDGV.DataSource = bindingSourceListeIngredientParPlats;
            //Cache les colonnes non désirées
            ListeIngredientparPlatDGV.Columns["Ingredient"].DisplayIndex = 0;
            ListeIngredientparPlatDGV.Columns["Quantite"].DisplayIndex = 1;
            ListeIngredientparPlatDGV.Columns["IdMet"].Visible = false;
            ListeIngredientparPlatDGV.ClearSelection();
       
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Erreur: Comunication impossible avec le service distant.");
            return;
        }


        private async void AddMetBtn_Click(object sender, EventArgs e)
        {
            CurrentMet = Compute();
            if (isCreation)
            {
                var met = await _restaurantService.CreateMet(CurrentMet);
                if (met == null)
                {
                    MessageBox.Show("Service Indisponible");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
               
            }
            else
            {

                CurrentMet = await _restaurantService.PutMet(CurrentMet);
                DialogResult = DialogResult.OK;
            }
            if (CurrentMet == null)
            {
                MessageBox.Show("La modification n'a pas eté faite Service Indisponible");
            }
        }

        public Met Compute()
        {
            int? id = null;
            if (!isCreation)
            {
                id = CurrentMet.Id;
          

            }

            var ListDesIngredients = bindingSourceListeIngredientParPlats.DataSource as List<MetsIngredients>;
            return new Met()
            {
                Id = Convert.ToInt32(id),
                Libelle = NomMetTBox.Text,
                Description = DescriptionMetRTBox.Text,
                //Recupere l'id de la valeur selectionnée dans la combobox
               //TypeRepasCBox.ValueMember = "Id",
                TypeRepas = new TypeRepas()
                {
                    Id = (TypeRepasCBox.SelectedItem as TypeRepas).Id
                },
                ListDesIngredients = ListDesIngredients
            };
        }
        
        
        public void Initialize(Met met = null)
        {
            if (met == null)
            {
                CurrentMet = new Met();
                //creation
                isCreation = true;
                if (ListeIngredientparPlatDGV.RowCount > 0)
                {
                    CurrentMet.Libelle = NomMetTBox.Text;
                    CurrentMet.Description = DescriptionMetRTBox.Text;
                    //Recupere l'id de la valeur selectionnée dans la combobox
                    TypeRepasCBox.ValueMember = "Id";
                    CurrentMet.TypeRepas = new TypeRepas();
                    CurrentMet.TypeRepas.Id = int.Parse(TypeRepasCBox.SelectedValue.ToString());
                    CurrentMet.ListDesIngredients = AllIngredientsListe;
                }
            }
            else
            {
               //var ListDesIngredients = bindingSourceListeIngredientParPlats.DataSource as List<MetsIngredients>;
                CurrentMet = met;
                //modif
                CrudMetBtn.Text = "Modifier";

                NomMetTBox.Text = met.Libelle.ToString();
                DescriptionMetRTBox.Text = met.Description.ToString();
                ListeIngredientparPlatDGV.DataSource = met.ListDesIngredients; 
                
            }
           
        }
        private async void LoadListBox()
        {
            Task<PageResponse<TypeRepas>> typeRepasPageTask = _restaurantService.GetAllTypeRepas(new PageRequest(currentPage, defaultPageSize));
            PageResponse<TypeRepas> typeRepas = await typeRepasPageTask;
            bindingSourceTypeRepas.DataSource = typeRepas.Data;
            TypeRepasCBox.DataSource = bindingSourceTypeRepas;
            TypeRepasCBox.DisplayMember = "Libelle";
            
        }

        private void AddToListForMetBtn_Click(object sender, EventArgs e)
        {
            MetsIngredients newMetIngredient = new();
            if (this.ListeIngredientsDtGv.SelectedRows.Count > 0)
            {
             
                if (string.IsNullOrEmpty(QuantiteIngredientParMetTxBox.Text))
                {
                    MessageBox.Show("Veuillez saisir la quanbtité");
                    QuantiteIngredientParMetTxBox.Focus();
                }
                else
                {
                    newMetIngredient.Ingredient = ListeIngredientsDtGv.Rows[ListeIngredientsDtGv.CurrentRow.Index].DataBoundItem as Ingredient;
                    try
                    {
                        newMetIngredient.Quantite = float.Parse(QuantiteIngredientParMetTxBox.Text);
                        ListeIngredientsDtGv.Rows.RemoveAt(this.ListeIngredientsDtGv.CurrentRow.Index);
                        LoadListOfIngredient(newMetIngredient);
                    }
                    catch(FormatException formateException)
                    {
                        MessageBox.Show("Veuillez saisir une quantité valide !");
                    }
                }
               
                QuantiteIngredientParMetTxBox.Clear();
            }
        }

        private void DeleteFromListForMetBtn_Click(object sender, EventArgs e)
        {
          
            if (this.ListeIngredientsDtGv.SelectedRows.Count > 0)
            {
                
                bindingSourceDeLaListeDesIngredients.Add((ListeIngredientparPlatDGV.CurrentRow.DataBoundItem as MetsIngredients).Ingredient);
                //ListeIngredientparPlatDGV.Rows.RemoveAt(this.ListeIngredientparPlatDGV.CurrentRow.Index);
                bindingSourceListeIngredientParPlats.RemoveAt(this.ListeIngredientparPlatDGV.CurrentRow.Index);
               
            }
          
        }

        private void RefreshPage()
        {
            CurrentMetIngredientLbl.Text = currentPage.ToString();
            this.LoadIngredient();
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
       
        private void Grisage()
        {
            if (currentPage == 1)
            {
                PreviousMetIngredientBtn.Enabled = false;
            }
            else
            {
                PreviousMetIngredientBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                NextMetIngredientBtn.Enabled = false;
            }
            else
            {
                NextMetIngredientBtn.Enabled = true;
            }
        }

        private void PreviousMetIngredientBtn_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void NextMetIngredientBtn_Click(object sender, EventArgs e)
        {
            NextPage();
        }

      
    }
}
