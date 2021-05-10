using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public DateTime DateMenu { get; set; }
        public string NomMenu { get; set; }

        public List<Repas> ListPlats { get; set; }

        public Menu()
        {
        }

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
