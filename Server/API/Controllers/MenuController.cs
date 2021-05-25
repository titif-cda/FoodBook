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
        /// Permet de récupérer la liste des menus
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Menu>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllService(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un menus avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du menus</param>
        /// <returns>Renvoi le menus définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMenuById([FromRoute] int id)
        {
            Menu menus = await _restaurantService.GetServiceById(id);
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
        /// Créer un menus et l'ajoute en BDD
        /// </summary>
        /// <param name="menus">menus à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le menus avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateMenu([FromBody] Menu menus)
        {
            // Ajout du menus avec la bll server
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

        /// <summary>
        /// Supprime un menus de la bdd
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <returns>succes ou echec</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMenu([FromRoute] int id)
        {
            if (await _restaurantService.RemoveServiceById(id))
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
        /// modifie un menus dans la bdd
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <param name="menus">Menu concerné</param>
        /// <returns></returns>
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