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
    [Route("api/v{version:apiVersion}/reservations")]
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
        /// Permet de récupérer une reservation
        /// </summary>
        /// <returns>La liste des reservations</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Reservation>>> GetAllResa([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _clientService.GetAllResa(pageRequest));
        }

        /// <summary>
        /// Permert de récupérer une reservation avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique d'une reservation</param>
        /// <returns>Renvoi une reservation définit par l'identifiant unique</returns>
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
        /// Créerune reservation et l'ajoute en BDD
        /// </summary>
        /// <param name="resa">une reservation à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi une reservation avec l'identifiant généré</returns>
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
                return CreatedAtAction(nameof(GetResaById), new { id = newResa.Id}, newResa);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Supprime une reservation de la bdd
        /// </summary>
        /// <param name="id">identifiant de la reservation</param>
        /// <returns>>Retourne succes ou echec</returns>
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

        /// <summary>
        /// Modifier une reservation dans la base de données
        /// </summary>
        /// <param name="id">Identifiant de la reservation</param>
        /// <param name="resa">reservation concernée</param>
        /// <returns>Retourne une reservation modifiée</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyResa([FromRoute] int id, [FromBody] Reservation resa)
        {
            if (resa == null || id != resa.Id)
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
