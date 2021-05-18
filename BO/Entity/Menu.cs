using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Menu
    {
        /// <summary>
        /// Identifiant
        /// </summary>
        public int? IdMenu { get; set; }

        /// <summary>
        /// Date du menu
        /// </summary>
        public DateTime DateMenu { get; set; }
        /// <summary>
        /// Nom menu
        /// </summary>
        public string NomMenu { get; set; }

        /// <summary>
        /// Liste des plats
        /// </summary>
        public List<Repas> ListPlats { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Menu()
        {
        }

        /// <summary>
        /// Constructeur avec tous les arguments
        /// </summary>
        /// <param name="idMenu"> Identifiant</param>
        /// <param name="dateMenu"> Date du menu</param>
        /// <param name="nomMenu"> Nom menu</param>
        /// <param name="listPlats"> Constructeur par défaut</param>
        public Menu(int idMenu, DateTime dateMenu, string nomMenu, List<Repas> listPlats)
        {
            IdMenu = idMenu;
            DateMenu = dateMenu;
            NomMenu = nomMenu;
            ListPlats = listPlats;
        }

        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   IdMenu == menu.IdMenu &&
                   DateMenu == menu.DateMenu &&
                   NomMenu == menu.NomMenu &&
                   ListPlats == menu.ListPlats;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdMenu, DateMenu, NomMenu, ListPlats);
        }
    }
}
