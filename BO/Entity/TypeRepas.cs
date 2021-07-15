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

        public override string ToString()
        {
            return Libelle;
        }

        public override bool Equals(object obj)
        {
            return obj is TypeRepas repas &&
                   Id == repas.Id &&
                   Libelle == repas.Libelle;
        }

        public override int GetHashCode()
        {
            int hashCode = -1077963510;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Libelle);
            return hashCode;
        }
    }
}
