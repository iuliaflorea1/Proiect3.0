using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class Locatie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocatiaID",
                table: "Spectacol",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Locatia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireLocatie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatia", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spectacol_LocatiaID",
                table: "Spectacol",
                column: "LocatiaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Spectacol_Locatia_LocatiaID",
                table: "Spectacol",
                column: "LocatiaID",
                principalTable: "Locatia",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spectacol_Locatia_LocatiaID",
                table: "Spectacol");

            migrationBuilder.DropTable(
                name: "Locatia");

            migrationBuilder.DropIndex(
                name: "IX_Spectacol_LocatiaID",
                table: "Spectacol");

            migrationBuilder.DropColumn(
                name: "LocatiaID",
                table: "Spectacol");
        }
    }
}
