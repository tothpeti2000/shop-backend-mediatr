using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartItem_SharedCart_CartId",
                table: "SharedCartItem");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "SharedCartItem",
                newName: "SharedCartId");

            migrationBuilder.RenameIndex(
                name: "IX_SharedCartItem_CartId",
                table: "SharedCartItem",
                newName: "IX_SharedCartItem_SharedCartId");

            migrationBuilder.CreateTable(
                name: "SharedOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SharedCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedOrder_SharedCart_SharedCartId",
                        column: x => x.SharedCartId,
                        principalTable: "SharedCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SharedOrder_SharedCartId",
                table: "SharedOrder",
                column: "SharedCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartItem_SharedCart_SharedCartId",
                table: "SharedCartItem",
                column: "SharedCartId",
                principalTable: "SharedCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartItem_SharedCart_SharedCartId",
                table: "SharedCartItem");

            migrationBuilder.DropTable(
                name: "SharedOrder");

            migrationBuilder.RenameColumn(
                name: "SharedCartId",
                table: "SharedCartItem",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_SharedCartItem_SharedCartId",
                table: "SharedCartItem",
                newName: "IX_SharedCartItem_CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartItem_SharedCart_CartId",
                table: "SharedCartItem",
                column: "CartId",
                principalTable: "SharedCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
