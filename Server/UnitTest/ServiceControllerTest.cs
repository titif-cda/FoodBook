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
    public class ServiceControllerTest
    {

        [Fact]
        public async void TestGetServiceID()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            ServiceController menuController = new ServiceController(restaurantService);

            //Act
            OkObjectResult menuActionResult = await menuController.GetServiceById(1) as OkObjectResult;

            NotFoundResult notFoundMenuActionResult = await menuController.GetServiceById(10) as NotFoundResult;

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
            ServiceController menuController = new ServiceController(restaurantService);

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
            ActionResult<PageResponse<Service>> MenuActionResult = await menuController.GetAll(page1);
            ActionResult<PageResponse<Service>> actionResultV2 = await menuController.GetAll(page2);

            //Asserts
            Assert.NotNull(MenuActionResult);
            Assert.NotNull(actionResultV2);
        }

        [Fact]

        public async void TestDeleteMenu()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            ServiceController menuController = new ServiceController(restaurantService);

            //Act
            var noContentExpected = await menuController.DeleteService(1) as NoContentResult;
            var noFoundExpected = await menuController.DeleteService(10) as NotFoundResult;

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
            ServiceController menuController = new ServiceController(restaurantService);

            Service Noel = new Service()
            {
                Date = DateTime.Now,
                Midi = true,
                Id = 2,
                ListPlats = new List<Met>()
                            {
                                new Met
                                {
                                    Id = 7,
                                    Description = "DescRepas7",
                                    TypeRepas = new TypeRepas() {
                                        Id = 1,
                                        Libelle ="Entree"
                                    },
                                    Libelle = "LibelleRepas7"
                                },
                                new Met
                                {
                                    Id = 8,
                                    Description = "DescRepas8",
                                    TypeRepas = new TypeRepas() {
                                        Id = 2,
                                        Libelle ="Plat"
                                    },
                                    Libelle = "LibelleRepas8"
                                },
                                new Met
                                {
                                    Id = 9,
                                    Description = "DescRepas9",
                                    TypeRepas = new TypeRepas() {
                                        Id = 3,
                                        Libelle ="Dessert"
                                    },
                                    Libelle = "LibelleRepas9"
                                }
                            }
            };

            //Id manquant
            Service Paques = new Service()
            {
                Midi= true,
                Date = DateTime.Now.AddDays(25),
                ListPlats = new List<Met>()
                            {
                                new Met
                                {
                                    Id = 10,
                                    Description = "DescRepas10",
                                    TypeRepas = new TypeRepas() {
                                        Id = 1,
                                        Libelle ="Entree"
                                    },
                                    Libelle = "LibelleRepas10"
                                },
                                new Met
                                {
                                    Id = 11,
                                    Description = "DescRepas11",
                                    TypeRepas = new TypeRepas() {
                                        Id = 2,
                                        Libelle ="Plat"
                                    },
                                    Libelle = "LibelleRepas11"
                                },
                                new Met
                                {
                                    Id = 12,
                                    Description = "DescRepas12",
                                    TypeRepas = new TypeRepas() {
                                        Id = 3,
                                        Libelle ="Dessert"
                                    },
                                    Libelle = "LibelleRepas12"
                                }
                            }
            };
            //Act
            CreatedAtActionResult menuActionResult = await menuController.CreateService(Noel) as CreatedAtActionResult;
            BadRequestResult actionResultV2 = await menuController.CreateService(Paques) as BadRequestResult;

            //Asserts
            Assert.NotNull(menuActionResult);
            Assert.NotNull(actionResultV2);



        }

        [Fact]
        public async void TestModifyMenu()
        {
            //Arrange
            Service Rentree = new Service()
            {
                Date = DateTime.Now.AddDays(3),
                Midi = true,
                Id = 1,
                ListPlats = new List<Met>()
                            {
                                new Met
                                {
                                    Id = 10,
                                    Description = "DescRepas10",
                                    TypeRepas = new TypeRepas() {
                                        Id = 1,
                                        Libelle ="Entree"
                                    },
                                    Libelle = "LibelleRepas10"
                                },
                                new Met
                                {
                                    Id = 11,
                                    Description = "DescRepas11",
                                    TypeRepas = new TypeRepas() {
                                        Id = 2,
                                        Libelle ="Plat"
                                    },
                                    Libelle = "LibelleRepas11"
                                },
                                new Met
                                {
                                    Id = 12,
                                    Description = "DescRepas12",
                                    TypeRepas = new TypeRepas() {
                                        Id = 3,
                                        Libelle ="Dessert"
                                    },
                                    Libelle = "LibelleRepas12"
                                }
                            }
            };
            Service Covid = new Service()
            {
                Date = DateTime.Now.AddDays(25),
                //NomMenu = "Menu covid",
                Id = 198,
                Midi = true,
                ListPlats = new List<Met>()
                            {
                                new Met
                                {
                                    Id = 10,
                                    Description = "DescRepas10",
                                    TypeRepas = new TypeRepas() {
                                        Id = 1,
                                        Libelle ="Entree"
                                    },
                                    Libelle = "LibelleRepas10"
                                },
                                new Met
                                {
                                    Id = 11,
                                    Description = "DescRepas11",
                                    TypeRepas = new TypeRepas() {
                                        Id = 2,
                                        Libelle ="Plat"
                                    },
                                    Libelle = "LibelleRepas11"
                                },
                                new Met
                                {
                                    Id = 12,
                                    Description = "DescRepas12",
                                    TypeRepas = new TypeRepas() {
                                        Id = 3,
                                        Libelle ="Dessert"
                                    },
                                    Libelle = "LibelleRepas12"
                                }
                            }
            };
            IRestaurantService restaurantService = new FakeRestaurantService();
            ServiceController menuController = new ServiceController(restaurantService);



            ////Act
            OkObjectResult modifyMenu = await menuController.ModifyMenu(1, Rentree) as OkObjectResult;
            BadRequestResult badRequestResult = await menuController.ModifyMenu(15, null) as BadRequestResult;
            BadRequestResult badRequestResult1 = await menuController.ModifyMenu(5, Rentree) as BadRequestResult;
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
