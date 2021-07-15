using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Constitue
    {
        public int IdRepas { get; set; }
        public int IdIngr { get; set; }
        public int Quantite { get; set; }

        public Constitue()
        {
        }

        public Constitue(int idRepas, int idIngr, int quantite)
        {
            IdRepas = idRepas;
            IdIngr = idIngr;
            Quantite = quantite;
        }

        public override bool Equals(object obj)
        {
            return obj is Constitue constitue &&
                   IdRepas == constitue.IdRepas &&
                   IdIngr == constitue.IdIngr &&
                   Quantite == constitue.Quantite;
        }

        public override int GetHashCode()
        {
            int hashCode = -1576246575;
            hashCode = hashCode * -1521134295 + IdRepas.GetHashCode();
            hashCode = hashCode * -1521134295 + IdIngr.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantite.GetHashCode();
            return hashCode;
        }
    }
}
