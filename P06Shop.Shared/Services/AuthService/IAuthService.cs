using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P06Shop.Shared.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceReponse<string>> Login(UserLoginDto userLoginDto);
        Task<ServiceReponse<int>> Register(UserRegisterDto userLoginDto);

        Task<ServiceReponse<bool>> ChangePassword(string newPassword);
    }
}
