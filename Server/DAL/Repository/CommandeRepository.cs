using BO.DTO.Responses;
using BO.Entity;
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

		public async Task<CommandeDto> GetAsync()
		{
			var stmt = @"select I.Nom as Nom, Sum(Mi.Quantite) AS Quantite, Sum(Mi.Quantite* I.Prix) AS Price
				  From Ingredient as I 
				  JOIN MetsIngredients as Mi ON I.Id = Mi.IdIngredient
				  JOIN Mets as m ON Mi.IdMet = m.Id
				  JOIN ServiceMets as Sm ON m.Id = Sm.IdMet
				  JOIN Service as S ON Sm.IdService = S.Id
				  JOIN Reservation as R ON S.Id = R.IdService
				  GROUP by I.Id, I.Nom, I.Prix;";
			List<LigneCommandeDto> commandes = (await _session.Connection.QueryAsync<LigneCommandeDto>(stmt, null, _session.Transaction)).ToList();


			return new CommandeDto()
			{
				TotalPrix = commandes.Select(e => e.Price).Aggregate((p1, p2) => p1 + p2),
				ListIngredientQteDTOs = commandes
			};
		}
	}
}
