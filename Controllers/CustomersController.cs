using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_Treinamento_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        public string Get()
        {
            string nome = "Jonh Doe";

            return JsonConvert.SerializeObject(nome);

        } 
    }
}
