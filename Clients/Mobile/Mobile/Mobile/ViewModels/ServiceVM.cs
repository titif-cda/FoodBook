using Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Mobile.ViewModels
{
    internal class ServiceVM : ViewModelBase, IDisposable
    {
        private ServiceModel _serviceM = ServiceModel.Instance;
        private AuthentificationModel _auth = AuthentificationModel.Instance;
        public ServiceVM()
        {
            this.PropertyChanged += ServiceVM_PropertyChanged;
            _serviceM.Mets.CollectionChanged += Mets_CollectionChanged;

        }

        private void ServiceVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "DateMet" )
            {
                RefreshModel();
                RefreshActivateBooking();
            }
            else if(e.PropertyName == "IsMidi")
            {
                RefreshModel();
            }
        }

        private DateTimeOffset _dateMet = DateTimeOffset.Now;
        public DateTimeOffset DateMet
        {
            get => _dateMet;
            set => Set(ref _dateMet, value);
        }

        private bool _isMidi = true;
        public bool IsMidi
        {
            get => _isMidi;
            set => Set(ref _isMidi, value);
        }


        private string _entree = null;
        public string Entree
        {
            get => _entree;
            set => Set(ref _entree, value);
        }

        private string _plat = null;
        public string Plat
        {
            get => _plat;
            set => Set(ref _plat, value);
        }

        private string _dessert = null;
        public string Dessert
        {
            get => _dessert;
            set => Set(ref _dessert, value);
        }

        private bool _activateBtnBooking = false;
        
        public bool ActivateBtnBooking
        {
            get => _activateBtnBooking;
            set => Set(ref _activateBtnBooking, value);
        }

        private DateTimeOffset _dateSelected;
        public DateTimeOffset DateSelected
        {
            get => _dateSelected;
            set => Set(ref _dateSelected, value);
        }

        public bool IsLog => _auth.IsLogged;
            
        //isLogged => bool

        public bool LoadService()
        {    
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshActivateBooking()
        {
            ActivateBtnBooking = !(DateMet == DateTimeOffset.Now);
        }

        private void RefreshModel()
        {
           
            _serviceM.DateMet = DateMet.DateTime;
            _serviceM.IsMidi = IsMidi;
            _serviceM.Load();
        }

        private void Mets_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (_serviceM.Mets.Count > 2)
            {
                Entree = _serviceM.Mets[0].Libelle;
                Plat = _serviceM.Mets[1].Libelle;
                Dessert = _serviceM.Mets[2].Libelle;
            }
            else
            {
                Entree = "Aucun service";
                Plat = "Aucun service";
                Dessert = "Aucun service";
            }
        }

        public void Dispose()
        {
            this.PropertyChanged -= ServiceVM_PropertyChanged;
            _serviceM.Mets.CollectionChanged -= Mets_CollectionChanged;
        }
    }
}
