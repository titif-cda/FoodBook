using BLLC.Services;
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
    public partial class crudIngredientsForm : Form
    {
        Ingredient CurrentIngredient;
        public bool isCreation = false;
        private readonly IRestaurantService _restaurantService;
    
        public crudIngredientsForm()
        {
            _restaurantService = new RestaurantService();
            InitializeComponent();
        }

        public void Initialize(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                
                //creation
                ingredientsControl1.Initialize(null);
                isCreation = true;

                deleteIngredientBtn.Visible = false;
                deleteIngredientBtn.Enabled = false;
            }
            else
            {
                //modif
                
                ActionCrudIngredientBtn.Text = "Modifier";
                ingredientsControl1.Initialize(ingredient);

            }
        }
       
         private async void deleteIngredientBtn_Click(object sender, EventArgs e)
         {
            await _restaurantService.DeleteIngredient(ingredientsControl1.Compute());
            this.Close();
            this.Dispose();
         }

        private async void ActionCrudIngredientBtn_Click(object ingredient, EventArgs e)
        {
            if (isCreation)
            {
                await _restaurantService.CreateIngredient(ingredientsControl1.Compute());
            }
            else
            {

                ingredient = await _restaurantService.PutIngredient(ingredientsControl1.Compute());

                this.Close();
                this.Dispose();
            }
            if (ingredient == null)
            {
                MessageBox.Show("Service Indisponible");
            }
        }
    }
}
