using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
    class ServiceModel : ModelBase
    {
        private readonly IRestaurantService _restaurationService = new RestaurantService();

        private static ServiceModel _instance;

        private static object verrou = new Object();

        public static ServiceModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (verrou)
                    {
                        if (_instance == null)
                        {
                            _instance = new ServiceModel();
                        }
                    }
                }

                return _instance;
            }
        }

        private ServiceModel()
        {

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

        private DateTime? _dateMet;
        public DateTime? DateMet
        {
            get => _dateMet;
            set {
                Set(ref _dateMet, value);
            }
        }

        private bool _isMidi = true;
        public bool IsMidi
        {
            get => _isMidi;
            set
            {
                Set(ref _isMidi, value);
            }
        }

        

        private ObservableCollection<Met> _mets = new ObservableCollection<Met>();
        public ObservableCollection<Met> Mets
        {
            get => _mets;
            set => Set(ref _mets, value);
        }

        public async void Load()
        {
            Mets.Clear();
            Service = null;

            var service = await _restaurationService.GetServiceByDateAndService(DateMet, IsMidi);
            if(service != null)
            {
                Service = service;
                service.ListPlats.ForEach(m =>
                {
                    Mets.Add(m);
                });
            }
        }
    }
}
