using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    /// <summary>
    /// Entité Met
    /// </summary>
    public class Met
    {
        /// <summary>
        /// Identifiant du Met (plat)
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Libelle du Met (plat)
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        ///Description du Met (plat)
        /// </summary>
        public string Description { get; set; }
   
        public TypeRepas TypeRepas { get; set; }

        public List<MetsIngredients> ListDesIngredients { get; set; }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Met()
        {
        }

   /// <summary>
   /// Constructeur avec arguments
   /// </summary>
   /// <param name="id"></param>
   /// <param name="libelle"></param>
   /// <param name="description"></param>
   /// <param name="idType"></param>
   /// <param name="listDesIngredients"></param>
        public Met(int id, string libelle, string description, TypeRepas typeRepas, List<MetsIngredients> listDesIngredients)
        {
            Id = id;
            Libelle = libelle;
            Description = description;
            TypeRepas = typeRepas;
            ListDesIngredients = listDesIngredients;
        }
        /// <summary>
        ///  Override Equals Methode for met
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Met met &&
                   Id == met.Id &&
                   Libelle == met.Libelle &&
                   Description == met.Description &&
                   TypeRepas.Equals(met.TypeRepas) &&
                   ListDesIngredients == met.ListDesIngredients;
        }

        /// <summary>
        /// Override GetHashCode for met
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()

        {
            return HashCode.Combine(Id, Libelle, Description, TypeRepas, ListDesIngredients);
        }
    }
}
