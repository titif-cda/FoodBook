using BO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BO.DTO
{
    public class ProfileDto
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Email { get; set; }
       
        public string Tel { get; set; }

        public string Login { get; set; }

        public ProfileDto()
        {
        }

        public ProfileDto(string nom, string prenom, string email, string telephone, string login)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Tel = telephone;
            Login = login;
        }

        public override bool Equals(object obj)
        {
            return obj is ProfileDto dto &&
                   Nom == dto.Nom &&
                   Prenom == dto.Prenom &&
                   Email == dto.Email &&
                   Tel == dto.Tel &&
                   Login == dto.Login;
        }

        public override int GetHashCode()
        {
            int hashCode = -1328436139;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            return hashCode;
        }

        public Client ConvertToClient()
        {
            return new Client()
            {
                Id = Id,
                Email = Email,
                Login = Login,
                Nom = Nom,
                Prenom = Prenom,
                Tel = Tel
            };
        }
    }
}
