using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;
using API;
using System.Net.Http;

namespace IntegrationTest
{
    public abstract class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly WebApplicationFactory<Startup> _factory;
        protected readonly HttpClient _clientHttp;

        public IntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _clientHttp = factory.CreateClient();
        }
    }
}
