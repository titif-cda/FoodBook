using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    public class IngredientQteDTO
    {
        /// <summary>
        /// Quantité d d'ingredients
        /// </summary>
        public float Quantite {get; set;}
        /// <summary>
        /// Objet Ingredient
        /// </summary>
        public Ingredient ingredient { get; set; }

        /// <summary>
        /// constructeur avec parametres 
        /// </summary>
        /// <param name="quantite"></param>
        /// <param name="ingredient"></param>
        public IngredientQteDTO(float quantite, Ingredient ingredient)
        {
            Quantite = quantite;
            this.ingredient = ingredient;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public IngredientQteDTO()
        {
        }

       
    }
}
