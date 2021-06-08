using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    /// <summary>
    /// Entité Met
    /// </summary>
    public class Met
    {
        /// <summary>
        /// Identifiant du Met (plat)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Libelle du Met (plat)
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        ///Description du Met (plat)
        /// </summary>
        public string Description { get; set; }

        public int? IdType { get; set; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Met()
        {
        }

        /// <summary>
        /// Constructeur avec les arguments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        public Met(int id, string libelle, string description, int idType)
        {
            Id = id;
            Libelle = libelle;
            Description = description;
            IdType = idType;
        }
        /// <summary>
        ///  Override Equals Methode for met
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Met met &&
                   Id == met.Id &&
                   Libelle == met.Libelle &&
                   Description == met.Description &&
                   IdType == met.IdType;
        }

        /// <summary>
        /// Override GetHashCode for met
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()

        {
            return HashCode.Combine(Id, Libelle, Description, IdType);
        }
    }
}
