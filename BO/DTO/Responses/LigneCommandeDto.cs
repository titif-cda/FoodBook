using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    public class LigneCommandeDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string Nom { get; set; }
        
        /// <summary>
        /// Quantité d d'ingredients
        /// </summary>
        public float Quantite {get; set;}
        
        public float Price { get; set; }

        public override bool Equals(object obj)
        {
            return obj is LigneCommandeDto dTO &&
                   Nom == dTO.Nom &&
                   Quantite == dTO.Quantite &&
                   Price == dTO.Price;
        }


        public LigneCommandeDto()
        {
        }

        public LigneCommandeDto(string nom, float quantite, float price)
        {
            Nom = nom;
            Quantite = quantite;
            Price = price;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
