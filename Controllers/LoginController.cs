using API_Treinamento_Auth.auth_settings;
using API_Treinamento_Auth.Entidades;
using API_Treinamento_Auth.Repository;
using API_Treinamento_Auth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static API_Treinamento_Auth.Services.ServiceToken;

namespace API_Treinamento_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);  
            if (user == null) {

                return NotFound(new { message = "Usuario ou Senha inválidos!" });
            }
            else
            {
                #region token01
                //var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(settings.secret));
                //var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //var claims = new List<Claim>()
                //{
                //    new Claim(ClaimTypes.Name, user.Username),
                //    new Claim(ClaimTypes.Role, "Manager")                  


                //};

                //var tokenOptions = new JwtSecurityToken(
                //    issuer: "http://localhost:5130",
                //    audience: "http://localhost:5130",
                //    claims: claims,
                //    expires: DateTime.Now.AddMinutes(5),
                //    signingCredentials: signingCredentials

                //    );


                //var tokenstring = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                //return Ok(new { Token = tokenstring });

                #endregion
                var token = GenerateToken(user);

                return Ok(new { Token = token });
            }


            //return Unauthorized();
            //var token = JsonSerializer.Serialize( ServiceToken.GenerateToken(user));

            //user.Password = "";

            //return token;

        }

        
    }
}
