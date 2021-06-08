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
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    // <summary>
    /// Liste des Ingredients pour un plat: Table de liaison
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}/metsIngredients")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]

    public class MetsIngredientsControlleur : ControllerBase
    {
        //Service qui gère le controlleur 
        private readonly IRestaurantService _restaurantService = null;

        /// <summary>
        /// Constructeur du service MetsIngredientsControlleur
        /// </summary>
        /// <param name="restaurantService"></param>
        public MetsIngredientsControlleur(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        /// <summary>
        /// Permet de récupérer la liste des ingredients liés aux plats
        /// </summary>
        /// <returns>La liste des ingredients</returns>
        [HttpGet]

        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<MetsIngredients>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllListeIngredients(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer une liste des ingredients liés aux plats  son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique de la liste des ingredients</param>
        /// <returns>Renvoi l'ingredient définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetListeIngredientById([FromRoute] int id)
        {
            MetsIngredients metsIngredients = await _restaurantService.GetAllListeIngredientsById(id);
            if (metsIngredients == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(metsIngredients); // StatusCode = 200
            }
        }

        /// <summary>
        /// Créer une liste des ingredients liés aux plats et l'ajoute en BDD
        /// </summary>
        /// <param name="listeIngredient">ingredient à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi l'ingredient avec l'identifiant généré</returns>
        [HttpPost()]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIngredient([FromBody] MetsIngredients listeIngredient)
        {

            // Ajout du ingredient avec la bll server
            MetsIngredients newListeIngredient = await _restaurantService.CreateListeIngredients(listeIngredient);
            if (newListeIngredient != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return Ok(await _restaurantService.CreateListeIngredients(listeIngredient));
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprimer une liste des ingredients liés aux plats de la base de données
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns>Retourne succes ou echec</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteListeIngredients([FromRoute] int id)
        {
            if (await _restaurantService.RemovAllListeIngredientsById(id))
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
        /// Modifie une liste des ingredients liés aux platst dans la base de données
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <param name="ingredient">Ingredient</param>
        /// <returns>une liste des ingredients modifié</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Restaurateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyListeIngredients([FromRoute] int id, [FromBody] MetsIngredients listeIngredient)
        {
            if (listeIngredient == null)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                MetsIngredients listeIngredientngredientModified = await _restaurantService.ModifyAllListeIngredients(listeIngredient);
                if (listeIngredientngredientModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(listeIngredientngredientModified);
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
