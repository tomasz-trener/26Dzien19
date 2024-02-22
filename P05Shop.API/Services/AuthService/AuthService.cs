using Microsoft.EntityFrameworkCore;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Auth;

namespace P05Shop.API.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;

        public AuthService(DataContext context)
        {
            _context = context;
        }

        public Task<ServiceReponse<bool>> ChangePassword(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceReponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
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
