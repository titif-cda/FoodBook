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
using BLLC.Extensions;
using System.Net.Http.Json;

namespace BLLC.Services
{
    public class LibrairiService : ILibrairiService
    {
        private readonly HttpClient _httpClient;
        public LibrairiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }
      

        #region Ingredients

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
                    Console.WriteLine("An error occurred. (code:" + e.Data + ") => " + e.Message);
                    return false;
                }
            }
            return false;

        }
        public async Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest)
        {
            //  var reponse = await _httpClient.GetAsync($"books?page={pageRequest.Page}&pageSize={pageRequest.PageSize}");
            var reponse = await _httpClient.GetAsync($"ingredients{pageRequest.ToUriQuery()}");

            if (reponse.IsSuccessStatusCode)
            {
                using (var stream = await reponse.Content.ReadAsStreamAsync())
                {
                    PageResponse<Ingredient> IngredientPage = await JsonSerializer.DeserializeAsync<PageResponse<Ingredient>>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return IngredientPage;
                }
            }
            else
            {
                return null;
            }
        }



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


        public async Task<Ingredient> ModifyIngredient(Ingredient ingredient)


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
                    Ingredient IngredientModified = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return IngredientModified;
                }
            }
            else
            {
                return null;
            }
            //if (ingredient != null && ingredient.Id != null)
            //{
            //    try
            //    {
            //        var reponse = await _httpClient.PutAsJsonAsync($"ingredients/" + ingredient.Id, ingredient);
            //        using (var stream = await reponse.Content.ReadAsStreamAsync())
            //        {
            //            Ingredient ingredientModified = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            //            return ingredientModified;
            //        }
            //    }
            //    catch (HttpRequestException e)
            //    {

            //        Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
            //    }
            //    catch (NotSupportedException e)
            //    {

            //        Console.WriteLine("The Content type is not supported.");
            //    }
            //    catch (JsonException e)
            //    {

            //        Console.WriteLine("Invalid JSON.");
            //    }
            //}
            //return null;
        }

        #endregion

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
            var reponse = await _httpClient.PutAsync($"clients/" + client.Id
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

       

        //// async Task<Ingredient> ILibrairiService.PutIngredient(Ingredient ingredient)
        //{

        //    if (ingredient != null && ingredient.Id != null)
        //    {
        //        try
        //        {
        //            var reponse = await _httpClient.PutAsJsonAsync($"ingredients/" + ingredient.Id, ingredient);
        //            using (var stream = await reponse.Content.ReadAsStreamAsync())
        //            {
        //                Ingredient ingredientModified = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        //                return ingredientModified;
        //            }
        //        }
        //        catch (HttpRequestException e)
        //        {

        //            Console.WriteLine("An error occurred. (code:" + e.StatusCode.Value + ") => " + e.Message);
        //        }
        //        catch (NotSupportedException e)
        //        {

        //            Console.WriteLine("The Content type is not supported.");
        //        }
        //        catch (JsonException e)
        //        {

        //            Console.WriteLine("Invalid JSON.");
        //        }
        //    }
        //    return null;
        //}

      

        #endregion
    }


}
