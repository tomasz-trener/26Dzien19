using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpGet("secret"), Authorize]
        public string SecretText()
        {
            return "This is a secret text";
        }

        public async Task<ActionResult<ServiceReponse<string>>> Login(UserLoginDto userLoginDto)
        {
           
        }
    }
}
