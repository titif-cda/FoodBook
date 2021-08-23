using BLLC.Services;
using BO.DTO;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
    class AuthentificationModel : ModelBase
    {

        private static AuthentificationModel _instance;
        
        private static object verrou = new Object();

        public static AuthentificationModel Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(verrou)
                    {
                        if(_instance == null)
                        {
                            _instance = new AuthentificationModel();
                        }
                    }
                }

                return _instance;
            }
        }

        private AuthentificationModel() 
        {

        }

        private bool _isLogged = false;
        public bool IsLogged
        {
            get => _isLogged;
            set => Set(ref _isLogged, value);
        }

        private ProfileDto _client = null;
        public ProfileDto Client
        {
            get => _client;
            set => Set(ref _client, value);
        }

        public async Task<bool> SignIn(string login, string password)
        {
            var r = await AuthentificationService.Instance.Signin(login, password);
            IsLogged = r;


            if (IsLogged)
            {
                Client = await new ClientService().GetProfileByIdClient(AuthentificationService.Instance.GetUserId().GetValueOrDefault());
                return true;
            }

            return false;
        }
    }
}
