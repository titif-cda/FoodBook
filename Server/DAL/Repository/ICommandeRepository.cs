using BO.DTO.Responses;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICommandeRepository
    {
        Task<CommandeDto> GetAsync();
        //Task<CommandeDto> GetCommandeByDate();
    }
}