using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Service
    {
        /// <summary>
        /// Identifiant
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Date du menu
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Midi menu
        /// </summary>
        public bool Midi { get; set; }

        /// <summary>
        /// Liste des plats
        /// </summary>
       

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Service()
        {
        }

        /// <summary>
        /// Constructeur avec tous les arguments
        /// </summary>
        /// <param name="idMenu"> Identifiant</param>
        /// <param name="dateMenu"> Date du menu</param>
        /// <param name="midi"> Midi menu</param>
        public Service(int idMenu, bool midi, DateTime dateMenu)
        {
            Id = idMenu;
            Midi = midi;
            Date = dateMenu;
           
           
        }

        public override bool Equals(object obj)
        {
            return obj is Service menu &&
                   Id == menu.Id &&
                   Midi == menu.Midi &&
                   Date == menu.Date;
                   
                 
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Midi, Date);
        }
    }
}
