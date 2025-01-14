using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class Tip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipID",
                table: "Spectacol",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spectacol_TipID",
                table: "Spectacol",
                column: "TipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Spectacol_Tip_TipID",
                table: "Spectacol",
                column: "TipID",
                principalTable: "Tip",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spectacol_Tip_TipID",
                table: "Spectacol");

            migrationBuilder.DropIndex(
                name: "IX_Spectacol_TipID",
                table: "Spectacol");

            migrationBuilder.DropColumn(
                name: "TipID",
                table: "Spectacol");
        }
    }
}
