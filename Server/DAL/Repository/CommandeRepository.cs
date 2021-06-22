using BO.DTO.Responses;
using DAL.UOW;
using Dapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CommandeRepository :ICommandeRepository
    {
		private readonly DbSession _session;
		//private readonly ILogger<CommandeRepository> _logger;
		//	internal CommandeRepository(DbSession dbSession, ILogger<CommandeRepository> logger)
		public CommandeRepository(DbSession dbSession)
		{
			_session = dbSession;
			//_logger = logger;
		}

		public async Task<CommandeResponse> GetAsync()
		{
			var stmt = @"select I.Nom, Sum(Mi.Quantite) AS Quantite,Sum(Mi.Quantite* I.Prix) AS Price
				  From Ingredient I JOIN MetsIngredients Mi ON I.Id = Mi.IdIngredient
				  JOIN Mets m ON Mi.IdMet = m.Id
				  JOIN ServiceMets Sm ON m.Id = Sm.IdMet
				  JOIN Service S ON Sm.IdService = S.Id
				  JOIN Reservation R ON S.Id = R.IdService
				  GROUP BY I.Nom;";
			List<IngredientQteDTO> commandes = (await _session.Connection.QueryAsync<IngredientQteDTO>(stmt, null, _session.Transaction)).ToList();

			return new CommandeResponse()
			{
				TotalPrix = ((float)commandes.Select(e => e.ingredient.Prix).Single()),//.Aggregate((p1, p2) => p1 + p2),
				ListIngredientQteDTOs = commandes
			};
		}
	}
}
