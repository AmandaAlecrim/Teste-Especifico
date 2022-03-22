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
        public async Task<IActionResult> Get()
        //Mostra produtos e, caso não existam, será mostrada uma mensagem que indica estar sem conteúdo.
        {
            var produtos = await _repository.BuscaProdutos();
            return produtos.Any()
            ? Ok(produtos)
            : NoContent();
        }

        [HttpGet("id")]//método GET
        public async Task<IActionResult> GetById(int id)
        //Busca o produto pelo número do id, caso ele não exista, aparecerá uma mensagem "Produto não encontrado.".
        {
            var produto = await _repository.BuscaProduto(id);
            return produto != null
            ? Ok(produto)
            : NotFound("Produto não encontrado.");
        }

        [HttpPost]//método POST
        public async Task<IActionResult> Post(Produto produto)
        //Adiciona produto, caso adicionado ou não com sucesso recebe mensagem avisando o sistema
        {
            _repository.AdicionaProduto(produto);

            return await _repository.SaveChangesAsync()
            ? Ok("Produto adicionado com sucesso!")
            : BadRequest("Erro ao adicionar produto.");
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(int id, Produto produto)
        //Altera nome e preço do produto caso a id digitada exista
        //Após isso é confirmado se o nome e o preço do produto são iguais aos do banco de dados
        //Caso sejam a alteração é permitida.
        {
            var produtoBanco = await _repository.BuscaProduto(id);
            if (produtoBanco == null) return NotFound("Produto não encontrado.");

            produtoBanco.NomeProduto = produto.NomeProduto ?? produtoBanco.NomeProduto;
            produtoBanco.Preco = produto.Preco;

            _repository.AtualizaProduto(produtoBanco);

            return await _repository.SaveChangesAsync()
                ? Ok("Produto atualizado com sucesso!")
                : BadRequest("Erro ao atualizar produto.");
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        //Remove o usuário caso a Id exista
        {
            var produtoBanco = await _repository.BuscaProduto(id);
            if (produtoBanco == null) return NotFound("Produto não encontrado.");

            _repository.DeleteProduto(produtoBanco);

            return await _repository.SaveChangesAsync()
                ? Ok("Produto deletado com sucesso!")
                : BadRequest("Erro ao deletar produto.");
        }
    }
}