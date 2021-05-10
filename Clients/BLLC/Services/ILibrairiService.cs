using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using System.Threading.Tasks;

namespace BLLC.Services
{
    public interface ILibrairiService
    {
      
       
        Task<Ingredient> CreateIngredient(Ingredient ingredient);

        Task<Client> CreateClient(Client client);
        Task<PageResponse<Client>> GetAllClients(PageRequest pageRequest);

        Task<Client> PutClient(Client client);
      
        Task<PageResponse<Ingredient>> GetAllIngredients(PageRequest pageRequest);
       
       
        Task<Ingredient> ModifyIngredient(Ingredient ingredient);
       
        Task<bool> DeleteIngredient(Ingredient ingredient);
    }
}