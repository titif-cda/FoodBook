using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class CommandeService : ICommandeService
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IClientService _clientService;
        public CommandeService(IRestaurantService restaurantService, IClientService clientService)
        {
            _restaurantService = restaurantService;
            _clientService = clientService;
        }
    }

}
