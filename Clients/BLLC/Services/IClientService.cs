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
    public interface IClientService
    {
        Task<Client> CreateClient(Client client);
        Task<PageResponse<Client>> GetAllClients(PageRequest pageRequest);

        Task<Client> PutClient(Client client);
        Task<bool> DeleteClient(Client client);
    }
}
