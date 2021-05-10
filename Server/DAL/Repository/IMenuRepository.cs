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
    public interface IMenuRepository  : IGenericRepository<Menu> 
    {
        Task<PageResponse<Menu>> GetAllAsync(PageRequest pageRequest);
    }
}
