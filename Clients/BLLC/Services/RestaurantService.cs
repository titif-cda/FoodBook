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
            if (ingredient?.IdIngr != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"clients/{ ingredient.IdIngr}");
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
            var reponse = await _httpClient.PutAsync($"ingredients/" + ingredient.IdIngr
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
            var reponse = await _httpClient.PutAsync($"typeRepas/" + tRepas.IdTypeRepas
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
            if (tRepas?.IdTypeRepas != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"typeRepas/{ tRepas.IdTypeRepas}");
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
     
        public async Task<Repas> CreateRepas(Repas repa)
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
                    Repas repaNew = await JsonSerializer.DeserializeAsync<Repas>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repaNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<PageResponse<Repas>> GetAllRepas(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"repas{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Repas> repasPage = await JsonSerializer.DeserializeAsync<PageResponse<Repas>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repasPage;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Repas> PutRepas(Repas repa)
        {
            var reponse = await _httpClient.PutAsync($"repas/" + repa.IdRepas
                 ,
                 new StringContent(
                     JsonSerializer.Serialize(repa), Encoding.UTF8, "application/json"
                     )
                 );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Repas repasModified = await JsonSerializer.DeserializeAsync<Repas>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return repasModified;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteRepas(Repas repa)
        {
            if (repa?.IdRepas!= null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"typeRepas/{ repa.IdRepas}");
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
        

        public async Task<Menu> CreateMenu(Menu menus)
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
                    Menu menusNew = await JsonSerializer.DeserializeAsync<Menu>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusNew;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<PageResponse<Menu>> GetAllMenu(PageRequest pageRequest)
        {
            var reponse = await _httpClient.GetAsync($"menus{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Menu> menusPage = await JsonSerializer.DeserializeAsync<PageResponse<Menu>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusPage;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Menu> PutMenu(Menu menus)
        {
            var reponse = await _httpClient.PutAsync($"menus/" + menus.IdMenu
                ,
                new StringContent(
                    JsonSerializer.Serialize(menus), Encoding.UTF8, "application/json"
                    )
                );

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    Menu menusModified = await JsonSerializer.DeserializeAsync<Menu>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return menusModified;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteMenu(Menu menus)
        {
            if(menus?.IdMenu != null)
            {
                try
                {
                    await _httpClient.DeleteAsync($"menus/{ menus.IdMenu }");
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
