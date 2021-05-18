using BO.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using BO.DTO.Requests;
using BO.DTO.Responses;

namespace API.Controllers
    //Todo Demander a Fabien commentaires  l 34

{   /// <summary>
    /// Decorateurs et declaration du controlleur pour l'entité Ingrédients
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}ingredients")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class IngredientsController : ControllerBase

    {

        //Service qui gère le restaurant service
        private readonly IRestaurantService _restaurantService = null;
        /// <summary>
        /// Instanciation du controleur
        /// </summary>
        /// <param name="restaurantService">Service en parametre</param>
        public IngredientsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des ingredients
        /// </summary>
        /// <returns>La liste des ingredients</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Ingredient>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllIngredients(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un ingredient avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique de l'ingredient</param>
        /// <returns>Renvoi l'ingredient définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetIngredientById([FromRoute] int id)
        {
            Ingredient ingredient = await _restaurantService.GetIngredientById(id);
            if (ingredient == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(ingredient); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un ingredient et l'ajoute en BDD
        /// </summary>
        /// <param name="ingredient">ingredient à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi l'ingredient avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIngredient([FromBody] Ingredient ingredient)
        {
            // Ajout du ingredient avec la bll server
            Ingredient newIngredient = await _restaurantService.CreateIngredient(ingredient);
            if (newIngredient != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetIngredientById), new { id = newIngredient.IdIngr }, newIngredient);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprimer un ingredient de la base de données
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns>Retourne succes ou echec</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
        {
            if (await _restaurantService.RemoveIngredientById(id))
            {

                // Renvoie un code 204 aucun contenu
                return NoContent();
            }
            else
            {
                // Renvoie un code 404: la ressource est introuvable
                return NotFound();
            }
        }

        /// <summary>
        /// Modifie un ingredient dans la base de données
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <param name="ingredient">Ingredient</param>
        /// <returns>Retourne un ingredient modifié</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyIngredient([FromRoute] int id, [FromBody] Ingredient ingredient)
        {
            if (ingredient == null || id != ingredient.IdIngr)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Ingredient ingredientModified = await _restaurantService.ModifyIngredient(ingredient);
                if (ingredientModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(ingredientModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }
    }

}