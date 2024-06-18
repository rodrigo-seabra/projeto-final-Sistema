using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LookingThings.Migrations
{
    /// <inheritdoc />
    public partial class AddObservacaoLocalToObservacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ObservacaoLocal",
                table: "Observacoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObservacaoLocal",
                table: "Observacoes");
        }
    }
}
