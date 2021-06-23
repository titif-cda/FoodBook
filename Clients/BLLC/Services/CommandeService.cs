using BO.DTO.Responses;
using System;
using System.Collections.Generic;
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
		private readonly HttpClient _httpClient;

		public CommandeService()
		{
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://localhost:5001/api/v1/");
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

	}

}
