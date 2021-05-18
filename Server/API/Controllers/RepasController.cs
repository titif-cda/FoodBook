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
    [Route("apiv{version:apiVersion=}/repas")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class RepasController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IRestaurantService _restaurantService = null;

        public RepasController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des repas
        /// </summary>
        /// <returns>La liste des repas</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Repas>>> GetAll([FromQuery] PageRequest pageRequest,Filter filter)
        {

            return Ok(await _restaurantService.GetAllRepas(pageRequest, filter));
        }

        /// <summary>
        /// Permert de récupérer un repas avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du repas</param>
        /// <returns>Renvoi le repas définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRepasById([FromRoute] int id)
        {
            Repas repas = await _restaurantService.GetRepasById(id);
            if (repas == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(repas); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un repas et l'ajoute en BDD
        /// </summary>
        /// <param name="repas">repas à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi un repas avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRepas([FromBody] Repas repas)
        {
            // Ajout du client avec la bll server
            Repas newrepas = await _restaurantService.CreateRepas(repas);
            if (newrepas != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetRepasById), new { id = newrepas.IdRepas }, newrepas);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprime un repas de la BDD
        /// </summary>
        /// <param name="id"></param>
        /// <returns>>Retourne succes ou echec</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRepas([FromRoute] int id)
        {
            if (await _restaurantService.RemoveRepasById(id))
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
        /// modifie le repas dans la base de données
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repas"></param>
        /// <returns>Un repas modifié ou echec</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyRepas([FromRoute] int id, [FromBody] Repas repas)
        {
            if (repas == null || id != repas.IdRepas)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Repas repasModified = await _restaurantService.ModifyRepas(repas);
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