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
    public class RestaurantService : IRestaurantService
    {
        private readonly HttpClient _httpClient;
        public RestaurantService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");

        }
        #region Ingredient
        public async Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            var reponse = await _httpClient.PostAsync("clients",
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
                    await _httpClient.DeleteAsync($"clients/{ ingredient.Id}");
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

       
        public async Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
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
                    Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
                    return false;
                }
            }
            return false;
        }



        #endregion

        #region Repas
     
        public async Task<Met> CreateRepas(Met repa)
        {
            var reponse = await _httpClient.PostAsync("repas",
                   new StringContent(
                       JsonSerializer.Serialize(repa), Encoding.UTF8, "application/json"
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

        public async Task<PageResponse<Met>> GetAllRepas(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"repas{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Met> repasPage = await JsonSerializer.DeserializeAsync<PageResponse<Met>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repasPage;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Met> PutRepas(Met repa)
        {
            var reponse = await _httpClient.PutAsync($"repas/" + repa.Id
                 ,
                 new StringContent(
                     JsonSerializer.Serialize(repa), Encoding.UTF8, "application/json"
                     )
                 );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Met repasModified = await JsonSerializer.DeserializeAsync<Met>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repasModified;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteRepas(Met repa)
        {
            if (repa?.Id!= null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"typeRepas/{ repa.Id}");
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

        #region Menu
        

        public async Task<Service> CreateMenu(Service menus)
        {
            var reponse = await _httpClient.PostAsync("menus",
                   new StringContent(
                       JsonSerializer.Serialize(menus), Encoding.UTF8, "application/json"
                       )
                   );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Service menusNew = await JsonSerializer.DeserializeAsync<Service>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<PageResponse<Service>> GetAllMenu(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"menus{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Service> menusPage = await JsonSerializer.DeserializeAsync<PageResponse<Service>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusPage;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Service> PutMenu(Service menus)
        {
            var reponse = await _httpClient.PutAsync($"menus/" + menus.Id
                ,
                new StringContent(
                    JsonSerializer.Serialize(menus), Encoding.UTF8, "application/json"
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

        public async Task<bool> DeleteMenu(Service menus)
        {
            if(menus?.Id != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"menus/{ menus.Id }");
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
