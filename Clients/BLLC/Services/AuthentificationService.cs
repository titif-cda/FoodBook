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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLLC.Services
{

    public class AuthentificationService
    {

#if DEBUG
        private Uri BaseAddress = new Uri("https://localhost:5001/api/v1/");
#else
        private Uri BaseAddress = new Uri("http://user06.2isa.org/api/v1/");
#endif

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
            get
            {
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

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public async Task<bool> Signin(string login, string password)
        {
            var mdpHash = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                mdpHash = GetHash(sha256Hash, password);
            }


            var handler = new HttpClientHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
            };
            handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => true;
            var _httpClient = new HttpClient(handler);

            var loginRequest = new LoginRequest()
            {
                Login = login,
                Password = mdpHash
            };

            _httpClient.BaseAddress = BaseAddress;

           
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


        public HttpClient httpClient
        {
            get
            {
                var handler = new HttpClientHandler()
                {
                    ClientCertificateOptions = ClientCertificateOption.Manual,
                };
                handler.ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => true;
                  
                var _httpClient = new HttpClient(handler);

                _httpClient.BaseAddress = BaseAddress;
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
