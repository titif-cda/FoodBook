using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class TypeRepas
    {
        /// <summary>
        /// Identifiant du type repas
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Libelle du type repas
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public TypeRepas()
        {
        }
        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="idTypeRepas">Identifiant du type repas</param>
        /// <param name="libelleTypeRepas">Libelle du type repas</param>
        public TypeRepas(int? idTypeRepas, string libelleTypeRepas)
        {
            Id = idTypeRepas;
            Libelle = libelleTypeRepas;
        }
    }
}
