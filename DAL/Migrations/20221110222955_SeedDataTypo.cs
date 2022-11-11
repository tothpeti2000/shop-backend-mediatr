using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SeedDataTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0edd57d8-be79-4970-8866-eb8a6e59cf89"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("18b22798-0897-4301-8ccb-26dee6cc8741"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1ef1cdbe-b68b-4e28-a630-ecf982b83f34"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7bee82ba-8a4f-4b57-b260-e69ae9595634"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8c30fb55-8a7f-4c08-9204-550dd85e8621"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d40e41a3-7a8d-4264-8db8-c86f747909e4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("eb5cec4e-171d-4545-81fd-2c666193be5b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ece458f7-0332-42ee-9cc7-a82cbbd06d1a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("56906e3f-942b-4b65-9b07-253311ef8590"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("57f40c7a-acde-4d3e-9a13-ff0e34548d69"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("73cf75bd-aef7-4076-b85a-343d0a3d08c1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8e9d1038-0641-4907-a27f-3a969bbe62ac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("95e4f544-c916-4c0e-a416-317f2018f8fb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae0ca76d-4ee1-44c6-b653-8926a270b9fd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b081291d-a9e3-41bc-8bfd-84366f45304e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b2c9d298-cd74-4ce0-9fae-987185992f49"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b86d021d-8531-4f11-97bf-b00adfd861ba"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e4fcc656-ee4f-4826-b80b-099b0c32ae0c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("05bef6dd-a1c6-4f0f-9573-3e58cc0fb855"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0d357bcf-3a52-48f9-9dbd-7e56ff065ad0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("16ff2194-a5b0-4825-be7f-c119aa83c310"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a2fcd9c-8a01-40aa-8f2c-86d78c13ffe7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("42737dcd-1961-412f-b073-dbfa7efb2b79"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("855b640b-4435-4989-addf-7e8f24f41191"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("89df110f-6a78-43a5-a43e-8065dde8ad24"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ebc4c755-9eec-47e4-b62d-04b15b6667aa"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("99fa142b-8b4a-4ec9-808c-59120c382966"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b53a82a5-65cc-45bd-8c35-aded733d5905"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("95452e88-5962-4d21-bf1f-1a0671b72361"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("9f5aa70c-7fa3-4b35-ae15-0f7e2ae852f5"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("2da01f9c-bdc9-47ee-8b21-0efb06ebccc5"), null, "Bicycles", new Guid("95452e88-5962-4d21-bf1f-1a0671b72361") },
                    { new Guid("3405565f-4778-49fd-9051-439b3f6b46e2"), null, "Baby toy", new Guid("95452e88-5962-4d21-bf1f-1a0671b72361") },
                    { new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f"), null, "Wooden toy", new Guid("95452e88-5962-4d21-bf1f-1a0671b72361") },
                    { new Guid("76e6a7cf-f353-4568-9dd0-34c35e13fbf6"), null, "Plush figure", new Guid("95452e88-5962-4d21-bf1f-1a0671b72361") },
                    { new Guid("b572e2c4-b586-477f-b1b2-ba3301cdba41"), null, "Construction toy", new Guid("95452e88-5962-4d21-bf1f-1a0671b72361") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("023d2275-a6ab-41b1-9cdf-9a2cd69cdbed"), 5.0, new Guid("9f5aa70c-7fa3-4b35-ae15-0f7e2ae852f5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("176f23eb-42ae-4d66-b0a2-814683f2ff09"), null, "Craftwork toys", new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f") },
                    { new Guid("1a24db6a-b4e7-49c8-98a8-2a46f83126a0"), null, "Logic toys", new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f") },
                    { new Guid("24a66282-44fc-4285-ab84-503add4def7a"), null, "Months 18-24", new Guid("3405565f-4778-49fd-9051-439b3f6b46e2") },
                    { new Guid("2e23c327-1e04-443d-bf84-a5999cf2796c"), null, "Months 6-18", new Guid("3405565f-4778-49fd-9051-439b3f6b46e2") },
                    { new Guid("6a430922-1cb2-4be1-9b5b-6e7dae9a94e9"), null, "Building blocks", new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f") },
                    { new Guid("7c8825b1-f41d-4be8-8d18-4271c911d06a"), null, "Toys for skill development", new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f") },
                    { new Guid("81960bbb-7a58-4662-bb82-ef133e3718b7"), null, "Motors", new Guid("2da01f9c-bdc9-47ee-8b21-0efb06ebccc5") },
                    { new Guid("87dda168-63ec-4fb0-8534-022ab84f2e83"), null, "Months 0-6", new Guid("3405565f-4778-49fd-9051-439b3f6b46e2") },
                    { new Guid("9791cf18-dcfa-4f3a-90b7-811dd0bd3a53"), null, "DUPLO", new Guid("b572e2c4-b586-477f-b1b2-ba3301cdba41") },
                    { new Guid("99bde60c-b27e-47d1-84b2-c04f9f8061dc"), null, "Baby taxis", new Guid("2da01f9c-bdc9-47ee-8b21-0efb06ebccc5") },
                    { new Guid("b881349a-06a9-415f-a6e0-3ea5402d3122"), null, "LEGO", new Guid("b572e2c4-b586-477f-b1b2-ba3301cdba41") },
                    { new Guid("c4fc0b8c-8863-4d35-ac11-4496c86e1a46"), null, "Tricycle", new Guid("2da01f9c-bdc9-47ee-8b21-0efb06ebccc5") },
                    { new Guid("d23b0d9e-598d-4c25-adfc-ebc0dea17b30"), null, "Building items", new Guid("b572e2c4-b586-477f-b1b2-ba3301cdba41") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("3c37acfd-59c6-4a3e-bbb5-0873af1460a9"), 5.0, new Guid("6a430922-1cb2-4be1-9b5b-6e7dae9a94e9"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Blocks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("7547294a-5a51-4adc-9338-72048068dbe1"), 5.0, new Guid("87dda168-63ec-4fb0-8534-022ab84f2e83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("80c4b6d9-6403-4d8f-804c-94381b87d694"), 3.5, new Guid("9791cf18-dcfa-4f3a-90b7-811dd0bd3a53"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("8af59033-c1bd-49cd-801c-762a0c084298"), 5.0, new Guid("d23b0d9e-598d-4c25-adfc-ebc0dea17b30"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("92a445d0-7d7d-4302-a1fa-5cd2434527f0"), 4.7999999999999998, new Guid("6a430922-1cb2-4be1-9b5b-6e7dae9a94e9"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("9e01413e-02f2-416f-848d-3aa5afe67b0b"), 5.0, new Guid("2e23c327-1e04-443d-bf84-a5999cf2796c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("c081b5a8-84a0-420b-9b4f-b31bb00cbf37"), 5.0, new Guid("87dda168-63ec-4fb0-8534-022ab84f2e83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("e8bdfa95-9d92-4758-95b6-2bfa5d47d061"), 4.9000000000000004, new Guid("6a430922-1cb2-4be1-9b5b-6e7dae9a94e9"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("f1cff739-8c59-4132-a03e-05d0ce14dcff"), 5.0, new Guid("24a66282-44fc-4285-ab84-503add4def7a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("176f23eb-42ae-4d66-b0a2-814683f2ff09"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1a24db6a-b4e7-49c8-98a8-2a46f83126a0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("76e6a7cf-f353-4568-9dd0-34c35e13fbf6"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7c8825b1-f41d-4be8-8d18-4271c911d06a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("81960bbb-7a58-4662-bb82-ef133e3718b7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("99bde60c-b27e-47d1-84b2-c04f9f8061dc"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b881349a-06a9-415f-a6e0-3ea5402d3122"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c4fc0b8c-8863-4d35-ac11-4496c86e1a46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("023d2275-a6ab-41b1-9cdf-9a2cd69cdbed"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3c37acfd-59c6-4a3e-bbb5-0873af1460a9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7547294a-5a51-4adc-9338-72048068dbe1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("80c4b6d9-6403-4d8f-804c-94381b87d694"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8af59033-c1bd-49cd-801c-762a0c084298"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("92a445d0-7d7d-4302-a1fa-5cd2434527f0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9e01413e-02f2-416f-848d-3aa5afe67b0b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c081b5a8-84a0-420b-9b4f-b31bb00cbf37"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e8bdfa95-9d92-4758-95b6-2bfa5d47d061"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f1cff739-8c59-4132-a03e-05d0ce14dcff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("24a66282-44fc-4285-ab84-503add4def7a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2da01f9c-bdc9-47ee-8b21-0efb06ebccc5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2e23c327-1e04-443d-bf84-a5999cf2796c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6a430922-1cb2-4be1-9b5b-6e7dae9a94e9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("87dda168-63ec-4fb0-8534-022ab84f2e83"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9791cf18-dcfa-4f3a-90b7-811dd0bd3a53"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9f5aa70c-7fa3-4b35-ae15-0f7e2ae852f5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d23b0d9e-598d-4c25-adfc-ebc0dea17b30"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3405565f-4778-49fd-9051-439b3f6b46e2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("595a18d8-f527-4a74-bbe4-dce0a134557f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b572e2c4-b586-477f-b1b2-ba3301cdba41"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("95452e88-5962-4d21-bf1f-1a0671b72361"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("ebc4c755-9eec-47e4-b62d-04b15b6667aa"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("0d357bcf-3a52-48f9-9dbd-7e56ff065ad0"), null, "Bicycles", new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8") },
                    { new Guid("18b22798-0897-4301-8ccb-26dee6cc8741"), null, "Plush figure", new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8") },
                    { new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1"), null, "Wooden toy", new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8") },
                    { new Guid("99fa142b-8b4a-4ec9-808c-59120c382966"), null, "Baby toy", new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8") },
                    { new Guid("b53a82a5-65cc-45bd-8c35-aded733d5905"), null, "Construction toy", new Guid("d3913b1e-a468-49ce-922f-91587b2ab5b8") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("b081291d-a9e3-41bc-8bfd-84366f45304e"), 5.0, new Guid("ebc4c755-9eec-47e4-b62d-04b15b6667aa"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("05bef6dd-a1c6-4f0f-9573-3e58cc0fb855"), null, "Months 6-18", new Guid("99fa142b-8b4a-4ec9-808c-59120c382966") },
                    { new Guid("0edd57d8-be79-4970-8866-eb8a6e59cf89"), null, "Motors", new Guid("0d357bcf-3a52-48f9-9dbd-7e56ff065ad0") },
                    { new Guid("16ff2194-a5b0-4825-be7f-c119aa83c310"), null, "Months 18-24", new Guid("99fa142b-8b4a-4ec9-808c-59120c382966") },
                    { new Guid("1ef1cdbe-b68b-4e28-a630-ecf982b83f34"), null, "Toys for skill development", new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1") },
                    { new Guid("3a2fcd9c-8a01-40aa-8f2c-86d78c13ffe7"), null, "Months 0-6", new Guid("99fa142b-8b4a-4ec9-808c-59120c382966") },
                    { new Guid("42737dcd-1961-412f-b073-dbfa7efb2b79"), null, "Building items", new Guid("b53a82a5-65cc-45bd-8c35-aded733d5905") },
                    { new Guid("7bee82ba-8a4f-4b57-b260-e69ae9595634"), null, "LEGO", new Guid("b53a82a5-65cc-45bd-8c35-aded733d5905") },
                    { new Guid("855b640b-4435-4989-addf-7e8f24f41191"), null, "Building blocks", new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1") },
                    { new Guid("89df110f-6a78-43a5-a43e-8065dde8ad24"), null, "DUPLO", new Guid("b53a82a5-65cc-45bd-8c35-aded733d5905") },
                    { new Guid("8c30fb55-8a7f-4c08-9204-550dd85e8621"), null, "Baby taxis", new Guid("0d357bcf-3a52-48f9-9dbd-7e56ff065ad0") },
                    { new Guid("d40e41a3-7a8d-4264-8db8-c86f747909e4"), null, "Logic toys", new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1") },
                    { new Guid("eb5cec4e-171d-4545-81fd-2c666193be5b"), null, "Craftwork toys", new Guid("462a0edf-0aa5-4ad4-af5d-f20b851a3ad1") },
                    { new Guid("ece458f7-0332-42ee-9cc7-a82cbbd06d1a"), null, "Tricycle", new Guid("0d357bcf-3a52-48f9-9dbd-7e56ff065ad0") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("56906e3f-942b-4b65-9b07-253311ef8590"), 3.5, new Guid("89df110f-6a78-43a5-a43e-8065dde8ad24"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("57f40c7a-acde-4d3e-9a13-ff0e34548d69"), 5.0, new Guid("3a2fcd9c-8a01-40aa-8f2c-86d78c13ffe7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("73cf75bd-aef7-4076-b85a-343d0a3d08c1"), 5.0, new Guid("3a2fcd9c-8a01-40aa-8f2c-86d78c13ffe7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("8e9d1038-0641-4907-a27f-3a969bbe62ac"), 5.0, new Guid("05bef6dd-a1c6-4f0f-9573-3e58cc0fb855"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("95e4f544-c916-4c0e-a416-317f2018f8fb"), 4.9000000000000004, new Guid("855b640b-4435-4989-addf-7e8f24f41191"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("ae0ca76d-4ee1-44c6-b653-8926a270b9fd"), 5.0, new Guid("42737dcd-1961-412f-b073-dbfa7efb2b79"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("b2c9d298-cd74-4ce0-9fae-987185992f49"), 5.0, new Guid("16ff2194-a5b0-4825-be7f-c119aa83c310"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 },
                    { new Guid("b86d021d-8531-4f11-97bf-b00adfd861ba"), 5.0, new Guid("855b640b-4435-4989-addf-7e8f24f41191"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("e4fcc656-ee4f-4826-b80b-099b0c32ae0c"), 4.7999999999999998, new Guid("855b640b-4435-4989-addf-7e8f24f41191"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 }
                });
        }
    }
}
