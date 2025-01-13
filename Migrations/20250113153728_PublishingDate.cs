﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect3._0.Migrations
{
    /// <inheritdoc />
    public partial class PublishingDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataSpectacol",
                table: "Spectacol",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataSpectacol",
                table: "Spectacol");
        }
    }
}
