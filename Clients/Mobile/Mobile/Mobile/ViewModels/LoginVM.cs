using Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    internal class LoginVM : ViewModelBase
    {
        private AuthentificationModel _authM;

        public LoginVM()
        {
            _authM = AuthentificationModel.Instance;
            this.PropertyChanged += LoginVM_PropertyChanged;
        }

        private void LoginVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Password" || e.PropertyName == "Login")
            {
                RefreshActivateSignIn();
            }
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

        private bool _activateBtnSignIn = false;
        public bool ActivateBtnSignIn
        {
            get => _activateBtnSignIn;
            set => Set(ref _activateBtnSignIn, value);
        }

        public async Task<bool> SignIn()
        {
            var r = await _authM.SignIn(Login, Password);
            if(!r)
            {
                Password = "";
                Login = "";
            }
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshActivateSignIn()
        {
            ActivateBtnSignIn = !(string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Login));
        }

    }
}
