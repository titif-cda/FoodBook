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
		/// Permet de récupérer la liste des ingrédients à commander  
		/// </summary>
		/// <param name="commandeRequest">Les dates de début et fin </param>
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
	}
}

