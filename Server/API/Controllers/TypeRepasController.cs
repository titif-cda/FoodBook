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
    [Route("api/v{version:apiVersion=}/typeRepas")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class TypeRepasController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IRestaurantService _restaurantService = null;

        public TypeRepasController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        /// <summary>
        /// Permet de récupérer la liste des Type Repas
        /// </summary>
        /// <returns>La liste des Type de Repas</returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<TypeRepas>>> GetAllTypeRepas([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _restaurantService.GetAllTypeRepas(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un Type de Repas avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du Type de Repas</param>
        /// <returns>Renvoi le Type de Repas définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTypeRepasById([FromRoute] int id)
        {
            TypeRepas tRepas = await _restaurantService.GetTypeRepasById(id);
            if (tRepas == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(tRepas); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un Type de Repas et l'ajoute en BDD
        /// </summary>
        /// <param name="tRepas">Type de Repas à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le Type de Repas avec l'identifiant généré</returns>
        [HttpPost()]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateTypeRepas([FromBody] TypeRepas tRepas)
        {
            // Ajout du livre avec la bll server
            TypeRepas newtRepas = await _restaurantService.CreateTypeRepas(tRepas);
            if (newtRepas != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetTypeRepasById), new { id = newtRepas.Id}, newtRepas);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Suppression du Type de Repas de la bdd selon l'identifiant
        /// </summary>
        /// <param name="id">Identifiant</param>
        /// <returns>Retourne succes ou echec</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTypeRepas([FromRoute] int id)
        {
            if (await _restaurantService.RemoveTypeRepasById(id))
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
        /// Modifie un type repas dans la bdd
        /// </summary>
        /// <param name="id">Identifiant du type repas</param>
        /// <param name="tRepas">Type repas concerné</param>
        /// <returns>Modifi un type repas ou retourne une erreur</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyTypeRepas([FromRoute] int id, [FromBody] TypeRepas tRepas)
        {
            if (tRepas == null || id != tRepas.Id)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                TypeRepas tRepasModified = await _restaurantService.ModifyTypeRepas(tRepas);
                if (tRepasModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(tRepasModified);
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