using BO.DTO.Responses;
using System;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICommandeRepository
    {
        Task<CommandeDto> GetAsync();
        //Task<CommandeDto> GetCommandeByDate();
        Task<CommandeDto> GetCommandeByDate(DateTime? dateDebut, DateTime? dateFin);
    }
}