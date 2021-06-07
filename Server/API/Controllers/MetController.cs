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
    [Route("api/v{version:apiVersion}/mets")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [Authorize(Roles = "Administrateur")]
    public class MetController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IRestaurantService _restaurantService = null;

        public MetController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des Mets
        /// </summary>
        /// <returns>La liste des met</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Met>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllMet(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un met avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du met</param>
        /// <returns>Renvoi le met définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMetById([FromRoute] int id)
        {
            Met met = await _restaurantService.GetMetById(id);
            if (met == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(met); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un Met et l'ajoute en BDD
        /// </summary>
        /// <param name="Met">Met à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi un Met avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRepas([FromBody] Met met)
        {
            // Ajout du client avec la bll server
            Met newMet = await _restaurantService.CreateMet(met);
            if (newMet != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetMetById), new { id = newMet.Id }, newMet);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprime un met de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns>>Retourne succes ou echec</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMet([FromRoute] int id)
        {
            if (await _restaurantService.RemoveMetById(id))
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
        /// modifie le met dans la base de données
        /// </summary>
        /// <param name="id"></param>
        /// <param name="met"></param>
        /// <returns>Un met modifié ou echec</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyRepas([FromRoute] int id, [FromBody] Met met)
        {
            if (met == null || id != met.Id)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Met repasModified = await _restaurantService.ModifyMet(met);
                if (repasModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(repasModified);
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