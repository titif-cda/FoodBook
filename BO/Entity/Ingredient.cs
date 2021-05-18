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
        public int? IdIngr { get; set; }

        /// <summary>
        /// Nom ingredient
        /// </summary>
        public string NomIngr { get; set; }

        /// <summary>
        /// Prix Ingredient
        /// </summary>
        public float PrixIngr { get; set; }

        /// <summary>
        /// Constructeur avec tous les arguments
        /// </summary>
        /// <param name="idIngr"> Identifiant</param>
        /// <param name="nomIngr">Nom ingredient </param>
        /// <param name="prixIngr"> Prix Ingredient</param>
        public Ingredient(int idIngr,string nomIngr, float prixIngr)
        {
            IdIngr = idIngr;
            NomIngr = nomIngr;
            PrixIngr = prixIngr;
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
                   IdIngr == ingredient.IdIngr &&
                   NomIngr == ingredient.NomIngr &&
                   PrixIngr == ingredient.PrixIngr;


        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdIngr, NomIngr, PrixIngr);
        }
    }
}
