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
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<PageResponse<Client>> GetAllAsync(PageRequest pageRequest);
      
        Task<Client> GetClientByUsernameAndPassword(string Login, string password);
        //Task<Client> RegisterClient(RegisterRequest registerRequest);


    }
}