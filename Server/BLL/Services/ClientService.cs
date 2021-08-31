using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;


namespace BLL.Services
{
    class ClientService : IClientService
    {
        private readonly IUnitOfWork _db;
        private readonly ILogger<ClientService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitofwork;

        public ClientService(IUnitOfWork unitOfWork, ILogger<ClientService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _db = unitOfWork;
            _configuration = configuration;
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

        public async Task<LoginResponse> Login(string login, string password)
        {
            var clientRepository = _db.GetRepository<IClientRepository>();
            var client = await clientRepository.GetClientByUsernameAndPassword(login, password);

            if (client != null)
            {
                var loginResponse = new LoginResponse()
                {
                    Username = login,
                    AccessToken = GenerateJwtToken(client)
                };

                return loginResponse;
            }
            else
            {
                return null;
            }
        }



        private string GenerateJwtToken(Client client)
        {
            //Add User Infos
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, client.Login),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, client.Login),
            };

            //Add roles


            claims.Add(new Claim(ClaimTypes.Role, client.Role));

            claims.Add(new Claim("ClientId", client.Id.ToString()));

            //Signin Key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Expiration time
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDay"]));

            //Create JWT Token Object
            var token = new JwtSecurityToken(

                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );
            //Serializes a JwtSecurityToken into a JWT in compact Serialization Format.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

       
    }
}
