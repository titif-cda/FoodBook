using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IMetsIngredientsRepository : IGenericRepository<MetsIngredients>
    {
        Task<PageResponse<MetsIngredients>> GetAllAsync(PageRequest pageRequest);

        Task<int> DeleteMetIngredientFromMetIdAsync(int? idMet);
    }
}
