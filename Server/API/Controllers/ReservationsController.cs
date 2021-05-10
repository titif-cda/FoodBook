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
    [Route("api/v{version:apiVersion=}/reservations")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class ReservationsController : ControllerBase
    {

        //Service qui gère la librairi
        private readonly IClientService _clientService = null;

        public ReservationsController(IClientService clientService)
        {
            _clientService = clientService;
        }


        /// <summary>
        /// Permet de récupérer la liste des livres
        /// </summary>
        /// <returns>La liste des livres</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Reservation>>> GetAllResa([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _clientService.GetAllResa(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer un livre avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du livre</param>
        /// <returns>Renvoi le livre définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetResaById([FromRoute] int id)
        {
            Reservation resa = await _clientService.GetResaById(id);
            if (resa == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(resa); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un livre et l'ajoute en BDD
        /// </summary>
        /// <param name="resa">Livre à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le livre avec l'identifiant généré</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateResa([FromBody] Reservation resa)
        {
            // Ajout du livre avec la bll server
            Reservation newResa = await _clientService.CreateResa(resa);
            if (newResa != null)
            {
                // Créer une redirection vers GetBookById(newBook.BookId);
                return CreatedAtAction(nameof(GetResaById), new { id = newResa.IdResa}, newResa);
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
        public async Task<IActionResult> DeleteResa([FromRoute] int id)
        {
            if (await _clientService.RemoveResaById(id))
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
        public async Task<IActionResult> ModifyResa([FromRoute] int id, [FromBody] Reservation resa)
        {
            if (resa == null || id != resa.IdResa)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Reservation resaModified = await _clientService.ModifyResa(resa);
                if (resaModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(resaModified);
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
