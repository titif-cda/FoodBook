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
    public interface ITypeRepasRepository : IGenericRepository<TypeRepas>
    {
        Task<PageResponse<TypeRepas>> GetAllAsync(PageRequest pageRequest);
    }
}
