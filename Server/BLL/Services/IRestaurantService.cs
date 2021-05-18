using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IRestaurantService
    {
        #region Ingredient
        /// <summary>
        /// Crée un ingredient dans la base de données
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>Retourne un ingredient sinon une erreur</returns>
        Task<Ingredient> CreateIngredient(Ingredient ingredient);

        /// <summary>
        /// Affiche l'ensemble des Ingredients avec une pagination
        /// </summary>
        /// <param name="pageRequest"></param>
        /// <returns>Retourne une liste d'ingredients</returns>
        Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest);

        /// <summary>
        /// affiche un Ingredient selon son identifiant
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <returns>Retourne un identifiant ou null</returns>
        Task<Ingredient> GetIngredientById(int id);

        /// <summary>
        /// Met à jour un ingredient dans la base de donnée
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns>Retourne un ingredient modifié </returns>
        Task<Ingredient> ModifyIngredient(Ingredient ingredient);

        /// <summary>
        /// Supprime un Ingredient selon son identifiant
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <returns>Retourne succes ou erreur</returns>
        Task<bool> RemoveIngredientById(int id);
        #endregion
        #region TypeRepas
        Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas);

        Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest);

        Task<TypeRepas> GetTypeRepasById(int id);

        Task<TypeRepas> ModifyTypeRepas(TypeRepas tRepas);

        Task<bool> RemoveTypeRepasById(int id);
        #endregion

        #region Repas
        Task<Repas> CreateRepas(Repas Repas);

        Task<PageResponse<Repas>> GetAllRepas(PageRequest pageRequest, Filter filter);

      

        Task<Repas> GetRepasById(int id);

        Task<Repas> ModifyRepas(Repas Repas);

        Task<bool> RemoveRepasById(int id);
        #endregion

        #region Menu
        /// <summary>
        /// Crée un nouveau menu dans la bas de données
        /// </summary>
        /// <param name="Menus"></param>
        /// <returns>Retourne un menu sinon une erreur</returns>
        Task<Menu> CreateMenu(Menu Menus);

        /// <summary>
        /// Affiche l'ensemble des Ingredients avec une pagination
        /// </summary>
        /// <param name="pageRequest"></param>
        /// <returns></returns>
        Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest);

        Task<Menu> GetMenuById(int id);

        Task<Menu> ModifyMenu(Menu Menus);

        Task<bool> RemoveMenuById(int id);
        #endregion
    }
}
