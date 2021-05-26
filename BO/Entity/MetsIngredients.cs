using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    class MetsIngredients
    {
        /// <summary>
        /// Quantité necessaire d'ingredients
        /// </summary>
        public float Quantite { get; set; }


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
        public MetsIngredients(float quantite)
        {
            Quantite = quantite;
        }
    }
}
