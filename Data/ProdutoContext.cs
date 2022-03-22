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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var produto = modelBuilder.Entity<Produto>();

            produto.ToTable("tb_produto");
            produto.HasKey(x => x.Id);// definindo chave primária da tabela

            //definindo nome das colunas da tabela
            produto.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            produto.Property(x => x.NomeProduto).HasColumnName("nome_produto").IsRequired();
            produto.Property(x => x.Preco).HasColumnName("preco");
        }
    }
}