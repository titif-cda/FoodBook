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
        /// <summary>
        /// Objet TypeRepas
        /// </summary>
        public TypeRepas TypeRepas { get; set; }
        /// <summary>
        /// Liste des ingredients pour un met
        /// </summary>
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
            var r = obj is Met met &&
                   Id == met.Id;
            return r;
        }


        public override string ToString()
        {
            return Libelle;
        }

        public override int GetHashCode()
        {
            int hashCode = 600343996;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Libelle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<TypeRepas>.Default.GetHashCode(TypeRepas);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<MetsIngredients>>.Default.GetHashCode(ListDesIngredients);
            return hashCode;
        }
    }
}
