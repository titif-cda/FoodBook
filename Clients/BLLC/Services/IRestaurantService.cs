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

        #region Met
        Task<Met> CreateMet(Met met);
        Task<PageResponse<Met>> GetAllMet(PageRequest pageRequest);
        Task<Met> PutMet(Met met);
        Task<bool> DeleteMet(Met met);
        #endregion


        #region Menu
        Task<Service> CreateService(Service service);
        Task<PageResponse<Service>> GetAllService(PageRequest pageRequest);
        Task<Service> PutService(Service service);
        Task<bool> DeleteService(Service service);
        #endregion
    }
}
