using desafio.Model;
using desafio.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Produto>> BuscaProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> BuscaProduto(int id)
        {
            return await _context.Produtos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void AdicionaProduto(Produto produto)
        {
            _context.Add(produto);
        }

        public void AtualizaProduto(Produto produto)
        {
            _context.Update(produto);
        }
        public void DeletaProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        //Retorna true se o documento for salvo com sucesso, caso contrário retorna false
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void DeleteProduto(Produto produto)
        {
            _context.Remove(produto);
        }
    }
}