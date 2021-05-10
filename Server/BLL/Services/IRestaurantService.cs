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
        Task<Ingredient> CreateIngredient(Ingredient ingredient);

        Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest);

        Task<Ingredient> GetIngredientById(int id);

        Task<Ingredient> ModifyIngredient(Ingredient ingredient);

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
        Task<Menu> CreateMenu(Menu Menus);

        Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest);

        Task<Menu> GetMenuById(int id);

        Task<Menu> ModifyMenu(Menu Menus);

        Task<bool> RemoveMenuById(int id);
        #endregion
    }
}
