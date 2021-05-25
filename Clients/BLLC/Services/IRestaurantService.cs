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
        Task<Met> CreateRepas(Met repa);
        Task<PageResponse<Met>> GetAllRepas(PageRequest pageRequest);
        Task<Met> PutRepas(Met repa);
        Task<bool> DeleteRepas(Met repa);
        #endregion


        #region Menu
        Task<Service> CreateMenu(Service menus);
        Task<PageResponse<Service>> GetAllMenu(PageRequest pageRequest);
        Task<Service> PutMenu(Service menus);
        Task<bool> DeleteMenu(Service menus);
        #endregion
    }
}
