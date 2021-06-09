using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{/// <summary>
/// Classe de la table de liaison MetsIngredients
/// </summary>
    public class MetsIngredients
    {
        /// <summary>
        /// Quantité necessaire d'ingredients
        /// </summary>
        public float Quantite { get; set; }

        /// <summary>
        /// Identifiant de l'ingredient
        /// </summary>
        public Ingredient Ingredient { get; set; }

        /// <summary>
        /// Identifiant du Met
        /// </summary>
        public int? IdMet { get; set; }



        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MetsIngredients()
        {

        }
        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="quantite"></param>
        /// /// <param name="ingredient"></param>
        /// /// <param name="idMet"></param>
        public MetsIngredients(float quantite, Ingredient ingredient, int idMet)
        {
            Quantite = quantite;
            Ingredient = ingredient;
            IdMet = idMet;
        }

        /// <summary>
        /// verride Equals Methode pour metsIngredients (Liste d'ingredients)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is MetsIngredients metsIngredients &&
                IdMet == metsIngredients.IdMet &&
                Ingredient == metsIngredients.Ingredient &&
                Quantite == metsIngredients.Quantite;
                   
        }

        /// <summary>
        /// Override GetHashCode our metsIngredients (Liste d'ingredients)
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(IdMet, Ingredient, Quantite);
        }
    }
}
