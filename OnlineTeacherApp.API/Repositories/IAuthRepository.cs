using System.Threading.Tasks;
using OnlineTeacherApp.API.Models;

namespace OnlineTeacherApp.API.Repositories
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}