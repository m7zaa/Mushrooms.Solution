using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Shrooms.Services;
using Shrooms.Models;
using System.Linq;

namespace Shrooms.Controllers
{
  [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private ShroomsContext _db;

        public UsersController(IUserService userService, ShroomsContext db)
        {
            _userService = userService;
            _db = db;
        }
    

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
             var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public void Create([FromBody]User userParam)
        {
            //if username is not in the database
                //use .Any( a => a.Username == userParam.UserName)
            Console.WriteLine("check");
            if(!_db.Users.Any(a => a.Username == userParam.Username))
            {
                userParam.PasswordHash = SecurePasswordHasher.Hash(userParam.Password, 1000);
                userParam.Password = null;
                _db.Users.Add(userParam);
                _db.SaveChanges();
            }
        }
    }
}
