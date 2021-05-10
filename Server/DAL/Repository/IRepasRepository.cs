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
    public interface IRepasRepository : IGenericRepository<Repas>
    {
        Task<PageResponse<Repas>> GetAllAsync(PageRequest pageRequest, Filter filter);
    }
}
