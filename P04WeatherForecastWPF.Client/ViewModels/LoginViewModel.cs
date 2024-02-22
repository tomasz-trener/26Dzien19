using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Services.AuthService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastWPF.Client.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private static string Token { get; set; } = string.Empty;

        private readonly IAuthService _authService;

        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
            UserLoginDto = new UserLoginDto();
        }

        [ObservableProperty]
        private UserLoginDto userLoginDto;


        public async Task Login(string password)
        {
            UserLoginDto.Password = password;

            var result = await _authService.Login(UserLoginDto);
            if (result.Success)
            {
                Token = result.Data;
            }
            else
            {
                //wyświetlenie komunikatu o błędzie
            }
        }

        [RelayCommand]
        public async Task MouseEnter()
        {

        }


    }
}
