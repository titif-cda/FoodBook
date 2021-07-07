using BLL.Services;
using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BO.DTO;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers.V1
{

	[ApiController]
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/commandes")]
	[Produces(MediaTypeNames.Application.Json)]
	[Consumes(MediaTypeNames.Application.Json)]
	[AllowAnonymous]

	public class CommandeController : ControllerBase
	{
		private readonly ICommandeService _commandeService = null;

		public CommandeController(ICommandeService commandeService)
		{
			_commandeService = commandeService;
		}



		/// <summary>
		/// Permet de récupérer une commande en fonction de son Identifiant
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet("afficher")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetCommande([FromQuery] CommandRequest commandeRequest)
		{
			CommandeDto commande = await _commandeService.GetCommandeByDate(commandeRequest.DateDebut, commandeRequest.DateFin);
			if (commande == null)
			{
				return NotFound(); // StatusCode = 404
			}
			else
			{
				return Ok(commande); // StatusCode = 200
			}
		}

		/// <summary>
		/// Permet de créer une commande en BDD
		/// </summary>
		/// <param name="commande"></param>
		/// <returns>retourne la commande avec le nouvel identifiant généré</returns>
		//[HttpPost()]
		//[ProducesResponseType(StatusCodes.Status201Created)]
		//[ProducesResponseType(StatusCodes.Status400BadRequest)]
		////public async Task<IActionResult> CreateCommande([FromBody] Commande commande)
		////{
		////	// Ajout de la commande avec la bll server
		////	Commande newCommande = await _reservationService.CreateCommande(commande);
		////	if (newCommande != null)
		////	{
		////		// Créer une redirection vers GetcommandeById(newCommande.IdCommande);
		////		return CreatedAtAction(nameof(GetCommandeById), new { id = newCommande.IdCommande }, newCommande);
		////	}
		////	else
		////	{
		////		// Retourne un code 400  Bad Request
		////		return BadRequest();
		////	}
		////}


	}



}

