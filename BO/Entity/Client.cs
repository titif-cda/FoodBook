using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Client
    {
       
        public int? Id { get; set; }

        /// <summary>
        /// ISBN unique du livre
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Telephone du client
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// email du client
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Login du client
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Password du client
        /// </summary>
     [Required]
        public string Password { get; set; }
        /// <summary>
        /// Role du client
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Client()
        {

        }


        /// <summary>
        /// Constructeur avec les arguments
        /// </summary>
        /// <param name="nom">Midi</param>
        /// <param name="prenom">Prenom</param>
        /// <param name="telephone">Telephone</param>
        /// <param name="email">Email</param>
        public Client(int? id, string nom, string prenom, string tel, string email, string login, string password, string role)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Email = email;
            Login = login;
            Password = password;
            Role = role;
        }

       

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   Nom == client.Nom &&
                   Prenom == client.Prenom &&
                   Tel == client.Tel &&
                   Email == client.Email &&
                   Login == client.Login &&
                   Password == client.Password &&
                   Role == client.Role
                   ;
        }

     

        public override string ToString()
        {
            return Nom + " " + Prenom;
           
        }

        public override int GetHashCode()
        {
            int hashCode = -1053445959;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Role);
            return hashCode;
        }
    }
}
