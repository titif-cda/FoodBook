using BO.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ICommandeService
    {
        Task<CommandeDto> GetCommande();
        Task<CommandeDto> GetCommandeByDate(DateTime? dateDebut, DateTime? dateFin);
    }
}
