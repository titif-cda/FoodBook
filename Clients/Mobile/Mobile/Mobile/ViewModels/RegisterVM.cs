using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    internal class RegisterVM : ViewModelBase
    {
        public RegisterVM()
        {
            this.PropertyChanged += RegisterVM_PropertyChanged;
        }

        private void RegisterVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Nom" || e.PropertyName == "Prenom" || e.PropertyName == "Email" || e.PropertyName == "Telephone" || e.PropertyName == "Login"
                || e.PropertyName == "Password" || e.PropertyName == "Password2")
            {
                RefreshActivateRegister();
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
        private string _email;
        public string Email
        {
            get => _email;
            set => Set(ref _email, value);
        }
        private string _telephone;
        public string Telephone
        {
            get => _telephone;
            set => Set(ref _telephone, value);
        }
        private string _login;
        public string Login
        {
            get => _login;
            set => Set(ref _login, value);
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => Set(ref _password, value);
        }
        private string _password2;
        public string Password2
        {
            get => _password2;
            set => Set(ref _password2, value);
        }
        private bool _activateBtnRegister = false;
        public bool ActivateBtnRegister
        {
            get => _activateBtnRegister;
            set => Set(ref _activateBtnRegister, value);
        }
        public bool Register()
        {
            return true;
        }

        private void RefreshActivateRegister()
        {
            ActivateBtnRegister = !(string.IsNullOrEmpty(Nom) || string.IsNullOrEmpty(Prenom) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Telephone)
                || string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Password2));
        }

    }
}
