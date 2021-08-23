using BO.DTO;
using BO.Entity;
using Mobile.Models;
using Mobile.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Mobile.ViewModels
{
    class ResaVM : ViewModelBase
    {
        private AuthentificationModel _authM;
        private ServiceModel _serviceM = ServiceModel.Instance;
        private ResaModel _resaM;

        public ResaVM()
        {
            _authM = AuthentificationModel.Instance;
            this.PropertyChanged += ResaVM_PropertyChanged;

            Nom = _authM.Client.Nom +" "+ _authM.Client.Prenom;
            Prenom = _authM.Client.Prenom;

            DateResa = new DateTimeOffset(_serviceM.DateMet.GetValueOrDefault());
            if (_serviceM.IsMidi)
            {
                Service = " du Midi le : " + DateResa.ToString("dd MM yyyy");
            }
            else
            {
                Service = " du Soir le : " + DateResa.ToString("dd MM yyyy");
            }

            //Service = (_serviceM.IsMidi) ? "Midi" : "Soir";
            Entree = _serviceM.Mets[0].Libelle;
            Plat = _serviceM.Mets[1].Libelle;
            Dessert = _serviceM.Mets[2].Libelle;
        }

        private void ResaVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Entree" || e.PropertyName == "Plat" || e.PropertyName == "Dessert" || e.PropertyName == "QuantiteResa")
            {
                RefreshActivateResa();
            }
        }

        private string _nom;
        public string Nom
        {
            get => _nom;
            set => Set(ref _nom, value);
        }
        private string _prenom;
        public string Prenom
        {
            get => _prenom;
            set => Set(ref _prenom, value);
        }
        private DateTimeOffset _dateResa;
        public DateTimeOffset DateResa
        {
            get => _dateResa;
            set => Set(ref _dateResa, value);
        }

        private string _service;
        public string Service
        {
            get => _service;
            set => Set(ref _service, value);
        }

        private string _entree;
        public string Entree
        {
            get => _entree;
            set => Set(ref _entree, value);
        }

        private string _plat;
        public string Plat
        {
            get => _plat;
            set => Set(ref _plat, value);
        }

        private string _dessert;
        public string Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
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
        private int _quantiteResa = 0;
        public int QuantiteResa
        {
            get => _quantiteResa;
            set => Set(ref _quantiteResa, value);
        }

        private bool _activateBtnResa = false;
        public bool ActivateBtnResa
        {
            get => _activateBtnResa;
            set => Set(ref _activateBtnResa, value);
        }

        public async Task<bool> AdBooking()
        {
            if (_serviceM.Service != null && _authM.Client != null)
            {
                if (!(IsResaPlat == false && IsResaEntree == false && IsResaDessert == false && QuantiteResa < 0))
                {
                    var resaM = new ResaModel(_serviceM.Service, _authM.Client.ConvertToClient(), DateResa.DateTime, QuantiteResa, IsResaEntree, IsResaPlat, IsResaDessert);

                    //Lancement resa
                    return await resaM.SaveResa();
                    //finResa
                }


            }
            return false;
            
        }

        private void RefreshActivateResa()
        {
            ActivateBtnResa = !(IsResaPlat == false && IsResaEntree == false && IsResaDessert == false && QuantiteResa < 0);
        }

    }
}
