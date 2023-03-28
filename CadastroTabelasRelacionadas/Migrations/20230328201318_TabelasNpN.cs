using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroTabelasRelacionadas.Migrations
{
    /// <inheritdoc />
    public partial class TabelasNpN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario_permissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    PermissaoId = table.Column<int>(type: "int", nullable: false),
                    usuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario_permissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_permissao_permissoes_PermissaoId",
                        column: x => x.PermissaoId,
                        principalTable: "permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_permissao_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_permissao_PermissaoId",
                table: "usuario_permissao",
                column: "PermissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_permissao_usuariosId",
                table: "usuario_permissao",
                column: "usuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario_permissao");
        }
    }
}
