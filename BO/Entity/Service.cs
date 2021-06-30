using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{/// <summary>
/// Entité service
/// </summary>
   public class Service
    {
        /// <summary>
        /// Identifiant du service
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Midi ou soir 1 pour midi 0 pour soir
        /// </summary>
        public bool Midi { get; set; }

        /// <summary>
        /// Date du service
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Liste des plats
        /// </summary>
        public List<Met> ListPlats { get; set; }

        /// <summary>
        /// Constructeur par dfaut
        /// </summary>
        /// 
        public Service()
        {
        }
        /// <summary>
        /// Constructeur aves parametres
        /// </summary>
        /// <param name="id">Identifiant du service</param>
        /// <param name="midi">Service du midi ou non, 1 si oui</param>
        /// <param name="date">Date du service</param>
        /// /// <param name="listMets">recupere la liste des plats</param>
        public Service(int id, bool midi, DateTime date, List<Met> listMets)
        {
            Id = id;
            Midi = midi;
            Date = date;
            ListPlats = listMets;
        }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   Id == service.Id &&
                   Midi == service.Midi &&
                   Date == service.Date&&
                   ListPlats == service.ListPlats; 
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Midi, Date, ListPlats);
        }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
