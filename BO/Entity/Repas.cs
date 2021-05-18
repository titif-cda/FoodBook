using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Repas
    {
    
        /// <summary>
        /// Identifiant Repas
        /// </summary>
        public int? IdRepas { get; set; }

        /// <summary>
        /// Identifiant Type repas
        /// </summary>
        public int? IdTypeRepas { get; set; }
        /// <summary>
        /// Libelle Repas
        /// </summary>
        public string LibelleRepas { get; set; }

        /// <summary>
        /// Description Repas
        /// </summary>
        public string DescRepas { get; set; }
        /// <summary>
        /// Constructeur par default
        /// </summary>
        public Repas()
        {

        }
        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="idRepas">Identifiant Repas</param>
        /// <param name="idTypeRepas">Identifiant Type repas</param>
        /// <param name="libelleRepas">Libelle Repas</param>
        /// <param name="descRepas">Description Repas</param>
        public Repas(int? idRepas, int? idTypeRepas, string libelleRepas, string descRepas)
        {
            IdRepas = idRepas;
            IdTypeRepas = idTypeRepas;
            LibelleRepas = libelleRepas;
            DescRepas = descRepas;
        }

        public override bool Equals(object obj)
        {
            return obj is Repas repas &&
                   IdRepas == repas.IdRepas &&
                   IdTypeRepas == repas.IdTypeRepas &&
                   LibelleRepas == repas.LibelleRepas &&
                   DescRepas == repas.DescRepas;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdRepas, IdTypeRepas, LibelleRepas, DescRepas);
        }

    }
}
