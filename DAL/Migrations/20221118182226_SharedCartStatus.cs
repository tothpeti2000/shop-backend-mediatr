using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedCartStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "SharedCart");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SharedCart",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SharedCart");

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "SharedCart",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
