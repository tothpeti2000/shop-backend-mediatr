using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0be7bf86-c0ea-49a5-8804-9d1fca579b7c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6c07e918-4203-45d8-96fc-e3949e303258"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7cf6048e-8c31-479f-b154-850ca592ad75"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7ed0dcb8-32f4-43d6-a65d-2d4cb34cfe5b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7fd3fe0d-6313-4409-84d8-1227176f9511"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8a67cd56-20ae-4b85-aab2-7fd837075059"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8c7230a9-a799-455c-908e-80ece0b8237a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d833c37c-4d5e-4e41-8a5a-d2d47dfa135b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("096d438e-bb3d-4907-a163-20b7c0eec0c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("36a6e8e4-ce6e-44e3-b165-f32cbf6529b6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a1f350f-ceec-4504-88f1-0d5eafdb2af8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9438d627-dddf-4f8a-b4d3-6bb794fe285d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a7f60739-39c8-4e39-b358-37d8a0012534"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc96af31-2338-4de0-959f-b20c0032a902"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e9427d10-3ef3-4ebd-a3af-8cf533baf05a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f0b113a2-8a87-4356-b0e5-8bd100878ab1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f23a05df-a0f8-42cc-9028-dc71c6261046"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f5eca16a-82da-4c44-b71f-8c3cb8a07ff2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("157dc393-3209-4b95-bdd5-de096a5fe2db"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("16553db4-b679-4399-bd7c-f856ddce7097"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1c53ed1a-784b-4853-ae2f-bab8d2087087"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("34fe884f-f279-4b87-987b-f01f35c4d55f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9b305d9d-9a57-4b19-abc3-8ddf8d66542b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a66e93f1-c446-4c8d-a78f-43d5206de54e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bb68e436-1b28-4ee7-8209-8aae077f9fda"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d128db53-33a6-4bbb-975b-9235200d07a5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e8f670c7-178c-4ede-8b34-d659e1301979"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f6e38bd2-784b-4d57-bcec-fc015a726180"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dd5d926b-24c7-4279-ae95-291d704da69f"));

            migrationBuilder.AddColumn<Guid>(
                name: "SharedCartId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SharedCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SharedCartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedCartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SharedCartItem_SharedCart_CartId",
                        column: x => x.CartId,
                        principalTable: "SharedCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("7af3d82c-32b0-4d9f-af6d-735c2389ce05"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("1b30b082-7891-4ffb-a40e-757b8f72457d"), null, "Baby toy", new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0") },
                    { new Guid("b143d359-7c49-493d-b72b-ae18e8b3cd55"), null, "Bicycles", new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0") },
                    { new Guid("d2512cec-edc2-4c36-90ef-497441ea1f7d"), null, "Plush figure", new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0") },
                    { new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d"), null, "Wooden toy", new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0") },
                    { new Guid("f7241381-ed73-4c45-b5cd-a575cb577fab"), null, "Construction toy", new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("65828541-f32d-43f1-8fe5-37f13477fd28"), 5.0, new Guid("7af3d82c-32b0-4d9f-af6d-735c2389ce05"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("11324878-685c-439b-a34f-ea2af36bfdce"), null, "Logic toys", new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d") },
                    { new Guid("1bdffe6b-3418-4417-838f-a5f513bf735f"), null, "Building items", new Guid("f7241381-ed73-4c45-b5cd-a575cb577fab") },
                    { new Guid("50ee346e-1f42-4d78-aa82-9bd23a78290b"), null, "Toys for skill development", new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d") },
                    { new Guid("590bd601-2506-417c-8bef-b81fa83fcfac"), null, "Baby taxis", new Guid("b143d359-7c49-493d-b72b-ae18e8b3cd55") },
                    { new Guid("7252b85f-f12f-4c55-be22-3820fd2143cf"), null, "Months 0-6", new Guid("1b30b082-7891-4ffb-a40e-757b8f72457d") },
                    { new Guid("980ed0a9-6f25-499c-a445-4047e76b3f94"), null, "Months 18-24", new Guid("1b30b082-7891-4ffb-a40e-757b8f72457d") },
                    { new Guid("9a7894c6-ba8d-414d-a905-31bb1cebfbf1"), null, "Motors", new Guid("b143d359-7c49-493d-b72b-ae18e8b3cd55") },
                    { new Guid("9ce877e2-c5a0-42b2-b63a-de5f9c0d08e3"), null, "DUPLO", new Guid("f7241381-ed73-4c45-b5cd-a575cb577fab") },
                    { new Guid("a7f4cb3a-fc96-4cbb-a8e1-4069bf3f3651"), null, "LEGO", new Guid("f7241381-ed73-4c45-b5cd-a575cb577fab") },
                    { new Guid("b85fb485-4360-45f9-93cf-6415133449c1"), null, "Craftwork toys", new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d") },
                    { new Guid("cd72d927-6dbb-4217-a3c0-86ebfdcda837"), null, "Tricycle", new Guid("b143d359-7c49-493d-b72b-ae18e8b3cd55") },
                    { new Guid("d998cde6-db58-4643-8faa-ce8cad5ae794"), null, "Months 6-18", new Guid("1b30b082-7891-4ffb-a40e-757b8f72457d") },
                    { new Guid("dbfa741b-a215-4d99-b3ae-bacc9f74ded3"), null, "Building blocks", new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("33bef565-2132-4735-b2d0-6170dde91d56"), 5.0, new Guid("7252b85f-f12f-4c55-be22-3820fd2143cf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("3860c94c-dd24-4f44-96b7-0e01804f43e3"), 5.0, new Guid("7252b85f-f12f-4c55-be22-3820fd2143cf"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("6f6c3075-a8b4-48af-9dc5-204184bdf2f6"), 3.5, new Guid("9ce877e2-c5a0-42b2-b63a-de5f9c0d08e3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("7323cf5f-38ea-4e34-b9d0-ad785a05e434"), 5.0, new Guid("1bdffe6b-3418-4417-838f-a5f513bf735f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("92eb9912-4de6-4585-989e-8116b5f3585b"), 5.0, new Guid("980ed0a9-6f25-499c-a445-4047e76b3f94"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 },
                    { new Guid("9e98a553-6498-46a7-aaa5-09b600e763bb"), 5.0, new Guid("dbfa741b-a215-4d99-b3ae-bacc9f74ded3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("b889d8dd-40c9-482c-804b-a95f7d5068d4"), 4.7999999999999998, new Guid("dbfa741b-a215-4d99-b3ae-bacc9f74ded3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("c35d0f65-69a2-430a-a8a5-eb0a13625fb3"), 5.0, new Guid("d998cde6-db58-4643-8faa-ce8cad5ae794"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("db6b5b7e-ddfd-4fa6-8f11-9c964a9ea9c1"), 4.9000000000000004, new Guid("dbfa741b-a215-4d99-b3ae-bacc9f74ded3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SharedCartId",
                table: "AspNetUsers",
                column: "SharedCartId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedCartItem_CartId",
                table: "SharedCartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedCartItem_ProductId",
                table: "SharedCartItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SharedCart_SharedCartId",
                table: "AspNetUsers",
                column: "SharedCartId",
                principalTable: "SharedCart",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SharedCart_SharedCartId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SharedCartItem");

            migrationBuilder.DropTable(
                name: "SharedCart");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SharedCartId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("11324878-685c-439b-a34f-ea2af36bfdce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("50ee346e-1f42-4d78-aa82-9bd23a78290b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("590bd601-2506-417c-8bef-b81fa83fcfac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9a7894c6-ba8d-414d-a905-31bb1cebfbf1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a7f4cb3a-fc96-4cbb-a8e1-4069bf3f3651"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b85fb485-4360-45f9-93cf-6415133449c1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cd72d927-6dbb-4217-a3c0-86ebfdcda837"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d2512cec-edc2-4c36-90ef-497441ea1f7d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("33bef565-2132-4735-b2d0-6170dde91d56"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3860c94c-dd24-4f44-96b7-0e01804f43e3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("65828541-f32d-43f1-8fe5-37f13477fd28"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f6c3075-a8b4-48af-9dc5-204184bdf2f6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7323cf5f-38ea-4e34-b9d0-ad785a05e434"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92eb9912-4de6-4585-989e-8116b5f3585b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9e98a553-6498-46a7-aaa5-09b600e763bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b889d8dd-40c9-482c-804b-a95f7d5068d4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c35d0f65-69a2-430a-a8a5-eb0a13625fb3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("db6b5b7e-ddfd-4fa6-8f11-9c964a9ea9c1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1bdffe6b-3418-4417-838f-a5f513bf735f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7252b85f-f12f-4c55-be22-3820fd2143cf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7af3d82c-32b0-4d9f-af6d-735c2389ce05"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("980ed0a9-6f25-499c-a445-4047e76b3f94"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9ce877e2-c5a0-42b2-b63a-de5f9c0d08e3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b143d359-7c49-493d-b72b-ae18e8b3cd55"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d998cde6-db58-4643-8faa-ce8cad5ae794"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dbfa741b-a215-4d99-b3ae-bacc9f74ded3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1b30b082-7891-4ffb-a40e-757b8f72457d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f0b5efcc-0573-49fc-bb1c-9393b7fad92d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f7241381-ed73-4c45-b5cd-a575cb577fab"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d85d2be3-68c1-4b6e-8e33-0542cfaf28c0"));

            migrationBuilder.DropColumn(
                name: "SharedCartId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("9b305d9d-9a57-4b19-abc3-8ddf8d66542b"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("dd5d926b-24c7-4279-ae95-291d704da69f"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("16553db4-b679-4399-bd7c-f856ddce7097"), null, "Bicycles", new Guid("dd5d926b-24c7-4279-ae95-291d704da69f") },
                    { new Guid("8a67cd56-20ae-4b85-aab2-7fd837075059"), null, "Plush figure", new Guid("dd5d926b-24c7-4279-ae95-291d704da69f") },
                    { new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba"), null, "Wooden toy", new Guid("dd5d926b-24c7-4279-ae95-291d704da69f") },
                    { new Guid("e8f670c7-178c-4ede-8b34-d659e1301979"), null, "Baby toy", new Guid("dd5d926b-24c7-4279-ae95-291d704da69f") },
                    { new Guid("f6e38bd2-784b-4d57-bcec-fc015a726180"), null, "Construction toy", new Guid("dd5d926b-24c7-4279-ae95-291d704da69f") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("5a1f350f-ceec-4504-88f1-0d5eafdb2af8"), 5.0, new Guid("9b305d9d-9a57-4b19-abc3-8ddf8d66542b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0be7bf86-c0ea-49a5-8804-9d1fca579b7c"), null, "Logic toys", new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba") },
                    { new Guid("157dc393-3209-4b95-bdd5-de096a5fe2db"), null, "DUPLO", new Guid("f6e38bd2-784b-4d57-bcec-fc015a726180") },
                    { new Guid("1c53ed1a-784b-4853-ae2f-bab8d2087087"), null, "Months 0-6", new Guid("e8f670c7-178c-4ede-8b34-d659e1301979") },
                    { new Guid("34fe884f-f279-4b87-987b-f01f35c4d55f"), null, "Months 6-18", new Guid("e8f670c7-178c-4ede-8b34-d659e1301979") },
                    { new Guid("6c07e918-4203-45d8-96fc-e3949e303258"), null, "Craftwork toys", new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba") },
                    { new Guid("7cf6048e-8c31-479f-b154-850ca592ad75"), null, "Tricycle", new Guid("16553db4-b679-4399-bd7c-f856ddce7097") },
                    { new Guid("7ed0dcb8-32f4-43d6-a65d-2d4cb34cfe5b"), null, "Toys for skill development", new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba") },
                    { new Guid("7fd3fe0d-6313-4409-84d8-1227176f9511"), null, "Motors", new Guid("16553db4-b679-4399-bd7c-f856ddce7097") },
                    { new Guid("8c7230a9-a799-455c-908e-80ece0b8237a"), null, "LEGO", new Guid("f6e38bd2-784b-4d57-bcec-fc015a726180") },
                    { new Guid("a66e93f1-c446-4c8d-a78f-43d5206de54e"), null, "Months 18-24", new Guid("e8f670c7-178c-4ede-8b34-d659e1301979") },
                    { new Guid("bb68e436-1b28-4ee7-8209-8aae077f9fda"), null, "Building items", new Guid("f6e38bd2-784b-4d57-bcec-fc015a726180") },
                    { new Guid("d128db53-33a6-4bbb-975b-9235200d07a5"), null, "Building blocks", new Guid("9b1f0e18-5191-4a6c-9061-c80c6cf655ba") },
                    { new Guid("d833c37c-4d5e-4e41-8a5a-d2d47dfa135b"), null, "Baby taxis", new Guid("16553db4-b679-4399-bd7c-f856ddce7097") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("096d438e-bb3d-4907-a163-20b7c0eec0c1"), 5.0, new Guid("1c53ed1a-784b-4853-ae2f-bab8d2087087"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("36a6e8e4-ce6e-44e3-b165-f32cbf6529b6"), 5.0, new Guid("bb68e436-1b28-4ee7-8209-8aae077f9fda"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("9438d627-dddf-4f8a-b4d3-6bb794fe285d"), 3.5, new Guid("157dc393-3209-4b95-bdd5-de096a5fe2db"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("a7f60739-39c8-4e39-b358-37d8a0012534"), 4.7999999999999998, new Guid("d128db53-33a6-4bbb-975b-9235200d07a5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("dc96af31-2338-4de0-959f-b20c0032a902"), 5.0, new Guid("34fe884f-f279-4b87-987b-f01f35c4d55f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("e9427d10-3ef3-4ebd-a3af-8cf533baf05a"), 5.0, new Guid("a66e93f1-c446-4c8d-a78f-43d5206de54e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 },
                    { new Guid("f0b113a2-8a87-4356-b0e5-8bd100878ab1"), 5.0, new Guid("d128db53-33a6-4bbb-975b-9235200d07a5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("f23a05df-a0f8-42cc-9028-dc71c6261046"), 5.0, new Guid("1c53ed1a-784b-4853-ae2f-bab8d2087087"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("f5eca16a-82da-4c44-b71f-8c3cb8a07ff2"), 4.9000000000000004, new Guid("d128db53-33a6-4bbb-975b-9235200d07a5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 }
                });
        }
    }
}
