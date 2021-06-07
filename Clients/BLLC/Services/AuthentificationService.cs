using BLL.Services;
using BLLC.Extensions;
using BO.DTO.Requests;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLLC.Services
{

    public class AuthentificationService
    {
        private static AuthentificationService instance;
        private static object verrou = new object();

        //properties instances
        public bool isLogged { get; private set; }
        public string Token { get; private set; }

        //Constructeur privé personne ne peut construire cet objet
        private AuthentificationService()
        {
        }



        //Pour pouvoir recuperer l'instance
        public static AuthentificationService Instance
        {
            get { 
                if (instance == null)
                {
                    lock (verrou)
                    {
                        //Si l'instance n'existe pas dans l'application
                        if (instance == null)
                        {
                            instance = new AuthentificationService();
                        }
                    
                    }
                }
            
            //retourne l'instance du singleton
            return instance;
            }
        }



        public async Task<bool> Signin(string login, string password)
        {
           var _httpClient = new HttpClient();
            var loginRequest = new LoginRequest() 
                { 
                Login = login,
                Password = password
                };


            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/v1/");
            try
            {
                var httpResponse = await _httpClient.PostAsJsonAsync("clients/login", loginRequest);
                if (httpResponse.IsSuccessStatusCode)
                {
                    var loginReponse = httpResponse.Content.ReadFromJsonAsync<LoginResponse>();
                    isLogged = true;
                    Token = (await loginReponse).AccessToken;

                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

           
        }


        public HttpClient httpClient { get
            {
                var _httpClient = new HttpClient();
                _httpClient.BaseAddress = new Uri("https://localhost:5001/api/v1/");
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {AuthentificationService.Instance.Token}");
            
                return _httpClient;
            } 
        }


        private string GetValueClaimToken(string type)
        {
            var readerHandler = new JwtSecurityTokenHandler();
            var decodedToken = readerHandler.ReadJwtToken(Token);
            return decodedToken.Claims.ToList().Find(c => c.Type == type)?.Value;    
        }

         /// <summary>
         /// Methode qui recupère le rôle de l'utilisateur
         /// </summary>
         /// <returns></returns>
        public string GetRoleUser()
        {
            return GetValueClaimToken(ClaimTypes.Role);
        }

        /// <summary>
        /// Methode qui recupere l'ID du Token
        /// </summary>
        /// <returns></returns>
        public int? GetUserId()
        {
            return GetValueClaimToken("ClientId").ToNullable<int>();
        }
    }
}
