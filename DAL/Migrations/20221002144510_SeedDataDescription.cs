using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SeedDataDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("018e4bce-43d1-44d2-a08d-6cb428464847"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("38168820-cb65-4f7c-84a9-52c024b3a9a1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("388d892b-7661-4d72-94d4-7186a3e9157d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4d71052e-5ffb-4788-835f-d4d0294e2228"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("627bfd65-61d4-4bd5-99e5-f09e57fd9522"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("89f5e936-d70a-422f-abd4-941da618ecd4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f57325e4-de39-4d1d-84e9-3b5920bc11b1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f829b33f-f770-446c-87ce-29aaee86ef02"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("005e4dcd-4fac-4f26-8292-1d8acabd8550"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1e8497e8-2025-4204-bb5d-bd0d6ad13d16"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3733c8bd-bb40-440f-839c-d4e06049e160"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6256d78d-1a97-41e5-a92b-512b22e76feb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d31d511-cd30-44d5-8281-73ccb0782642"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("741a0b9f-62f2-4b36-95c1-9a3dab57f9d2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7c9078f9-bb42-4a2e-aac9-c4a28c01f1fa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7eacf084-e476-4677-a47f-ea648c907db0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c33b8fce-c0f4-47cf-8b07-44166b9d2722"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fbfbb1a9-3a15-4236-a7a0-02901ea3e9ff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0e86b7fb-0823-482c-b931-bbe8fbdf6731"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("14b9f3a3-9ecf-49a1-abe0-8b32e8deb102"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("53adfbff-f3b2-42b4-8295-19012a5a4291"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("73a8d0c6-9fee-471d-9953-94b61169ae45"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("88821c87-272e-4d69-87c2-57913442b120"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b2e9416d-807f-4a9c-8096-5659f0a49ea1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b3413e39-36ec-40dc-bfc8-a127e29b358a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b3729a7d-5626-48f7-b435-077f2761551e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("12297e15-f812-4d32-9a78-457441613538"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("29c58271-9b2f-401d-9dcc-7623c77200c6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ec94deeb-aa71-4e88-ad6e-01144e872dbc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("65960d1f-7d33-4ff0-9cf7-7f47c666b6b5"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("11236367-5a16-4051-95a5-6dc027faf2cf"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("644a1894-33c2-4605-b928-2df2aaeaeeb2"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0e0d8f5b-1da3-4bd8-b4d5-491660ea2736"), null, "Bicycles", new Guid("11236367-5a16-4051-95a5-6dc027faf2cf") },
                    { new Guid("4b99b7a6-d45f-43c0-b2fb-089facaf4ed2"), null, "Plush figure", new Guid("11236367-5a16-4051-95a5-6dc027faf2cf") },
                    { new Guid("52344f09-759c-4338-b71e-a2cddd553805"), null, "Wooden toy", new Guid("11236367-5a16-4051-95a5-6dc027faf2cf") },
                    { new Guid("cef5aea9-249a-4bf5-ae75-748908e772c4"), null, "Construction toy", new Guid("11236367-5a16-4051-95a5-6dc027faf2cf") },
                    { new Guid("eeb3ca4a-d486-4b32-9cb7-88539afbb82f"), null, "Baby toy", new Guid("11236367-5a16-4051-95a5-6dc027faf2cf") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("0961a8d7-1810-4e86-a683-f77a392793c9"), 5.0, new Guid("644a1894-33c2-4605-b928-2df2aaeaeeb2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 800.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("050b7fa5-0f29-4c89-ad12-057856895798"), null, "Months 0-6", new Guid("eeb3ca4a-d486-4b32-9cb7-88539afbb82f") },
                    { new Guid("2fce523d-8a1f-42e3-9e37-ea1f568fd546"), null, "Months 18-24", new Guid("eeb3ca4a-d486-4b32-9cb7-88539afbb82f") },
                    { new Guid("3ce256f8-fec3-4fe1-aaba-1db5bb9dfd74"), null, "Tricycle", new Guid("0e0d8f5b-1da3-4bd8-b4d5-491660ea2736") },
                    { new Guid("496c2f42-6987-4185-91de-671737c8892c"), null, "DUPLO", new Guid("cef5aea9-249a-4bf5-ae75-748908e772c4") },
                    { new Guid("5e024e02-755f-4a1b-b81a-21bbe068e85b"), null, "Baby taxis", new Guid("0e0d8f5b-1da3-4bd8-b4d5-491660ea2736") },
                    { new Guid("5ff2865f-7171-497c-ac43-c3cff465d794"), null, "Building items", new Guid("cef5aea9-249a-4bf5-ae75-748908e772c4") },
                    { new Guid("66bdb54c-9593-41cc-8537-e9738093d970"), null, "Toys for skill development", new Guid("52344f09-759c-4338-b71e-a2cddd553805") },
                    { new Guid("786b57c5-12d5-4127-bd61-4524283f7dd1"), null, "Logic toys", new Guid("52344f09-759c-4338-b71e-a2cddd553805") },
                    { new Guid("954d8ab0-6149-4745-b113-00ca2c8d3e26"), null, "LEGO", new Guid("cef5aea9-249a-4bf5-ae75-748908e772c4") },
                    { new Guid("9d89c455-c8b9-4376-a601-71110c2109d8"), null, "Building blocks", new Guid("52344f09-759c-4338-b71e-a2cddd553805") },
                    { new Guid("a8e61c23-4e7b-446d-9c24-1f28a6ec596f"), null, "Craftwork toys", new Guid("52344f09-759c-4338-b71e-a2cddd553805") },
                    { new Guid("d67538b0-84f9-46a7-8c7d-e14224852e6a"), null, "Months 6-18", new Guid("eeb3ca4a-d486-4b32-9cb7-88539afbb82f") },
                    { new Guid("dbca0f60-f0b3-47d1-9cae-63bdb9d0f6d1"), null, "Motors", new Guid("0e0d8f5b-1da3-4bd8-b4d5-491660ea2736") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("1590f512-0eee-470d-b470-90c7d9260471"), 5.0, new Guid("5ff2865f-7171-497c-ac43-c3cff465d794"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 27563.0, 12 },
                    { new Guid("24a526ad-6a6e-41de-8c84-f63f6e12dcf0"), 4.7999999999999998, new Guid("9d89c455-c8b9-4376-a601-71110c2109d8"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 1854.0, 36 },
                    { new Guid("2731f276-eb25-4ba9-ba11-e14d6d486aa4"), 3.5, new Guid("496c2f42-6987-4185-91de-671737c8892c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 6399.0, 26 },
                    { new Guid("5a291f97-407d-4623-99e8-fb33ee22022f"), 5.0, new Guid("050b7fa5-0f29-4c89-ad12-057856895798"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 7488.0, 21 },
                    { new Guid("6b6a07a6-ae3e-4bac-bb6f-02afa59a8ff4"), 4.9000000000000004, new Guid("9d89c455-c8b9-4376-a601-71110c2109d8"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 4362.0, 25 },
                    { new Guid("85d2e38e-0272-4341-a03a-a2dcecbfffb0"), 5.0, new Guid("9d89c455-c8b9-4376-a601-71110c2109d8"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 4325.0, 47 },
                    { new Guid("92df7615-5196-4585-bf87-2f3d1ae08932"), 5.0, new Guid("2fce523d-8a1f-42e3-9e37-ea1f568fd546"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 8356.0, 58 },
                    { new Guid("b56d4b60-baf8-4639-bfeb-5ff70af89958"), 5.0, new Guid("d67538b0-84f9-46a7-8c7d-e14224852e6a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 3725.0, 18 },
                    { new Guid("f00df13b-ed8a-43b8-8731-27a995ad2bd7"), 5.0, new Guid("050b7fa5-0f29-4c89-ad12-057856895798"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 1738.0, 58 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3ce256f8-fec3-4fe1-aaba-1db5bb9dfd74"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4b99b7a6-d45f-43c0-b2fb-089facaf4ed2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5e024e02-755f-4a1b-b81a-21bbe068e85b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("66bdb54c-9593-41cc-8537-e9738093d970"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("786b57c5-12d5-4127-bd61-4524283f7dd1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("954d8ab0-6149-4745-b113-00ca2c8d3e26"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a8e61c23-4e7b-446d-9c24-1f28a6ec596f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("dbca0f60-f0b3-47d1-9cae-63bdb9d0f6d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0961a8d7-1810-4e86-a683-f77a392793c9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1590f512-0eee-470d-b470-90c7d9260471"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("24a526ad-6a6e-41de-8c84-f63f6e12dcf0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2731f276-eb25-4ba9-ba11-e14d6d486aa4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5a291f97-407d-4623-99e8-fb33ee22022f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6b6a07a6-ae3e-4bac-bb6f-02afa59a8ff4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("85d2e38e-0272-4341-a03a-a2dcecbfffb0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92df7615-5196-4585-bf87-2f3d1ae08932"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b56d4b60-baf8-4639-bfeb-5ff70af89958"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f00df13b-ed8a-43b8-8731-27a995ad2bd7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("050b7fa5-0f29-4c89-ad12-057856895798"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0e0d8f5b-1da3-4bd8-b4d5-491660ea2736"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2fce523d-8a1f-42e3-9e37-ea1f568fd546"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("496c2f42-6987-4185-91de-671737c8892c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5ff2865f-7171-497c-ac43-c3cff465d794"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("644a1894-33c2-4605-b928-2df2aaeaeeb2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9d89c455-c8b9-4376-a601-71110c2109d8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d67538b0-84f9-46a7-8c7d-e14224852e6a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("52344f09-759c-4338-b71e-a2cddd553805"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cef5aea9-249a-4bf5-ae75-748908e772c4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("eeb3ca4a-d486-4b32-9cb7-88539afbb82f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("11236367-5a16-4051-95a5-6dc027faf2cf"));

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
        }
    }
}
