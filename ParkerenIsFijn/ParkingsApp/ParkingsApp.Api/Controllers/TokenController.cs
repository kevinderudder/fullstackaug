using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ParkingsApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration config;

        public TokenController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpPost("CreateToken")]
        [AllowAnonymous]
        public IActionResult CreateToken([FromBody]LoginModel login) {
            IActionResult response = Unauthorized();

            UserModel user = Authenticate(login);
            if (user != null) {
                string tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }

        private string BuildToken(UserModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:ServerSecret"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    config["JWT:Issuer"],
                    config["JWT:Issuer"],
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(LoginModel login)
        {
            // nog db paswoord ophalen en checken
            if (login.Username == "kevin" && login.Password == "p@ssword") {
                UserModel user = new UserModel() {
                    Email = "kevin.derudder@elmos.be",
                    Name = "Kevin"
                };

                return user;
            }
            else
            {
                return null;
            }
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}