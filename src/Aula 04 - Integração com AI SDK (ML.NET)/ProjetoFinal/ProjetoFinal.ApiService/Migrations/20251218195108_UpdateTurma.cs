using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinal.ApiService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTurma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoDaTurma",
                table: "Turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoDaTurma",
                table: "Turmas");
        }
    }
}
