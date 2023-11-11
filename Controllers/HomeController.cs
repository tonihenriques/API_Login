using API_Treinamento_Auth.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Treinamento_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        public string Anonymous() => "Anonimos";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated()
        {
            return $"Usuario Autenticado - {User.Identity.Name}";
        }
    }
}
