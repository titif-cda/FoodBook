using BLL.Services;
using BO.DTO.Requests;
using BO.Entity;
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
        public async void RemoveMenuTest()
        {
            //arrange

            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<RestaurantService>();

            IRestaurantService _restaurantService = new RestaurantService(new FakeUnitOfWork(), logger);


            //Act

            var noContentActual = await _restaurantService.RemoveServiceById(1);
            var noFoundActual = await _restaurantService.RemoveServiceById(12);

            //Asserts
            Assert.True(noContentActual);

            Assert.True(!noFoundActual);
        }

        [Fact]
        public async void GetMenubyIdTest()
        {
            //arrange

            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<RestaurantService>();

            IRestaurantService _restaurantService = new RestaurantService(new FakeUnitOfWork(), logger);

            //Act
            var MenuActionResult = await _restaurantService.GetServiceById(1);
            var notFoundMenuActionResult = await _restaurantService.GetServiceById(10);

            //Asserts
            Assert.NotNull(MenuActionResult);
            Assert.NotNull(notFoundMenuActionResult);
        }

        [Fact]
        public async void GetMenuTest()
        {
            //arrange
            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<RestaurantService>();

            IRestaurantService _restaurantService = new RestaurantService(new FakeUnitOfWork(), logger);

            //Act
            var pageResponseMenuActual1 = await _restaurantService.GetAllService(new PageRequest());
            var pageResponseMenuActual2 = await _restaurantService.GetAllService(new PageRequest()
            {
                Page = 1,
                PageSize = 100
            });
         

           //Asserts
           Assert.NotNull(pageResponseMenuActual1);
           Assert.NotNull(pageResponseMenuActual2);
           await Assert.ThrowsAsync<NullReferenceException>(() => _restaurantService.GetAllService(null));
        }

        [Fact]
        public async void ModifyMenuTest()
        {
            //arrange
            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<RestaurantService>();

            IRestaurantService _restaurantService = new RestaurantService(new FakeUnitOfWork(), logger);

            //Act
            var modifyMenu = await _restaurantService.ModifyMenu(new Menu() { IdMenu = 1 });
            var badRequestModifyMenu = await _restaurantService.ModifyService(null);
           
            //Asserts
            Assert.NotNull(modifyMenu);
            Assert.Null(badRequestModifyMenu);
            await Assert.ThrowsAsync<NullReferenceException>(() => _restaurantService.GetAllService(null));
        }
    }
}
