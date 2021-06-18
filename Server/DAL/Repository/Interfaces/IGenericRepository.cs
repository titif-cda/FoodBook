using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Permet d'afficher l'ensemble de l'entité
        /// </summary>
        /// <returns>retourne une liste ou null si echec</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Permet d'afficher une entité selon son identifient
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retourne une entité selon son identifient ou null si echec</returns>
        Task<TEntity> GetAsync(int id);

        /// <summary>
        /// Permet de supprimer une entité dans la bse de données
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns> retourne le nombre de ligne suprimé ou null si echec</returns>
        Task<int> DeleteAsync(long id);
        
        /// <summary>
        /// Permet de mettre à jour l'entité dans la base de données
        /// </summary>
        /// <param name="entity">Entité à mettre à jour</param>
        /// <returns></returns>
        Task <bool> UpdateAsync(TEntity entity);
        
        /// <summary>
        /// Persiste l'entité en base de données
        /// </summary>
        /// <param name="entity">Entité à persiter</param>
        /// <returns>Renvoi l'entité persisté ou null si echec</returns>
        Task<TEntity> InsertAsync(TEntity entity);
    }
}
