using Microsoft.AspNetCore.Mvc;
using desafio.Model;

namespace desafio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> Produtos()
        {
            return new List<Produto>{
                new Produto{Id = 1, NomeProduto = "Macarrão", Preco = 3.80}
            };
        }
        [HttpGet]//método GET
        public IActionResult Get()
        {
            return Ok(Produtos());
        }

        [HttpPost]//método POST
        public IActionResult Post(Produto produto)
        {
            var produtos = Produtos();
            produtos.Add(produto);
            return Ok(produtos);
        }
    }
}