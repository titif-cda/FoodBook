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

        public List<Met> ListPlats { get; set; }
        /// <summary>
        /// Constructeur par dfaut
        /// </summary>
        public Service()
        {
        }
        /// <summary>
        /// Constructeur aves parametres
        /// </summary>
        /// <param name="id"></param>
        /// <param name="midi"></param>
        /// <param name="date"></param>
        public Service(int id, bool midi, DateTime date, List<Met> listPlats)
        {
            Id = id;
            Midi = midi;
            Date = date;
            ListPlats = listPlats;
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
    }
}
