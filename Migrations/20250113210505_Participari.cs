using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class Participari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membru",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeRegizor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membru", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Participare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembruID = table.Column<int>(type: "int", nullable: true),
                    SpectacolID = table.Column<int>(type: "int", nullable: true),
                    DataSpectacol = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participare", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Participare_Membru_MembruID",
                        column: x => x.MembruID,
                        principalTable: "Membru",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Participare_Spectacol_SpectacolID",
                        column: x => x.SpectacolID,
                        principalTable: "Spectacol",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participare_MembruID",
                table: "Participare",
                column: "MembruID");

            migrationBuilder.CreateIndex(
                name: "IX_Participare_SpectacolID",
                table: "Participare",
                column: "SpectacolID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participare");

            migrationBuilder.DropTable(
                name: "Membru");
        }
    }
}
