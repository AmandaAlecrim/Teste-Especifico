using Microsoft.EntityFrameworkCore;
using desafio.Model;

namespace desafio.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}