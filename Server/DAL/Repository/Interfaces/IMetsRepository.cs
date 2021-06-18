using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
     
    public interface IMetsRepository : IGenericRepository<Met>
    {
        Task<PageResponse<Met>> GetAllAsync(PageRequest pageRequest);
        Task<Met> GetIngredientForMetAsync(int id);
    }
}
