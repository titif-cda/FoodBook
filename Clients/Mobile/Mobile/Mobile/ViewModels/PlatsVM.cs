using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Mobile.ViewModels
{
    internal class PlatsVM : ViewModelBase
    {
        public PlatsVM()
        {
            this.PropertyChanged += PlatsVM_PropertyChanged;
        }

        private void PlatsVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "DateMet" )
            {
                RefreshActivateBooking();
            }
        }

        private DateTimeOffset? _dateMet;
        public DateTimeOffset? DateMet
        {
            get => _dateMet;
            set => Set(ref _dateMet, value);
        }

        private bool _midi = true;
        public bool Midi
        {
            get => _midi;
            set => Set(ref _midi, value);
        }

        private bool _soir = false;
        public bool Soir
        {
            get => _soir;
            set => Set(ref _soir, value);
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

        private bool _activateBtnBooking = false;
        
        public bool ActivateBtnBooking
        {
            get => _activateBtnBooking;
            set => Set(ref _activateBtnBooking, value);
        }

        public bool Booking()
        {
            
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshActivateBooking()
        {
            ActivateBtnBooking = !(DateMet == null);
        }
    }
}
