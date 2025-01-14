using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class migrare1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieSpectacol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorieSpectacol",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpectacolID = table.Column<int>(type: "int", nullable: false),
                    TipID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieSpectacol", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategorieSpectacol_Spectacol_SpectacolID",
                        column: x => x.SpectacolID,
                        principalTable: "Spectacol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieSpectacol_Tip_TipID",
                        column: x => x.TipID,
                        principalTable: "Tip",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieSpectacol_SpectacolID",
                table: "CategorieSpectacol",
                column: "SpectacolID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieSpectacol_TipID",
                table: "CategorieSpectacol",
                column: "TipID");
        }
    }
}
