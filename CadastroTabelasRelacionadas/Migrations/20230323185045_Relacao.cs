using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroTabelasRelacionadas.Migrations
{
    /// <inheritdoc />
    public partial class Relacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_produtos_categoriaId",
                table: "produtos",
                column: "categoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_categoriaId",
                table: "produtos",
                column: "categoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_categoriaId",
                table: "produtos");

            migrationBuilder.DropIndex(
                name: "IX_produtos_categoriaId",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "produtos");
        }
    }
}
