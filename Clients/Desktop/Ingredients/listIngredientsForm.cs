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

namespace Desktop.Ingredients
{
    public partial class ListIngredientsForm : Form
    {
     

        private readonly IRestaurantService _restaurantService;
        private BindingSource bindingSource = new BindingSource();
        private int currentPage = 1;
        private int defaultPageSize = 15;
        private int maxPage;
      

        public ListIngredientsForm()
        {
            DoubleBuffered = true;
            _restaurantService = new RestaurantService();
            InitializeComponent();
            this.LoadIngredients();
        }

        private async void LoadIngredients()
        {
            Task<PageResponse<Ingredient>> ingredientPageTask = _restaurantService.GetAllIngredients(new PageRequest(currentPage, defaultPageSize));
           try
            {
                PageResponse<Ingredient> ingredientPage = await ingredientPageTask;
                if(ingredientPage == null)
                {
                    ErrorMessage();
                    return;
                }
                maxPage = ingredientPage.TotalPages.GetValueOrDefault();
                bindingSource.DataSource = ingredientPage.Data;
                IngredientDtGv.DataSource = bindingSource;
                IngredientDtGv.Columns["Id"].Visible = false;
                Grisage();
            }
            catch
            {
                ErrorMessage();
            } 

        }
        private void RefreshPage()
        {
            
            CurentPageIngredientLbl.Text = currentPage.ToString();

            //currentPageLabel.Text = currentPageLabel.ToString();
            this.LoadIngredients();
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Erreur: Comunication impossible avec le service distant.");
            return;
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
        private void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            var crudIngredientForm = new CrudIngredientsForm();
            crudIngredientForm.Initialize(null);
            crudIngredientForm.Show();

            crudIngredientForm.FormClosed += CrudIngredientForm_FormClosed;
        }
        private void RefreshIngredientBtn_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void PreviousIngredientBtn_Click(object sender, EventArgs e)
        {

            PreviousPage();
        }
        private void NextIngredientBtn_Click(object sender, EventArgs e)
        {
            Grisage();
            NextPage();
        }
        private void Grisage()
        {
            if (currentPage == 1)
            {
                PreviousIngredientBtn.Enabled = false;
            }
            else
            {
                PreviousIngredientBtn.Enabled = true;
            }

            if (currentPage == maxPage)
            {
                NextIngredientBtn.Enabled = false;
            }
            else
            {
                NextIngredientBtn.Enabled = true;
            }
        }

        private void CrudIngredientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RefreshPage();
        }

        private void IngredientDtGv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (IngredientDtGv.SelectedRows.Count > 0)
            {
                Ingredient selectedIngredient = (Ingredient)IngredientDtGv.SelectedRows[0].DataBoundItem;
                var crudIngredientForm = new CrudIngredientsForm();
                crudIngredientForm.Initialize(selectedIngredient);
                crudIngredientForm.Show();

                crudIngredientForm.FormClosed += CrudIngredientForm_FormClosed;
            }
        }

    
        private void searchTbox_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = IngredientDtGv.DataSource;
            //bs.Filter = "[HeaderText] Like '%" + searchTbox.Text + "%'";
            //IngredientDtGv.DataSource = bs;
        
        }
    }
}
