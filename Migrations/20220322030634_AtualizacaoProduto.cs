using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio.Migrations
{
    public partial class AtualizacaoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "tb_produto");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "tb_produto",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_produto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NomeProduto",
                table: "tb_produto",
                newName: "nome_produto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_produto",
                table: "tb_produto",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_produto",
                table: "tb_produto");

            migrationBuilder.RenameTable(
                name: "tb_produto",
                newName: "Produtos");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome_produto",
                table: "Produtos",
                newName: "NomeProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");
        }
    }
}
