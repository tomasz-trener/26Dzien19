using P06Shop.Shared.Auth;
using System.Net.Http.Json;

namespace P06Shop.Shared.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
                _httpClient = httpClient;
        }
        public async Task<ServiceReponse<bool>> ChangePassword(string newPassword)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/changePassword", newPassword);
            return await result.Content.ReadFromJsonAsync<ServiceReponse<bool>>();
        }

        public async Task<ServiceReponse<string>> Login(UserLoginDto userLoginDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/login", userLoginDto);
            var data = await result.Content.ReadFromJsonAsync<ServiceReponse<string>>();
            return data;
        }

        public async Task<ServiceReponse<int>> Register(UserRegisterDto userLoginDto)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/auth/register", userLoginDto);
            return await result.Content.ReadFromJsonAsync<ServiceReponse<int>>();
        }
    }
}
