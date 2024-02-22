using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace P05Shop.API.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public AuthService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<ServiceReponse<bool>> ChangePassword(int userId, string newPassword)
        {
            var user = await _context.Users.FindAsync(userId); 
            if(user == null)
            {
                return new ServiceReponse<bool>
                {
                    Success = false,
                    Message = "User not found"
                };
            }

            CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.SaveChangesAsync();
            return new ServiceReponse<bool>
            {
                Success = true,
                Message = "Password changed successfully",
                Data = true
            };
        }

        public async Task<ServiceReponse<string>> Login(string email, string password)
        {
            var response = new ServiceReponse<string>();

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found";
            }else if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password";
            }
            else
            {
                response.Success = true;
                response.Data = CreateToken(user);
                response.Message = "Login successful!";
            }

            return response;
        }

        private string CreateToken(User user)
        {
             List<Claim> claims = new List<Claim>()
             {
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                 new Claim(ClaimTypes.Name, user.Email),
                 new Claim(ClaimTypes.Role, user.Role), 
                 new Claim("DateCreated", user.DateCreated.ToString())
             };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                             claims: claims,
                             expires: DateTime.Now.AddDays(1),
                             signingCredentials: creds
                            );

            var tokenHandler = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenHandler;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        public async Task<ServiceReponse<int>> Register(User user, string password)
        {
            if(await UserExists(user.Email))
            {
                 return new ServiceReponse<int>
                 {
                     Success = false,
                     Message = "User already exists"
                 };
            }

            // Create password hash
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            //przypisujemy hash i sól do użytkownika
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            //dodajemy użytkownika do bazy
            await _context.Users.AddAsync(user);
            // zapisujemy zmiany w bazie
            await _context.SaveChangesAsync();

            return new ServiceReponse<int>
            {
                Success = true,
                Data = user.Id, 
                Message = "Registration successful!"
            };
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                // generowanie losowej soli
                passwordSalt = hmac.Key;
                // generowanie hasha 
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string email)
        {
            if (await _context.Users.AnyAsync(x => x.Email.ToLower().Equals(email.ToLower())))
                return true;

            return false;
        }
    }
}
