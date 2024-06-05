using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LookingThings.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Objeto",
                columns: table => new
                {
                    ObjetoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjetoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjetoCor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjetoObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjetoLocalDesaparecimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjetoFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjetoDtDesaparecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObjetoDtEncontro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ObjetoStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objeto", x => x.ObjetoId);
                    table.ForeignKey(
                        name: "FK_Objeto_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Observacoes",
                columns: table => new
                {
                    ObservacoesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacoesDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObservacoesData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ObjetoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacoes", x => x.ObservacoesId);
                    table.ForeignKey(
                        name: "FK_Observacoes_Objeto_ObjetoId",
                        column: x => x.ObjetoId,
                        principalTable: "Objeto",
                        principalColumn: "ObjetoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Observacoes_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objeto_UsuarioId",
                table: "Objeto",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_ObjetoId",
                table: "Observacoes",
                column: "ObjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_UsuarioId",
                table: "Observacoes",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observacoes");

            migrationBuilder.DropTable(
                name: "Objeto");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
