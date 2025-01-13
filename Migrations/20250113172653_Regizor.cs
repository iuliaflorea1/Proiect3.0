using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class Regizor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Regizor",
                table: "Spectacol");

            migrationBuilder.AddColumn<int>(
                name: "RegizorID",
                table: "Spectacol",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regizor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeRegizor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regizor", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spectacol_RegizorID",
                table: "Spectacol",
                column: "RegizorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Spectacol_Regizor_RegizorID",
                table: "Spectacol",
                column: "RegizorID",
                principalTable: "Regizor",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spectacol_Regizor_RegizorID",
                table: "Spectacol");

            migrationBuilder.DropTable(
                name: "Regizor");

            migrationBuilder.DropIndex(
                name: "IX_Spectacol_RegizorID",
                table: "Spectacol");

            migrationBuilder.DropColumn(
                name: "RegizorID",
                table: "Spectacol");

            migrationBuilder.AddColumn<string>(
                name: "Regizor",
                table: "Spectacol",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
