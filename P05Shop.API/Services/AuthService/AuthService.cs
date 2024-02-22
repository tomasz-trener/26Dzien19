using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P05Shop.API.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public Task<ServiceReponse<bool>> ChangePassword(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<int>> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<bool>> UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
