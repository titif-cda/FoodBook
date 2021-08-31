using BLLC.Extensions;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public class RestaurantService : IRestaurantService
    {

        private readonly HttpClient _httpClient = AuthentificationService.Instance.httpClient;

        public RestaurantService()
        {
        }

        #region Ingredient
        public async Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            var reponse = await _httpClient.PostAsync("ingredients",
                new StringContent(
                    JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Ingredient ingredientNew = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientNew;
                }
            }
            else
            {
                return null;
            }
        }

       

        public async Task<bool> DeleteIngredient(Ingredient ingredient)
        {
            if (ingredient?.Id != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"ingredients/{ ingredient.Id}");
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("An error occurred" + e.Message);
                    return false;
                }
            }
            return false;

        }

       
        public async Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
        {
            if (AuthentificationService.Instance.isLogged)
            {                    
                var reponse = await _httpClient.GetAsync($"ingredients{pageRequest.ToUriQuery()}");

                if (reponse.IsSuccessStatusCode)
                {
                    using (var stream = await reponse.Content.ReadAsStreamAsync())
                    {
                        PageResponse<Ingredient> ingredientPage = await JsonSerializer.DeserializeAsync<PageResponse<Ingredient>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                        return ingredientPage;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

      

        public async Task<Ingredient> PutIngredient(Ingredient ingredient)
        {
            var reponse = await _httpClient.PutAsync($"ingredients/" + ingredient.Id
                ,
                new StringContent(
                    JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Ingredient ingredientModified = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return ingredientModified;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region TypeRepas
        public async Task<TypeRepas> CreateTypeRepas(TypeRepas tRepas)
        {
            var reponse = await _httpClient.PostAsync("typeRepas",
                  new StringContent(
                      JsonSerializer.Serialize(tRepas), Encoding.UTF8, "application/json"
                      )
                  );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    TypeRepas tRepasNew = await JsonSerializer.DeserializeAsync<TypeRepas>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return tRepasNew;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<PageResponse<TypeRepas>> GetAllTypeRepas(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"typeRepas{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<TypeRepas> tRepasPage = await JsonSerializer.DeserializeAsync<PageResponse<TypeRepas>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return tRepasPage;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<TypeRepas> PutTypeRepas(TypeRepas tRepas)
        {
            var reponse = await _httpClient.PutAsync($"typeRepas/" + tRepas.Id
                 ,
                 new StringContent(
                     JsonSerializer.Serialize(tRepas), Encoding.UTF8, "application/json"
                     )
                 );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    TypeRepas tRepasModified = await JsonSerializer.DeserializeAsync<TypeRepas>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return tRepasModified;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> DeleteTypeRepas(TypeRepas tRepas)
        {
            if (tRepas?.Id != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"typeRepas/{ tRepas.Id}");
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("An error occurred " + e.Message);
                    return false;
                }
            }
            return false;
        }



        #endregion

        #region Mets
     
        public async Task<Met> CreateMet(Met met)
        {
            var reponse = await _httpClient.PostAsync("mets",
                   new StringContent(
                       JsonSerializer.Serialize(met), Encoding.UTF8, "application/json"
                       )
                   );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Met repaNew = await JsonSerializer.DeserializeAsync<Met>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repaNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<PageResponse<Met>> GetAllMet(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"mets{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Met> metPage = await JsonSerializer.DeserializeAsync<PageResponse<Met>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return metPage;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<Met> GetDetailsMet(int idMet)
        {
            var reponse = await _httpClient.GetAsync($"mets/{idMet}/all");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Met met= await JsonSerializer.DeserializeAsync<Met>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return met;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<Met> PutMet(Met met)
        {
            var reponse = await _httpClient.PutAsync($"mets/" + met.Id
                 ,
                 new StringContent(
                     JsonSerializer.Serialize(met), Encoding.UTF8, "application/json"
                     )
                 );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Met metModified = await JsonSerializer.DeserializeAsync<Met>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return metModified;
                }
            }
            else
            {
                return null;
            }
        }
      
        public async Task<bool> DeleteMet(Met repa)
        {
            if (repa?.Id!= null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"mets/{ repa.Id}");
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("An error occurred " + e.Message);
                    return false;
                }
            }
            return false;
        }


        #endregion

        #region Service
        

        public async Task<Service> CreateService(Service service)
        {
            var reponse = await _httpClient.PostAsync("services",
                   new StringContent(
                       JsonSerializer.Serialize(service), Encoding.UTF8, "application/json"
                       )
                   );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Service servicesNew = await JsonSerializer.DeserializeAsync<Service>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return servicesNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<PageResponse<Service>> GetAllService(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"services{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Service> servicesPage = await JsonSerializer.DeserializeAsync<PageResponse<Service>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return servicesPage;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Service> GetDetailsService(int id)
        {
            var reponse = await _httpClient.GetAsync($"services/all/{id}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Service service = await JsonSerializer.DeserializeAsync<Service>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return service;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Service> GetServiceByDateAndService(DateTime? date, bool midi)
        {
            var reponse = await _httpClient.GetAsync($"services/filter?date={date.GetValueOrDefault().ToString("d", CultureInfo.InvariantCulture)}&midi={midi.ToString()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Service service = await JsonSerializer.DeserializeAsync<Service>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return service;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Service> PutService(Service service)
        {
            var reponse = await _httpClient.PutAsync($"services/" + service.Id
                ,
                new StringContent(
                    JsonSerializer.Serialize(service), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Service menusModified = await JsonSerializer.DeserializeAsync<Service>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusModified;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteService(Service service)
        {
            if(service?.Id != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"services/{ service.Id }");
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("An error occurred " + e.Message);
                    return false;
                }
            }
            return false;
        }

       
        #endregion
    }
}
