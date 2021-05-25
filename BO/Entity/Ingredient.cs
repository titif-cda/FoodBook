using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Ingredient
    {
        /// <summary>
        /// Identifiant
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Midi ingredient
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prix Ingredient
        /// </summary>
        public float Prix { get; set; }

        /// <summary>
        /// Constructeur avec tous les arguments
        /// </summary>
        /// <param name="idIngr"> Identifiant</param>
        /// <param name="nomIngr">Midi ingredient </param>
        /// <param name="prixIngr"> Prix Ingredient</param>
        public Ingredient(int idIngr,string nomIngr, float prixIngr)
        {
            Id = idIngr;
            Nom = nomIngr;
            Prix = prixIngr;
        }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Ingredient()
        {
        }

      

        public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   Id == ingredient.Id &&
                   Nom == ingredient.Nom &&
                   Prix == ingredient.Prix;


        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nom, Prix);
        }
    }
}
