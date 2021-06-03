using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IClientService
    {
        #region Reservation
        Task<Reservation> CreateResa(Reservation resa);

        Task<PageResponse<Reservation>> GetAllResa(PageRequest pageRequest);

        Task<Reservation> GetResaById(int id);

        Task<Reservation> ModifyResa(Reservation resa);

        Task<bool> RemoveResaById(int id);
        #endregion

        #region client
        Task<Client> CreateClient(Client client);

        Task<PageResponse<Client>> GetAllClients(BO.DTO.Requests.PageRequest pageRequest);

        Task<Client> GetClientById(int id);

        Task<Client> ModifyClient(Client client);

        Task<bool> RemoveClientById(int id);
        #endregion


        #region Account
        Task<LoginResponse> Login(string username, string password);
       
        #endregion.
    }
}
