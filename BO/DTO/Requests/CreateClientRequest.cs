using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    /// <summary>
    /// Objet de rquête pour créer un client
    /// </summary>
    public class CreateClientRequest
    {
        /// <summary>
        /// ISBN unique du livre
        /// </summary>
        [Required]
        public string Nom { get; set; }

        /// <summary>
        /// Titre du livre
        /// </summary>
        [Required]
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
        [Required()]
        public string Login { get; set; }

        /// <summary>
        /// Password du client
        /// </summary>
        [Required(ErrorMessage = "Le password ne doit pas être vide !")]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$", 
            ErrorMessage = @"Le mot de passe doit contenir:  
8 caractères minimums
1 caractère special
1 caractère en majuscule
1 caractère en minuscule
")]
        public string Password { get; set; }

    }
}
