using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroTabelasRelacionadas.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_produtos_CategoriaId",
                table: "produtos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos");

            migrationBuilder.DropIndex(
                name: "IX_produtos_CategoriaId",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "produtos");
        }
    }
}
