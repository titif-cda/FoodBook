using API;
using BO;
using BO.Entity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{
    public class IngredientsControllerIntegrationTest : IntegrationTest
    {
        public IngredientsControllerIntegrationTest(WebApplicationFactory<Startup> factory) : base(factory) { }

        [Fact]
        public async Task AddIngredient_Should_Be_Ok()
        {
            Ingredient newIngredient = new Ingredient()
            {
               
                NomIngr = "oeufs",
                PrixIngr = 1.3f
            };
            var response = await _clientHttp.PostAsJsonAsync<Ingredient>("api/v1/ingredients", newIngredient);
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var actualAddedIngredient = await JsonSerializer.DeserializeAsync<Ingredient>(stream, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                Assert.NotNull(actualAddedIngredient);
                Assert.NotNull(actualAddedIngredient.IdIngr);
                Assert.Equal(newIngredient.NomIngr, actualAddedIngredient.NomIngr);
                Assert.Equal(newIngredient.PrixIngr, actualAddedIngredient.PrixIngr);
            }

        }
    }
}
