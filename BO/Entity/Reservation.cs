using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Reservation
    {
        /// <summary>
        /// Identifiant reservation
        /// </summary>
        public int? IdResa { get; set; }
        /// <summary>
        /// Identifiant client
        /// </summary>
        public int? IdClient { get; set; }
        /// <summary>
        /// Identifiant Menu
        /// </summary>
        public int? IdMenu { get; set; }
        /// <summary>
        /// Date de reservation
        /// </summary>
        public DateTime DateResa { get; set; }
        /// <summary>
        /// nombre de reservations
        /// </summary>
        public int? NbResa { get; set; }
        /// <summary>
        /// Formule matin
        /// </summary>
        public bool FormMatin { get; set; }
        /// <summary>
        /// Formule de midi
        /// </summary>
        public bool FormMidi { get; set; }
        /// <summary>
        /// Formule du soir
        /// </summary>
        public bool FormSoir { get; set; }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Reservation()
        {
        }
        /// <summary>
        /// constructeur avec tous les arguments
        /// </summary>
        /// <param name="idResa">Identifiant reservation</param>
        /// <param name="idClient">Identifiant client</param>
        /// <param name="idMenu">Identifiant Menu</param>
        /// <param name="dateResa">Date de reservation</param>
        /// <param name="nbResa">Nombre de reservations</param>
        /// <param name="formMatin">Formule matin</param>
        /// <param name="formMidi">Formule de midi</param>
        /// <param name="formSoir">Formule du soir</param>
        public Reservation(int? idResa, int? idClient, int? idMenu, DateTime dateResa, int? nbResa, bool formMatin, bool formMidi, bool formSoir)
        {
            IdResa = idResa;
            IdClient = idClient;
            IdMenu = idMenu;
            DateResa = dateResa;
            NbResa = nbResa;
            FormMatin = formMatin;
            FormMidi = formMidi;
            FormSoir = formSoir;
        }

        public override bool Equals(object obj)
        {
            return obj is Reservation resa &&
                IdResa == resa.IdResa &&
                IdClient == resa.IdClient &&
                IdMenu == resa.IdMenu &&
                DateResa == resa.DateResa &&
                NbResa == resa.NbResa &&
                FormMatin == resa.FormMatin &&
                FormMidi == resa.FormMidi &&
                FormSoir == resa.FormSoir;
            
        }

        public override int GetHashCode()
        {
                return HashCode.Combine(IdResa,IdClient,IdMenu,DateResa,NbResa,FormMatin,FormMidi,FormSoir);
        }
    }
}
