using BO.DTO;
using BO.Entity;
using Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    class ResaVM : ViewModelBase
    {
        private AuthentificationModel _authM;

        public ResaVM()
        {
            _authM = AuthentificationModel.Instance;
            this.PropertyChanged += ResaVM_PropertyChanged;
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

        private bool _service;
        public bool Service
        {
            get => _service;
            set => Set(ref _service, value);
        }

        private bool _entree;
        public bool Entree
        {
            get => _entree;
            set => Set(ref _entree, value);
        }

        private bool _plat;
        public bool Plat
        {
            get => _plat;
            set => Set(ref _plat, value);
        }

        private bool _dessert;
        public bool Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
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

        public bool AdBooking()
        {
            return true;
        }

        private void RefreshActivateResa()
        {
            ActivateBtnResa = !(Plat == false && Entree == false && Dessert == false && QuantiteResa < 0);
        }

    }
}
