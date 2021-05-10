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
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}/menus")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class MenusController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IRestaurantService _restaurantService = null;

        public MenusController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des livres
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Menu>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllMenu(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un livre avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du livre</param>
        /// <returns>Renvoi le livre définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMenuById([FromRoute] int id)
        {
            Menu menus = await _restaurantService.GetMenuById(id);
            if (menus == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(menus); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un livre et l'ajoute en BDD
        /// </summary>
        /// <param name="ingredient">Livre à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le livre avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRepas([FromBody] Menu menus)
        {
            // Ajout du client avec la bll server
            Menu newmenus = await _restaurantService.CreateMenu(menus);
            if (newmenus != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetMenuById), new { id = newmenus.IdMenu}, menus);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMenu([FromRoute] int id)
        {
            if (await _restaurantService.RemoveMenuById(id))
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


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyMenu([FromRoute] int id, [FromBody] Menu menus)
        {
            if (menus == null || id != menus.IdMenu)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Menu menusModified = await _restaurantService.ModifyMenu(menus);
                if (menusModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(menusModified);
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