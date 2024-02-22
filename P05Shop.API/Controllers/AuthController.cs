using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services.AuthService;
using P06Shop.Shared;
using P06Shop.Shared.Auth;
using System.Security.Claims;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("secret"), Authorize]
        public string SecretText()
        {
            return "This is a secret text";
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceReponse<string>>> Login(UserLoginDto userLoginDto)
        {
            var response = await _authService.Login(userLoginDto.Email, userLoginDto.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceReponse<int>>> Register(UserRegisterDto userRegisterDto)
        {
            var user = new User
            {
                Email = userRegisterDto.Email,
                Username = userRegisterDto.UserName
            };

            var response = await _authService.Register(user, userRegisterDto.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("changePassword"), Authorize]
        public async Task<ActionResult<ServiceReponse<bool>>> ChangePassword([FromBody] string newPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authService.ChangePassword(int.Parse(userId), newPassword);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
