using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface IRestaurantService
    {
        #region  Ingredient
        Task<Ingredient> CreateIngredient(Ingredient ingredient);
        Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest);
        Task<Ingredient> PutIngredient(Ingredient ingredient);
        Task<bool> DeleteIngredient(Ingredient ingredient);
        #endregion

        #region TypeRepas
        Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas);
        Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest);
        Task<TypeRepas> PutTypeRepas(TypeRepas tRepas);
        Task<bool> DeleteTypeRepas(TypeRepas tRepas);
        #endregion

        #region Repas
        Task<Repas> CreateRepas(Repas repa);
        Task<PageResponse<Repas>> GetAllRepas(PageRequest pageRequest);
        Task<Repas> PutRepas(Repas repa);
        Task<bool> DeleteRepas(Repas repa);
        #endregion


        #region Menu
        Task<Menu> CreateMenu(Menu menus);
        Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest);
        Task<Menu> PutMenu(Menu menus);
        Task<bool> DeleteMenu(Menu menus);
        #endregion
    }
}
