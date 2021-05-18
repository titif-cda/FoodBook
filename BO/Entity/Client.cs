using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Client
    {
       
        public int? IdClient { get; set; }

        /// <summary>
        /// ISBN unique du livre
        /// </summary>
        public string NomClient { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string PrenomClient { get; set; }
        /// <summary>
        /// Telephone du client
        /// </summary>
        public string TelClient { get; set; }
        /// <summary>
        /// email du client
        /// </summary>
        public string EmailClient { get; set; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Client()
        {

        }

        /// <summary>
        /// Constructeur avec les arguments
        /// </summary>
        /// <param name="nom">Nom</param>
        /// <param name="prenom">Prenom</param>
        /// <param name="telephone">Telephone</param>
        /// <param name="email">Email</param>
        public Client(string nom, string prenom, string telephone, string email)
        {

            NomClient = nom;
            PrenomClient = prenom;
            TelClient = telephone;
            EmailClient = email;

        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   IdClient == client.IdClient &&
                   NomClient == client.NomClient &&
                   PrenomClient == client.PrenomClient &&
                   TelClient == client.TelClient &&
                   EmailClient == client.EmailClient;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdClient, NomClient, PrenomClient, TelClient, EmailClient);
        }
    }
}
