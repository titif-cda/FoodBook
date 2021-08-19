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
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}/services")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ServiceController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IRestaurantService _restaurantService = null;

        public ServiceController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des menus
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Service>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllService(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un service avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du service</param>
        /// <returns>Renvoi le service définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServiceById([FromRoute] int id)
        {
            Service service = await _restaurantService.GetServiceById(id);
            if (service == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(service); // StatusCode = 200
            }
        }

        [HttpGet("all/{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMetForServiceAsync([FromRoute] int id)
        {
            Service service = await _restaurantService.GetMetForServiceAsync(id);
            if (service == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(service); // StatusCode = 200
            }
        }

        [HttpGet("filter")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServiceByDate([FromQuery] DateTime date, [FromQuery] bool midi)
        {
            var service = await _restaurantService.GetServiceByDateAndService(date,midi);
            if (service == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(service); // StatusCode = 200
            }
        }

        /// <summary>
        /// Créer un service et l'ajoute en BDD
        /// </summary>
        /// <param name="service">service à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le service avec l'identifiant généré</returns>
        [HttpPost()]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateService([FromBody] Service service)
        {
            // Ajout du menus avec la bll server
            Service newService = await _restaurantService.CreateService(service);
            if (newService != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetServiceById), new { id = newService.Id}, service);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprime un service de la bdd
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <returns>succes ou echec</returns>
        [HttpDelete("{id}")]
        [AllowAnonymous]
        //[Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteService([FromRoute] int id)
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
        /// modifie un service dans la bdd
        /// </summary>
        /// <param name="id">identifiant</param>
        /// <param name="service">service concerné</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [AllowAnonymous]
        //[Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyMenu([FromRoute] int id, [FromBody] Service service)
        {
            if (service == null || id != service.Id)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Service serviceModified = await _restaurantService.ModifyAllService(service);
                if (serviceModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(serviceModified);
                }
                else
                {
                    // Renvoie un code 404: le service est introuvable
                    return NotFound();
                }
            }
        }
    }
}