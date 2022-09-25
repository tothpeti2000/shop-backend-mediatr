using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ProductsAndCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("0e86b7fb-0823-482c-b931-bbe8fbdf6731"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("12297e15-f812-4d32-9a78-457441613538"), null, "Construction toy", new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5") },
                    { new Guid("29c58271-9b2f-401d-9dcc-7623c77200c6"), null, "Baby toy", new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5") },
                    { new Guid("53adfbff-f3b2-42b4-8295-19012a5a4291"), null, "Bicycles", new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5") },
                    { new Guid("89f5e936-d70a-422f-abd4-941da618ecd4"), null, "Plush figure", new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5") },
                    { new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc"), null, "Wooden toy", new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("6256d78d-1a97-41e5-a92b-512b22e76feb"), 5.0, new Guid("0e86b7fb-0823-482c-b931-bbe8fbdf6731"), "Description", null, "Child supervision for 1 hour", 800.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("018e4bce-43d1-44d2-a08d-6cb428464847"), null, "Toys for skill development", new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc") },
                    { new Guid("14b9f3a3-9ecf-49a1-abe0-8b32e8deb102"), null, "Months 18-24", new Guid("29c58271-9b2f-401d-9dcc-7623c77200c6") },
                    { new Guid("38168820-cb65-4f7c-84a9-52c024b3a9a1"), null, "Tricycle", new Guid("53adfbff-f3b2-42b4-8295-19012a5a4291") },
                    { new Guid("388d892b-7661-4d72-94d4-7186a3e9157d"), null, "Logic toys", new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc") },
                    { new Guid("4d71052e-5ffb-4788-835f-d4d0294e2228"), null, "Craftwork toys", new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc") },
                    { new Guid("627bfd65-61d4-4bd5-99e5-f09e57fd9522"), null, "Baby taxis", new Guid("53adfbff-f3b2-42b4-8295-19012a5a4291") },
                    { new Guid("73a8d0c6-9fee-471d-9953-94b61169ae45"), null, "Building blocks", new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc") },
                    { new Guid("88821c87-272e-4d69-87c2-57913442b120"), null, "Months 0-6", new Guid("29c58271-9b2f-401d-9dcc-7623c77200c6") },
                    { new Guid("b2e9416d-807f-4a9c-8096-5659f0a49ea1"), null, "Building items", new Guid("12297e15-f812-4d32-9a78-457441613538") },
                    { new Guid("b3413e39-36ec-40dc-bfc8-a127e29b358a"), null, "Months 6-18", new Guid("29c58271-9b2f-401d-9dcc-7623c77200c6") },
                    { new Guid("b3729a7d-5626-48f7-b435-077f2761551e"), null, "DUPLO", new Guid("12297e15-f812-4d32-9a78-457441613538") },
                    { new Guid("f57325e4-de39-4d1d-84e9-3b5920bc11b1"), null, "LEGO", new Guid("12297e15-f812-4d32-9a78-457441613538") },
                    { new Guid("f829b33f-f770-446c-87ce-29aaee86ef02"), null, "Motors", new Guid("53adfbff-f3b2-42b4-8295-19012a5a4291") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("005e4dcd-4fac-4f26-8292-1d8acabd8550"), 5.0, new Guid("88821c87-272e-4d69-87c2-57913442b120"), "Description", null, "Activity playgim", 7488.0, 21 },
                    { new Guid("1e8497e8-2025-4204-bb5d-bd0d6ad13d16"), 5.0, new Guid("b3413e39-36ec-40dc-bfc8-a127e29b358a"), "Description", null, "Baby telephone", 3725.0, 18 },
                    { new Guid("3733c8bd-bb40-440f-839c-d4e06049e160"), 5.0, new Guid("73a8d0c6-9fee-471d-9953-94b61169ae45"), "Description", null, "Maxi Blocks 56 pcs", 1854.0, 36 },
                    { new Guid("6d31d511-cd30-44d5-8281-73ccb0782642"), 5.0, new Guid("88821c87-272e-4d69-87c2-57913442b120"), "Description", null, "Colorful baby book", 1738.0, 58 },
                    { new Guid("741a0b9f-62f2-4b36-95c1-9a3dab57f9d2"), 5.0, new Guid("73a8d0c6-9fee-471d-9953-94b61169ae45"), "Description", null, "Mega Bloks 24 pcs", 4325.0, 47 },
                    { new Guid("7c9078f9-bb42-4a2e-aac9-c4a28c01f1fa"), 5.0, new Guid("73a8d0c6-9fee-471d-9953-94b61169ae45"), "Description", null, "Building Blocks 80 pcs", 4362.0, 25 },
                    { new Guid("7eacf084-e476-4677-a47f-ea648c907db0"), 5.0, new Guid("b2e9416d-807f-4a9c-8096-5659f0a49ea1"), "Description for LEGO City Harbour", null, "Lego City harbour", 27563.0, 12 },
                    { new Guid("c33b8fce-c0f4-47cf-8b07-44166b9d2722"), 5.0, new Guid("14b9f3a3-9ecf-49a1-abe0-8b32e8deb102"), "Description", null, "Fisher Price hammer toy", 8356.0, 58 },
                    { new Guid("fbfbb1a9-3a15-4236-a7a0-02901ea3e9ff"), 5.0, new Guid("b3729a7d-5626-48f7-b435-077f2761551e"), "Description for LEGO Duplo Excavator", null, "Lego Duplo Excavator", 6399.0, 26 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
