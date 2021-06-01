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
    /// <summary>
    /// Description de la class
    /// </summary>

    //Annotations ou Decorateurs et declaration du controlleur pour l'entité client
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion=}/clients")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    
    public class ClientsController : ControllerBase
        
        {

        //Service qui gère le controlleur 
        private readonly IClientService _clientService = null;

        /// <summary>
        /// Constructeur du service ClientController
        /// </summary>
        /// <param name="clientService"></param>
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            LoginResponse loginResponse = await _clientService.Login(loginRequest.Username, loginRequest.Password);
            if (loginResponse != null)
            {
                return Ok(loginResponse);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            Client registerResponse = await _clientService.Register(registerRequest);
            if (registerResponse != null)
            {
                return Ok(registerResponse);
            }
            else
            {
                return BadRequest();
            }
        }



        /// <summary>
        /// Permet de récupérer la liste des clients
        /// </summary>
        /// <returns>La liste des clients</returns>
        [HttpGet]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PageResponse<Client>>> GetAll([FromQuery] PageRequest pageRequest)
        {

            return Ok(await _clientService.GetAllClients(pageRequest));
        }

        /// <summary>
        /// Permet de récupérer un client avec son identifiant unique
        /// </summary>
        /// <param name="id">Identifiant unique du clients</param>
        /// <returns>Renvoi le client définit par l'identifiant unique</returns>
        [HttpGet("{id}")]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetClientById([FromRoute] int id)
        {
            Client client = await _clientService.GetClientById(id);
            if (client == null)
            {
                return NotFound(); // StatusCode = 404
            }
            else
            {
                return Ok(client); // StatusCode = 200
            }
        }


        /// <summary>
        /// Créer un clients et l'ajoute en BDD
        /// </summary>
        /// <param name="book">clients à ajouter sans l'identifiant unique</param>
        /// <returns>Renvoi le clients avec l'identifiant généré</returns>
        [HttpPost()]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateClient([FromBody] Client client)
        {
            // Ajout du client avec la bll server
            Client newClient = await _clientService.CreateClient(client);
            if (newClient != null)
            {
                // Créer une redirection vers GetClientById(newBook.BookId);
                return CreatedAtAction(nameof(GetClientById), new { id = newClient.Id }, newClient);
            }
            else
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
        }

        /// <summary>
        /// Permet de supprimer un Client par le biais de son Identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrateur")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteClient([FromRoute] int id)
        {
            if (await _clientService.RemoveClientById(id))
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
        /// Permet de modifier un client grâce à son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Restaurateur")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ModifyClient([FromRoute] int id, [FromBody] Client client)
        {
            if (client == null || id != client.Id)
            {
                // Retourne un code 400  Bad Request
                return BadRequest();
            }
            else
            {
                Client clientModified = await _clientService.ModifyClient(client);
                if (clientModified != null)
                {
                    // Renvoie la ressource modifiée
                    return Ok(clientModified);
                }
                else
                {
                    // Renvoie un code 404: la ressource est introuvable
                    return NotFound();
                }
            }
        }


        //[HttpPut("{id/infos}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<IActionResult> getBookInfo([FromRoute] int id)
        //{
        //    Client newClient = await _clientService.GetClientById(id);
        //    if (newClient == null)
        //    {
        //        Retourne un code 400  Bad Request
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(newClient);
        //        Renvoie la ressource modifiée

        //    }
        //}
    }
    
}