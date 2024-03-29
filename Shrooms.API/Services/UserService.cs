using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Shrooms.Models;
using Shrooms.Helpers;

namespace Shrooms.Services
{



    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }

    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        // private List<User> _users = new List<User>
        // { 
        //     new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }, 
        //     new User { Id = 2, FirstName = "Micah", LastName = "Zaayer", Username = "mz", Password = "mz" } 
        // };
        private ShroomsContext _db;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, ShroomsContext db)
        {
            _appSettings = appSettings.Value;
            _db = db;
        }

        public User Authenticate(string username, string password)
        {
            //take in user
            //hash password

            string hashedPassword = SecurePasswordHasher.Hash(password, 1000);

            //look in database for entry with matchign username and hashed password

            User userFromDb = _db.Users.FirstOrDefault(a => a.Username == username);

            //use 'verify' method of hash class
            if (SecurePasswordHasher.Verify(userFromDb.PasswordHash, hashedPassword))
            {
                return null;
            }

            //if true return ok(user)

            var user = _db.Users.SingleOrDefault(x => x.Username == username);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            // return users without passwords
            return _db.Users;
        }
    }
}
