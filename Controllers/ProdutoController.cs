using Microsoft.AspNetCore.Mvc;
using desafio.Model;
using desafio.Repository;

namespace desafio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
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