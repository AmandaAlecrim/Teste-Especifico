using desafio.Model;

namespace desafio.Repository
{
    //implementação da interface
    public class ProdutoRepository : IProdutoRepository
    {
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