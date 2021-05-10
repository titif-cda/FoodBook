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

namespace TestDesktop
{
    public partial class CrudIngredients : Form
    {
        public bool isCreation = false;
        private readonly ILibrairiService _librairiSercice;
        public CrudIngredients()
        {
            _librairiSercice = new LibrairiService();
            InitializeComponent();
        }
        public void Initialize(Ingredient ingredient)
        {
            if (ingredient == null)
            {

                //creation
                formIngredient1.Initialize(null);
                isCreation = true;

                deleteBtn.Visible = false;
                deleteBtn.Enabled = false;
            }
            else
            {
                //modif
                ActionCrudBtn.Text = "Modifier";
                formIngredient1.Initialize(ingredient);

            }
        }
        private async void CrudBtn_Click(object ingredient, EventArgs e)
        {
            if (isCreation)
            {
                await _librairiSercice.CreateIngredient(formIngredient1.Compute());
            }
            else
            {

                ingredient = await _librairiSercice.ModifyIngredient(formIngredient1.Compute());

                this.Close();
                this.Dispose();
            }
            if (ingredient == null)
            {
                MessageBox.Show("Service Indisponible");
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            await _librairiSercice.DeleteIngredient(formIngredient1.Compute());
            this.Close();
            this.Dispose();
        }
    }
}
