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

        public int? typeRepasId { get; set; }

        public string Recherche { get; set; }

        public FilterMetPaged()
        {
        }

        public FilterMetPaged(int? Page, int? PageSize, int popularite = 0, int? typeRepasId = null, string recherche = null) : base(Page, PageSize)
        {
            Popularite = popularite;
            this.typeRepasId = typeRepasId;
            Recherche = recherche;
        }
    }
}
