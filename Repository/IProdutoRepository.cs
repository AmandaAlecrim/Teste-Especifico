using desafio.Model;

namespace desafio.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> BuscaProdutos();
        Task<Produto> BuscaProduto(int id);
        void AdicionaProduto(Produto produto);
        void AtualizaProduto(Produto produto);
        void DeleteProduto(Produto produto);

        Task<bool> SaveChangesAsync();
    }
}