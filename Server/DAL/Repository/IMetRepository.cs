using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
     
    public interface IMetRepository : IGenericRepository<Met>
    {
        Task<PageResponse<Met>> GetAllAsync(PageRequest pageRequest);


    }
}
