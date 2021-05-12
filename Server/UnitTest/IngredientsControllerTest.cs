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

namespace UnitTest
{
    public class IngredientsControllerTest
    {
       
        [Fact]
        public async void TestGetIngredientID()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            //Act
            OkObjectResult ingredientActionResult = await ingredientController.GetIngredientById(1) as OkObjectResult;

            NotFoundResult notFoundingredientActionResult = await ingredientController.GetIngredientById(10) as NotFoundResult;

            //Assert
            Assert.NotNull(ingredientActionResult);
            Assert.Equal(200, ingredientActionResult.StatusCode);

            Assert.NotNull(notFoundingredientActionResult);
            Assert.Equal(404, notFoundingredientActionResult.StatusCode);
        }

        [Fact]

        public async void TestDeleteIngredient()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            //Act
            var noContentExpected = await ingredientController.DeleteIngredient(1) as NoContentResult;
            var noFoundExpected = await ingredientController.DeleteIngredient(10) as NotFoundResult;

            //Asserts
            Assert.NotNull(noContentExpected);
            Assert.Equal(204, noContentExpected.StatusCode);

            Assert.NotNull(noFoundExpected);
            Assert.Equal(404, noFoundExpected.StatusCode);

        }
             [Fact]
        public async void TestCreateIngredient()
        {
           
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            Ingredient sel = new Ingredient()
            {
                NomIngr = "sel",
                PrixIngr = 1
            };
            Ingredient poivre = new Ingredient()
            {
                NomIngr = "poivre",
                PrixIngr = 1
            };
            //Act
           var IngredientActionResult = await ingredientController.CreateIngredient(sel);
            var actionResultV2 = await ingredientController.CreateIngredient(poivre);

            //Asserts
            Assert.NotNull(IngredientActionResult);
            Assert.NotNull(actionResultV2);
            
            

        }
        [Fact]
        public async void TestModifyIngredient()
        {
            Ingredient sel = new Ingredient()
            {
                NomIngr = "sel",
                PrixIngr = 1
            };
            Ingredient poivre = new Ingredient()
            {
                NomIngr = "poivre",
                PrixIngr = 1
            };
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            //Act
            var IngredientActionResult = await ingredientController.ModifyIngredient(1,sel);
            var actionResultV2 = await ingredientController.ModifyIngredient(12, poivre);

            //Asserts
            Assert.NotNull(IngredientActionResult);
            Assert.NotNull(actionResultV2);

            ////Act
            //OkObjectResult createdAtActionResult = await ingredientController.ModifyIngredient(1, sel) as OkObjectResult;
            //NotFoundResult notFoundingredientActionResult = await ingredientController.ModifyIngredient(12, poivre) as NotFoundResult;

            ////Asserts
            //Assert.NotNull(createdAtActionResult);
            //Assert.Equal(201, createdAtActionResult.StatusCode);

            //Assert.NotNull(notFoundingredientActionResult);
            //Assert.Equal(400, notFoundingredientActionResult.StatusCode);


        }
        [Fact]
        public async void GetAll()
        {
            //Arrange
            IRestaurantService restaurantService = new FakeRestaurantService();
            IngredientsController ingredientController = new IngredientsController(restaurantService);

            PageRequest page1 = new PageRequest()
            {
                Page = 2,
                PageSize = 7
            };

            PageRequest page2 = new PageRequest()
            {
                Page = 9,
                PageSize = 12
            };
            //Act
            ActionResult<PageResponse<Ingredient>> IngredientActionResult = await ingredientController.GetAll(page1);
            ActionResult<PageResponse<Ingredient>> actionResultV2 = await ingredientController.GetAll(page2);
            
            //Asserts
            Assert.NotNull(IngredientActionResult);
            Assert.NotNull(actionResultV2);
           


        }
    }
}
