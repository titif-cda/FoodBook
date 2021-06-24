using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    public class FilterMetPaged: PageRequest
    {
        public int Popularite { get; set; }

        public TypeRepas typeRepas { get; set; }

        public string Recherche { get; set; }

        public FilterMetPaged()
        {
        }
    }
}
