using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IAccountService
    {
        Task<LoginResponse> Login(string username, string password);
    }
}