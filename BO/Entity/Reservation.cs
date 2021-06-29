﻿using System;
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
        public Client Client { get; set; }
        /// <summary>
        /// Identifiant Menu
        /// </summary>
        public Service Service { get; set; }
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Identifiant reservation</param>
        /// <param name="client">Objet Client</param>
        /// <param name="service">Objet Service</param>
        /// <param name="date">Date de reservation</param>
        /// <param name="nb">Nombre de reservations</param>
        /// <param name="entree">choisir entrée</param>
        /// <param name="plat">choisir plat</param>
        /// <param name="dessert">choisir dessert</param>
        public Reservation(int? id, Client client, Service service, DateTime date, int? nb, bool entree, bool plat, bool dessert)
        {
            Id = id;
            Client = client;
            Service = service;
            Date = date;
            Nb = nb;
            Entree = entree;
            Plat = plat;
            Dessert = dessert;
        }

        public Reservation()
        {
        }
        

        public override bool Equals(object obj)
        {
            return obj is Reservation resa &&
                Id == resa.Id &&
                Client.Equals(resa.Client) &&
                Service.Equals(resa.Service) &&
                Date == resa.Date &&
                Nb == resa.Nb&&
                Entree == resa.Entree &&
                Plat == resa.Plat &&
                Dessert == resa.Dessert;

        }

        public override int GetHashCode()
        {
                return HashCode.Combine(Id,Client,Service,Date,Nb,Entree,Plat,Dessert);
        }
    }
}
