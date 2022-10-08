using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedCartUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SharedCart_SharedCartId",
                table: "AspNetUsers");

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

            migrationBuilder.CreateTable(
                name: "SharedCartUser",
                columns: table => new
                {
                    SharedCartsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedCartUser", x => new { x.SharedCartsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SharedCartUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SharedCartUser_SharedCart_SharedCartsId",
                        column: x => x.SharedCartsId,
                        principalTable: "SharedCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("42b0d963-bb4a-40f0-9301-70eadebf9825"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("d6e31512-caef-4021-a0eb-d36af2319e06"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e"), null, "Wooden toy", new Guid("d6e31512-caef-4021-a0eb-d36af2319e06") },
                    { new Guid("294e3b78-1af4-4cfe-981d-aa0be38663dc"), null, "Bicycles", new Guid("d6e31512-caef-4021-a0eb-d36af2319e06") },
                    { new Guid("3c8042ac-0560-4cab-8783-eb82a38902b8"), null, "Plush figure", new Guid("d6e31512-caef-4021-a0eb-d36af2319e06") },
                    { new Guid("a024ae33-18bf-408b-9890-203b6f6b6bbb"), null, "Construction toy", new Guid("d6e31512-caef-4021-a0eb-d36af2319e06") },
                    { new Guid("cd0ad358-b04c-4991-8fbb-bf04443db747"), null, "Baby toy", new Guid("d6e31512-caef-4021-a0eb-d36af2319e06") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("7d12565a-b399-484f-a2f0-b5270d6d0b04"), 5.0, new Guid("42b0d963-bb4a-40f0-9301-70eadebf9825"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0405a4b3-e872-45dc-b948-9dd537d06344"), null, "DUPLO", new Guid("a024ae33-18bf-408b-9890-203b6f6b6bbb") },
                    { new Guid("1a867759-ad43-4698-8952-3b78ae7d05ee"), null, "LEGO", new Guid("a024ae33-18bf-408b-9890-203b6f6b6bbb") },
                    { new Guid("3c00317d-08d7-46e4-81a7-23d0fc890d5b"), null, "Baby taxis", new Guid("294e3b78-1af4-4cfe-981d-aa0be38663dc") },
                    { new Guid("3dcdd466-8fd9-4c2f-8feb-03f30e3bd75e"), null, "Months 18-24", new Guid("cd0ad358-b04c-4991-8fbb-bf04443db747") },
                    { new Guid("4a9f849c-6459-471e-8f96-a36faf695e39"), null, "Logic toys", new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e") },
                    { new Guid("4e7c8859-4634-4507-a8d1-4756e6c2d05f"), null, "Months 0-6", new Guid("cd0ad358-b04c-4991-8fbb-bf04443db747") },
                    { new Guid("5431d757-10c0-4441-b892-f877cdd43c15"), null, "Craftwork toys", new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e") },
                    { new Guid("84fe4fa4-91b9-4fe0-aa3d-df2f181031cc"), null, "Motors", new Guid("294e3b78-1af4-4cfe-981d-aa0be38663dc") },
                    { new Guid("8708f0ba-5615-437b-9370-f76291200529"), null, "Months 6-18", new Guid("cd0ad358-b04c-4991-8fbb-bf04443db747") },
                    { new Guid("89748580-5029-45fe-9ccc-aa55b8ed6a5a"), null, "Toys for skill development", new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e") },
                    { new Guid("cd9e62f7-79e0-4152-9484-313bc1bc7c8e"), null, "Building blocks", new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e") },
                    { new Guid("d42b6286-c37e-4da4-bd30-e683f928fc9e"), null, "Building items", new Guid("a024ae33-18bf-408b-9890-203b6f6b6bbb") },
                    { new Guid("d564e1ec-449c-4018-9f2d-6a0951914e51"), null, "Tricycle", new Guid("294e3b78-1af4-4cfe-981d-aa0be38663dc") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("0948ee37-29a1-47d5-93d9-acad00f1878d"), 5.0, new Guid("4e7c8859-4634-4507-a8d1-4756e6c2d05f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("17d1a96a-a7ce-4085-9d54-ea1d0d1dd1fd"), 5.0, new Guid("8708f0ba-5615-437b-9370-f76291200529"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("2bcc31af-7c49-4bd0-b371-9ddc9f85a22b"), 3.5, new Guid("0405a4b3-e872-45dc-b948-9dd537d06344"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("57600373-9189-4776-a042-a6dfb0b31302"), 5.0, new Guid("cd9e62f7-79e0-4152-9484-313bc1bc7c8e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("909f5e59-b53a-4482-bf21-aa8e4b51debf"), 5.0, new Guid("4e7c8859-4634-4507-a8d1-4756e6c2d05f"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("a21254fe-cf05-4f80-8c3a-8bede69f4aeb"), 4.9000000000000004, new Guid("cd9e62f7-79e0-4152-9484-313bc1bc7c8e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("c3c03bcc-3a87-49ec-8ed0-9862138f2d68"), 4.7999999999999998, new Guid("cd9e62f7-79e0-4152-9484-313bc1bc7c8e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("e69437e8-bff0-4727-8b65-7a2fad315392"), 5.0, new Guid("d42b6286-c37e-4da4-bd30-e683f928fc9e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("ffee3b34-9bcd-4421-9815-e48667386e7e"), 5.0, new Guid("3dcdd466-8fd9-4c2f-8feb-03f30e3bd75e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SharedCartUser_UsersId",
                table: "SharedCartUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SharedCartUser");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1a867759-ad43-4698-8952-3b78ae7d05ee"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3c00317d-08d7-46e4-81a7-23d0fc890d5b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3c8042ac-0560-4cab-8783-eb82a38902b8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a9f849c-6459-471e-8f96-a36faf695e39"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5431d757-10c0-4441-b892-f877cdd43c15"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("84fe4fa4-91b9-4fe0-aa3d-df2f181031cc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("89748580-5029-45fe-9ccc-aa55b8ed6a5a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d564e1ec-449c-4018-9f2d-6a0951914e51"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0948ee37-29a1-47d5-93d9-acad00f1878d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("17d1a96a-a7ce-4085-9d54-ea1d0d1dd1fd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2bcc31af-7c49-4bd0-b371-9ddc9f85a22b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("57600373-9189-4776-a042-a6dfb0b31302"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d12565a-b399-484f-a2f0-b5270d6d0b04"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("909f5e59-b53a-4482-bf21-aa8e4b51debf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a21254fe-cf05-4f80-8c3a-8bede69f4aeb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c3c03bcc-3a87-49ec-8ed0-9862138f2d68"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e69437e8-bff0-4727-8b65-7a2fad315392"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffee3b34-9bcd-4421-9815-e48667386e7e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0405a4b3-e872-45dc-b948-9dd537d06344"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("294e3b78-1af4-4cfe-981d-aa0be38663dc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3dcdd466-8fd9-4c2f-8feb-03f30e3bd75e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("42b0d963-bb4a-40f0-9301-70eadebf9825"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4e7c8859-4634-4507-a8d1-4756e6c2d05f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8708f0ba-5615-437b-9370-f76291200529"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cd9e62f7-79e0-4152-9484-313bc1bc7c8e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d42b6286-c37e-4da4-bd30-e683f928fc9e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0695ba7e-fdb3-4b3f-8950-c21e8e51dd2e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a024ae33-18bf-408b-9890-203b6f6b6bbb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cd0ad358-b04c-4991-8fbb-bf04443db747"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d6e31512-caef-4021-a0eb-d36af2319e06"));

            migrationBuilder.AddColumn<Guid>(
                name: "SharedCartId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SharedCart_SharedCartId",
                table: "AspNetUsers",
                column: "SharedCartId",
                principalTable: "SharedCart",
                principalColumn: "Id");
        }
    }
}
