using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class ClientService : IClientService
    {
        private readonly IUnitOfWork _db;
        private readonly ILogger<ClientService> _logger;

        public ClientService(IUnitOfWork unitOfWork, ILogger<ClientService> logger)
        {
            _logger = logger;
            _db = unitOfWork;
        }

        #region reservations
        public async Task<Reservation> CreateResa(Reservation resa)
        {
            _db.BeginTransaction();
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();
            Reservation newResa = await _reservations.InsertAsync(resa);
            _db.Commit();

            return newResa;
        }

       

        public async Task<PageResponse<Reservation>> GetAllResa(PageRequest pageRequest)
        {
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();
            var resas = await _reservations.GetAllAsync(pageRequest);

            return resas;
        }
       

        public async Task<Reservation> GetResaById(int id)
        {
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();

            return await _reservations.GetAsync(id);
        }
       

        public async Task<Reservation> ModifyResa(Reservation resa)
        {
            _db.BeginTransaction();
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();
            try
            {
                await _reservations.UpdateAsync(resa);
                _db.Commit();
                return resa;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        public async Task<bool> RemoveResaById(int id)
        {
            _db.BeginTransaction();
            IReservationRepository _reservations = _db.GetRepository<IReservationRepository>();
            try
            {
                var count = await _reservations.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }
        #endregion


        #region Clients
        public async Task<Client> CreateClient(Client client)
        {
            _db.BeginTransaction();
            IClientRepository _clients = _db.GetRepository<IClientRepository>();
            Client newClient = await _clients.InsertAsync(client);
            _db.Commit();

            return newClient;
        }
        public async Task<PageResponse<Client>> GetAllClients(PageRequest pageRequest)
        {
            IClientRepository _clients = _db.GetRepository<IClientRepository>();

            var clients = await _clients.GetAllAsync(pageRequest);

            return clients;
        }
        public async Task<Client> GetClientById(int id)
        {

            IClientRepository _clients = _db.GetRepository<IClientRepository>();

            return await _clients.GetAsync(id);
        }
        public async Task<Client> ModifyClient(Client client)
        {
            _db.BeginTransaction();
            IClientRepository _clients = _db.GetRepository<IClientRepository>();
            try
            {
                await _clients.UpdateAsync(client);
                _db.Commit();
                return client;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return null;
            }
        }
        public async Task<bool> RemoveClientById(int id)
        {
            _db.BeginTransaction();
            IClientRepository _clients = _db.GetRepository<IClientRepository>();
            try
            {
                var count = await _clients.DeleteAsync(id);
                _db.Commit();
                return count > 0;
            }
            catch (Exception e)
            {
                _db.Rollback();
                return false;
            }
        }

       

        #endregion
    }
}
