using desafio.Model;
using desafio.Data;

namespace desafio.Repository
{
    //implementação da interface
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context)
        {
            _context = context;
        }
        public void AdicionaProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void AtualizaProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BuscaProduto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> BuscaProdutos()
        {
            throw new NotImplementedException();
        }

        public void DeleteProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}