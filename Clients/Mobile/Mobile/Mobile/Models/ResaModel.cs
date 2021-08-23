using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
    class ResaModel : ModelBase
    {
        private readonly IClientService _clientService = new ClientService();

        public ResaModel(Service service, Client client, DateTime dateResa, int nb, bool isResaEntree, bool isResaPlat, bool isResaDessert)
        {
            Service = service;
            Client = client;
            DateResa = dateResa;
            Nb = nb;
            IsResaEntree = isResaDessert;
            IsResaPlat = isResaPlat;
            IsResaDessert = isResaDessert;
        }

        private Service _service;
        public Service Service
        {
            get => _service;
            set
            {
                Set(ref _service, value);
            }
        }

        private Client _client;
        public Client Client
        {
            get => _client;
            set
            {
                Set(ref _client, value);
            }
        }

        private DateTime? _dateResa = DateTime.Now;
        public DateTime? DateResa
        {
            get => _dateResa;
            set
            {
                Set(ref _dateResa, value);
            }
        }

        private int? _nb;
        public int? Nb
        {
            get => _nb;
            set
            {
                Set(ref _nb, value);
            }
        }

        private bool _isResaEntree;
        public bool IsResaEntree
        {
            get => _isResaEntree;
            set => Set(ref _isResaEntree, value);
        }

        private bool _isResaPlat;
        public bool IsResaPlat
        {
            get => _isResaPlat;
            set => Set(ref _isResaPlat, value);
        }

        private bool _isResaDessert;
        public bool IsResaDessert
        {
            get => _isResaDessert;
            set => Set(ref _isResaDessert, value);
        }

        public async Task<bool> SaveResa()
        {
            if(DateResa.HasValue && !(IsResaPlat == false && IsResaEntree == false && IsResaDessert == false) && Nb > 0)
            {
                var resa = await _clientService.CreateReservations(new Reservation(null, _client, _service, _dateResa.GetValueOrDefault(), _nb, IsResaEntree, IsResaPlat, IsResaDessert));
                if(resa != null)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
