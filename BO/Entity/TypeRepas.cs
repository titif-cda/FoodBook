using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class TypeRepas
    {
        public int? IdTypeRepas { get; set; }
        public string LibelleTypeRepas { get; set; }

        public TypeRepas()
        {
        }

        public TypeRepas(int? idTypeRepas, string libelleTypeRepas)
        {
            IdTypeRepas = idTypeRepas;
            LibelleTypeRepas = libelleTypeRepas;
        }
    }
}
