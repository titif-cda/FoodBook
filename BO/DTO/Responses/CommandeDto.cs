using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    public class CommandeDto
    {
        /// <summary>
        /// Date debut de semaine
        /// </summary>
        //public DateTime DateDebutSemaine { get; set; }
        ///// <summary>
        ///// Date Fin de semaine
        ///// </summary>
        //public DateTime DateFinSemaine { get; set; }
        /// <summary>
        /// Montant total de la commande
        /// </summary>
        public float TotalPrix { get; set; }
        /// <summary>
        /// Liste des ingredients avec leur quantité
        /// </summary>
        public List<LigneCommandeDto> ListIngredientQteDTOs { get; set; }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public CommandeDto()
        {
        }
        /// <summary>
        /// Constructeur avec arguments
        /// </summary>
        /// <param name="dateDebutSemaine"></param>
        /// <param name="dateFinSemaine"></param>
        /// <param name="prix"></param>
        /// <param name="listIngredientQteDTOs"></param>
        public CommandeDto( float prix, List<LigneCommandeDto> listIngredientQteDTOs)
        {
            TotalPrix = prix;
            ListIngredientQteDTOs = listIngredientQteDTOs;
        }
    }
}
