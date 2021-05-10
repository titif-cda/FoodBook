using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    class Author
    {
        public int? Id { get; set; }

        /// <summary>
        /// ISBN unique du livre
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string Prenom { get; set; }
        public Author()
        {

        }
    }
}
