using Microsoft.AspNetCore.Mvc;
using desafio.Model;

namespace desafio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ok";
        }
    }
}