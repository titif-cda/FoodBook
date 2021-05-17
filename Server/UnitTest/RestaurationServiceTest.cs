using BLL.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Services;
using Xunit;

namespace UnitTest
{
    public class RestaurationServiceTest
    {

        [Fact]
        public void Test()
        {
            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<RestaurantService>();
            
            IRestaurantService _restaurantServcie = new RestaurantService(new FakeUnitOfWork(), logger);

            _restaurantServcie.ModifyIngredient()
        }
    }
}
