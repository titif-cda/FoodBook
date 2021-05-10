using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Repas
    {
    

        public int? IdRepas { get; set; }
        public int? IdTypeRepas { get; set; }
        public string LibelleRepas { get; set; }
        public string DescRepas { get; set; }
        
        public Repas()
        {

        }

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
