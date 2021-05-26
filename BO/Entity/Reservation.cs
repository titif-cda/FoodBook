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
        public int? Id { get; set; }
        /// <summary>
        /// Identifiant client
        /// </summary>
        public int? IdClient { get; set; }
        /// <summary>
        /// Identifiant Menu
        /// </summary>
        public int? IdService { get; set; }
        /// <summary>
        /// Date de reservation
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// nombre de reservations
        /// </summary>
        public int? Nb { get; set; }
        /// <summary>
        ///constructeur par defaut
        /// </summary>
        public bool Entree{ get; set; }
        public bool Plat{ get; set; }
        public bool Dessert{ get; set; }

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
        /// <param name="entree">choisir entrée</param>
        /// <param name="plat">choisir plat</param>
        /// <param name="dessert">choisir dessert</param>

        public Reservation(int? idResa, int? idClient, int? idMenu, DateTime dateResa, int? nbResa,bool entree,bool plat,bool dessert)
        {
            Id = idResa;
            IdClient = idClient;
            IdService = idMenu;
            Date = dateResa;
            Nb = nbResa;
            Entree = entree;
            Plat = plat;
            Dessert = dessert;


        }

        public override bool Equals(object obj)
        {
            return obj is Reservation resa &&
                Id == resa.Id &&
                IdClient == resa.IdClient &&
                IdService == resa.IdService &&
                Date == resa.Date &&
                Nb == resa.Nb&&
                Entree == resa.Entree &&
                Plat == resa.Plat &&
                Dessert == resa.Dessert;

            ;
              
            
        }

        public override int GetHashCode()
        {
                return HashCode.Combine(Id,IdClient,IdService,Date,Nb,Entree,Plat,Dessert);
        }
    }
}
