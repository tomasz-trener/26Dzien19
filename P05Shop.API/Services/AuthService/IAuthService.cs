using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P05Shop.API.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceReponse<string>> Login(string email, string password);
        Task<ServiceReponse<int>> Register(User user, string password);

        Task<ServiceReponse<bool>> ChangePassword(int userId, string newPassword);

        Task<bool> UserExists(string email);
    }
}
