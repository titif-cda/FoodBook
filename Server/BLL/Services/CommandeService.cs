using BO.DTO.Responses;
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
    class CommandeService : ICommandeService
    {
        private readonly IUnitOfWork _db;
        private readonly ILogger<RestaurantService> _logger;

        public CommandeService(IUnitOfWork unitOfWork, ILogger<RestaurantService> logger)
        {
            _logger = logger;
            _db = unitOfWork;
        }
        //private readonly IRestaurantService _restaurantService;
        //private readonly IClientService _clientService;
        //public CommandeService(IRestaurantService restaurantService, IClientService clientService)
        //{
        //    _restaurantService = restaurantService;
        //    _clientService = clientService;
        //}

        public async Task<CommandeResponse> GetCommande()
        {
            _db.BeginTransaction();
            //Récupération de l'Interface du repository Commande (ICommandeRepository)
            ICommandeRepository _commandes = _db.GetRepository<ICommandeRepository>();
            //Utilisation de sa méthode Insert
            CommandeResponse Commande = await _commandes.GetAsync();
            //Fin transaction
            _db.Commit();
            //retour de la nouvelle commande 
            return Commande;
        }

    }

}
