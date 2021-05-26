using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Met
    {
    
        /// <summary>
        /// Identifiant Repas
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Identifiant Type repas
        /// </summary>
        public int? IdType { get; set; }
        /// <summary>
        /// Libelle Repas
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Description Repas
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Constructeur par default
        /// </summary>
        public Met()
        {

        }
        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="idRepas">Identifiant Repas</param>
        /// <param name="idTypeRepas">Identifiant Type repas</param>
        /// <param name="libelleRepas">Libelle Repas</param>
        /// <param name="descRepas">Description Repas</param>
        public Met(int? idRepas, int? idTypeRepas, string libelleRepas, string descRepas)
        {
            Id = idRepas;
            IdType = idTypeRepas;
            Libelle = libelleRepas;
            Description = descRepas;
        }

        public override bool Equals(object obj)
        {
            return obj is Met repas &&
                   Id == repas.Id &&
                   IdType == repas.IdType &&
                   Libelle == repas.Libelle &&
                   Description == repas.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdType, Libelle, Description);
        }

    }
}
