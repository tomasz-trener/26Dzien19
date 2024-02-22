using P06Shop.Shared.Auth;

namespace P06Shop.Shared.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public Task<ServiceReponse<bool>> ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<string>> Login(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<int>> Register(UserRegisterDto userLoginDto)
        {
            throw new NotImplementedException();
        }
    }
}
