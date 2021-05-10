using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Ingredient
    {
        public int? IdIngr { get; set; }
        public string NomIngr { get; set; }
        public float PrixIngr { get; set; }

        public Ingredient(int idIngr,string nomIngr, float prixIngr)
        {
            IdIngr = idIngr;
            NomIngr = nomIngr;
            PrixIngr = prixIngr;
        }

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
