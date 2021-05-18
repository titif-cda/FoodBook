using BLL.Services;
using System;
using Xunit;
using UnitTest;
using BO.Entity;
using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using System.Collections.Generic;

namespace UnitTest
{
    public class MenusControllerTest
    {

        [Fact]
        public async void TestGetMenuID()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenusController menuController = new MenusController(restaurantService);

            //Act
            OkObjectResult menuActionResult = await menuController.GetMenuById(1) as OkObjectResult;

            NotFoundResult notFoundMenuActionResult = await menuController.GetMenuById(10) as NotFoundResult;

            //Assert

            Assert.NotNull(menuActionResult);
            Assert.Equal(200, menuActionResult.StatusCode);

            Assert.NotNull(notFoundMenuActionResult);
            Assert.Equal(404, notFoundMenuActionResult.StatusCode);
        }

        [Fact]
        public async void GetAll()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenusController menuController = new MenusController(restaurantService);

            PageRequest page1 = new PageRequest()
            {
                Page = 1,
                PageSize = 3
            };

            PageRequest page2 = new PageRequest()
            {
                Page = 9,
                PageSize = 12
            };
            //Act
            ActionResult<PageResponse<Menu>> MenuActionResult = await menuController.GetAll(page1);
            ActionResult<PageResponse<Menu>> actionResultV2 = await menuController.GetAll(page2);

            //Asserts
            Assert.NotNull(MenuActionResult);
            Assert.NotNull(actionResultV2);
        }

        [Fact]

        public async void TestDeleteMenu()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenusController menuController = new MenusController(restaurantService);

            //Act
            var noContentExpected = await menuController.DeleteMenu(1) as NoContentResult;
            var noFoundExpected = await menuController.DeleteMenu(10) as NotFoundResult;

            //Asserts
            Assert.NotNull(noContentExpected);
            Assert.Equal(204, noContentExpected.StatusCode);

            Assert.NotNull(noFoundExpected);
            Assert.Equal(404, noFoundExpected.StatusCode);

        }

        [Fact]
        public async void TestCreateMenu()
        {

            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenusController menuController = new MenusController(restaurantService);

            Menu Noel = new Menu()
            {
                DateMenu = DateTime.Now,
                NomMenu = "Menu de Noel",
                IdMenu = 4,
                ListPlats = new List<Repas>()
                            {
                                new Repas
                                {
                                    IdRepas = 7,
                                    DescRepas = "DescRepas7",
                                    IdTypeRepas = 1,
                                    LibelleRepas = "LibelleRepas7"
                                },
                                new Repas
                                {
                                    IdRepas = 8,
                                    DescRepas = "DescRepas8",
                                    IdTypeRepas = 2,
                                    LibelleRepas = "LibelleRepas8"
                                },
                                new Repas
                                {
                                    IdRepas = 9,
                                    DescRepas = "DescRepas9",
                                    IdTypeRepas = 3,
                                    LibelleRepas = "LibelleRepas9"
                                }
                            }
            };

            //Manque l'argument nom menu
            Menu Paques = new Menu()
            {
                DateMenu = DateTime.Now.AddDays(25),
                IdMenu = 5,
                ListPlats = new List<Repas>()
                            {
                                new Repas
                                {
                                    IdRepas = 10,
                                    DescRepas = "DescRepas10",
                                    IdTypeRepas = 1,
                                    LibelleRepas = "LibelleRepas10"
                                },
                                new Repas
                                {
                                    IdRepas = 11,
                                    DescRepas = "DescRepas11",
                                    IdTypeRepas = 2,
                                    LibelleRepas = "LibelleRepas11"
                                },
                                new Repas
                                {
                                    IdRepas = 12,
                                    DescRepas = "DescRepas12",
                                    IdTypeRepas = 3,
                                    LibelleRepas = "LibelleRepas12"
                                }
                            }
            };
            //Act
            CreatedAtActionResult menuActionResult = await menuController.CreateMenu(Noel) as CreatedAtActionResult;
            BadRequestResult actionResultV2 = await menuController.CreateMenu(Paques) as BadRequestResult;

            //Asserts
            Assert.NotNull(menuActionResult);
            Assert.NotNull(actionResultV2);



        }

        [Fact]
        public async void TestModifyMenu()
        {
            //Arrange
            Menu Rentree = new Menu()
            {
                DateMenu = DateTime.Now.AddDays(3),
                NomMenu = "Menu de rentrée",
                IdMenu = 5,
                ListPlats = new List<Repas>()
                            {
                                new Repas
                                {
                                    IdRepas = 10,
                                    DescRepas = "DescRepas10",
                                    IdTypeRepas = 1,
                                    LibelleRepas = "LibelleRepas10"
                                },
                                new Repas
                                {
                                    IdRepas = 11,
                                    DescRepas = "DescRepas11",
                                    IdTypeRepas = 2,
                                    LibelleRepas = "LibelleRepas11"
                                },
                                new Repas
                                {
                                    IdRepas = 12,
                                    DescRepas = "DescRepas12",
                                    IdTypeRepas = 3,
                                    LibelleRepas = "LibelleRepas12"
                                }
                            }
            };
            Menu Covid = new Menu()
            {
                DateMenu = DateTime.Now.AddDays(25),
                NomMenu = "Menu covid",
                IdMenu = 198,
                ListPlats = new List<Repas>()
                            {
                                new Repas
                                {
                                    IdRepas = 10,
                                    DescRepas = "DescRepas10",
                                    IdTypeRepas = 1,
                                    LibelleRepas = "LibelleRepas10"
                                },
                                new Repas
                                {
                                    IdRepas = 11,
                                    DescRepas = "DescRepas11",
                                    IdTypeRepas = 2,
                                    LibelleRepas = "LibelleRepas11"
                                },
                                new Repas
                                {
                                    IdRepas = 12,
                                    DescRepas = "DescRepas12",
                                    IdTypeRepas = 3,
                                    LibelleRepas = "LibelleRepas12"
                                }
                            }
            };
            IRestaurantService restaurantService = new FakeRestaurantService();
            MenusController menuController = new MenusController(restaurantService);



            ////Act
            OkObjectResult modifyMenu = await menuController.ModifyMenu(5, Rentree) as OkObjectResult;
            BadRequestResult badRequestResult = await menuController.ModifyMenu(5, null) as BadRequestResult;
            BadRequestResult badRequestResult1 = await menuController.ModifyMenu(33, Rentree) as BadRequestResult;
            NotFoundResult notFoundMenuActionResult = await menuController.ModifyMenu(198, Covid) as NotFoundResult;

            ////Asserts
            Assert.NotNull(modifyMenu);
            Assert.Equal(200, modifyMenu.StatusCode);

            Assert.NotNull(badRequestResult);
            Assert.Equal(400, badRequestResult.StatusCode);

            Assert.NotNull(badRequestResult1);
            Assert.Equal(400, badRequestResult1.StatusCode);

            Assert.NotNull(notFoundMenuActionResult);
            Assert.Equal(404, notFoundMenuActionResult.StatusCode);

        }

    }
}
