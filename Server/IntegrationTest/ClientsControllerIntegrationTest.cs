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
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{ 
    public class ClientsControllerIntegrationTest : IntegrationTest
    {
        public ClientsControllerIntegrationTest(WebApplicationFactory<Startup> factory) : base(factory) { }
        [Fact]
        public async Task GetClientsById_Should_Be_OK()
        {
           
            //Arrange
            Client expected = new Client()
            {
            
                Id = 1,
                Nom = "MATHIEU",
                Prenom = "Julien",
                Tel = "0625869845",
                Email = "j.m@yahoo.fr",
                Login = "juju"

            };
            //Act
            try
            {
                var response = await _clientHttp.GetFromJsonAsync<Client>("api/v1/clients/1");
                //Assert
                Assert.Equal(response, expected);
            }
            catch (Exception)
            {

                Assert.True(false);
            }



        }

        [Fact]
        public async Task GetClientsById_Should_Be_NotFound()
        {
            //Arrange
          
            {
                //Act

                var response = await _clientHttp.GetAsync("api/v1/clients/19999");
                //Assert
                Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

            }


        }
    }
}
