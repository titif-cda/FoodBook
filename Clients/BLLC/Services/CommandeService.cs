using BLLC.Extensions;
using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLLC.Services
{
	public class CommandeService : ICommandeService
	{
		private readonly HttpClient _httpClient = AuthentificationService.Instance.httpClient;

		public CommandeService()
		{
			
		}

		public async Task<CommandeDto> GetCommande()
		{

			if (AuthentificationService.Instance.isLogged)
			{

				_httpClient.DefaultRequestHeaders.Authorization =
					new AuthenticationHeaderValue("Bearer", AuthentificationService.Instance.Token);


				var reponse = await _httpClient.GetAsync($"commandes/afficher");

				if (reponse.IsSuccessStatusCode)
				{
					using (var stream = await reponse.Content.ReadAsStreamAsync())
					{
						CommandeDto commande = await JsonSerializer.DeserializeAsync<CommandeDto>(stream,
							new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
						return commande;
					}
				}
				else
				{
					return null;
				}
			}


			return null;

		}
		public async Task<CommandeDto> GetCommandeByDate(DateTime dateDebut, DateTime dateFin)
		{

			if (AuthentificationService.Instance.isLogged)
			{

				_httpClient.DefaultRequestHeaders.Authorization =
					new AuthenticationHeaderValue("Bearer", AuthentificationService.Instance.Token);


				var reponse = await _httpClient.GetAsync($"commandes/afficher{new { dateDebut = dateDebut.ToString("s", CultureInfo.InvariantCulture), dateFin=dateFin.ToString("s", CultureInfo.InvariantCulture) }.ToUriQuery()}");

				if (reponse.IsSuccessStatusCode)
				{
					using (var stream = await reponse.Content.ReadAsStreamAsync())
					{
						CommandeDto commande = await JsonSerializer.DeserializeAsync<CommandeDto>(stream,
							new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
						return commande;
					}
				}
				else
				{
					return null;
				}
			}
			return null;
		}
	}

}
