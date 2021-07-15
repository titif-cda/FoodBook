using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    public class PageRequest
    {
        /// <summary>
        /// Numéro de la page
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Taille de la page
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public PageRequest()
        {
            Page = 1;
            PageSize = 10;
        }

        public PageRequest(int? page, int? pageSize)
        {
            Page = page;
            PageSize = pageSize;
        }
    }
}
