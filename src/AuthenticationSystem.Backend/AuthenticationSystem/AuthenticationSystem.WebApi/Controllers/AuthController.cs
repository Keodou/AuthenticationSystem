using AuthenticationSystem.Domain;
using AuthenticationSystem.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        /// <summary>
        /// Register a new user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = request.Login,
                PasswordHash = passwordHash,
            };

            return Ok(user);
        }
    }
}
