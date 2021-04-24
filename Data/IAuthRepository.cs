using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
        //The int is the Id of the User
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login (string username, string password);
        Task<bool> UserExists(string username);
    }
}