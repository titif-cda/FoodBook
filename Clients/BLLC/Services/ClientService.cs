using BLLC.Extensions;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _httpClient;
        public ClientService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
            
        }
        #region Client
        public async Task<PageResponse<Client>> GetAllClients(PageRequest pageRequest)
        {
            //  var reponse = await _httpClient.GetAsync($"books?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            var reponse = await _httpClient.GetAsync($"clients{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Client> clientPage = await JsonSerializer.DeserializeAsync<PageResponse<Client>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return clientPage;
                }
            }
            else
            {
                return null;
            }
        }



        public async Task<Client> CreateClient(Client client)
        {
            var reponse = await _httpClient.PostAsync("clients",
                new StringContent(
                    JsonSerializer.Serialize(client), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Client clientNew = await JsonSerializer.DeserializeAsync<Client>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return clientNew;
                }
            }
            else
            {
                return null;
            }
        }


        public async Task<Client> PutClient(Client client)


        {
            var reponse = await _httpClient.PutAsync($"clients/" + client.IdClient
                ,
                new StringContent(
                    JsonSerializer.Serialize(client), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Client ingredientModified = await JsonSerializer.DeserializeAsync<Client>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientModified;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteClient(Client client)
        {
            if (client?.IdClient != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"clients/{ client.IdClient}");
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
                    return false;
                }
            }
            return false;

        }
        #endregion
    }
}
