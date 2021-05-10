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

namespace TestDesktop.UserControls
{
    public partial class formIngredient : UserControl
    {
        public formIngredient()
        {
            InitializeComponent();
        }
        public void Initialize(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                IdIngredientBox.Text = ingredient.IdIngr.ToString();
                NameIngredientBox.Text = ingredient.NomIngr.ToString();
                PriceBox.Text = ingredient.PrixIngr.ToString();

            }
        }
        public Ingredient Compute()
        {
            int id = 0;

            if (!int.TryParse(IdIngredientBox.Text, out id))
            {
                id = -1;

            }
            return new Ingredient()
            {
                IdIngr = (id == -1) ? null : id,
                NomIngr = NameIngredientBox.Text,
                //PrixIngr = float.TryParse(PriceBox.Text.ToString())
                PrixIngr = Single.Parse(PriceBox.Text) 

            };
        }

    }
}
