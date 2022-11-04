using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedCartPasscode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("04139a6f-2332-4674-b30a-311146025400"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("042b3aad-840b-4f45-b005-99d7e7d62757"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("24700602-45dd-4dd5-8537-4fe32d9a347a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3e7bb3aa-aa45-482c-9a4c-575ba67748cf"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5c5bf633-7c51-4bb8-80e9-07e1a42e8b9c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9517b41e-b31b-41f2-8d85-73636373b1b3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e92a2400-fd6d-4c29-81fb-5ca23ca3dbab"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f91fa7e7-01d0-45d4-a664-480bf2f5a191"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2eb45e43-1179-4b23-97b5-8d92d394ebcf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("400e8674-0ab0-40b3-a6a3-81d36aa11420"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af51a65f-a4c2-4820-a981-a27082348d11"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af6f5c87-71f9-479d-abb4-a7712e1c10f7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c60ba20a-9a52-40b7-b69a-eea8c87c85d7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d95855be-5483-43b0-8033-d583d717b704"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e462bbc7-14ee-423b-b453-7fa62ef104b9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f36d0a56-4462-42aa-9727-48440c401243"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f4360516-d856-4f48-96e5-da89690e206e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f89ba57e-7fc0-44ca-8692-ae106738b369"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0bcf2dd4-13f6-4c1f-83a3-cd48247d0a81"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5fb6b38b-c7be-42bc-9e63-8219a7c7ae5e"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("63009118-1d90-4680-a8d2-c783350d2793"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("67c5b3ed-6b66-41fb-b2a4-9777e8b49610"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("86e6ca67-cba6-47f9-a033-84a8c0f428e7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c3449edc-7420-476d-a79a-82dca50028ac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c94eb95a-b826-4f7b-ae28-7e46cd6bcc0a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e631a76c-5852-4449-9376-8b540f7ecadb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5122c69e-cb54-4f7d-9326-69af1a887ee4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("5bf23d2f-5fe7-4475-9bb8-edf44e434afd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f"));

            migrationBuilder.AddColumn<string>(
                name: "Passcode",
                table: "SharedCart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("787f6360-0f23-4702-88c9-16ea9c86df72"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("4a0828fd-b6ee-4736-87f8-514529f90c4a"), null, "Baby toy", new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21") },
                    { new Guid("6b56fb6a-4839-48c8-adf6-e149a5e47d75"), null, "Plush figure", new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21") },
                    { new Guid("9bd1cdda-1863-4abe-8f31-3b0d9d5dde71"), null, "Construction toy", new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21") },
                    { new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014"), null, "Wooden toy", new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21") },
                    { new Guid("d28e897c-0b3d-4687-9b9e-59732d64d485"), null, "Bicycles", new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("8e6e0ed5-970d-4717-bbb1-4d1132734f3c"), 5.0, new Guid("787f6360-0f23-4702-88c9-16ea9c86df72"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("10e23abb-565f-4cf9-a0e7-34ae4422420d"), null, "Toys for skill development", new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014") },
                    { new Guid("2df8d222-2896-4170-85fd-049f3f5132ca"), null, "Motors", new Guid("d28e897c-0b3d-4687-9b9e-59732d64d485") },
                    { new Guid("55649fe1-d813-47ff-8153-54cde8fd45ab"), null, "Months 6-18", new Guid("4a0828fd-b6ee-4736-87f8-514529f90c4a") },
                    { new Guid("65072fc9-8a34-487b-9881-c9ea06256eed"), null, "Building blocks", new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014") },
                    { new Guid("72067225-7291-4723-a7bd-cffd63659d69"), null, "Months 0-6", new Guid("4a0828fd-b6ee-4736-87f8-514529f90c4a") },
                    { new Guid("73736bca-7644-4ee9-8468-14e632da548c"), null, "DUPLO", new Guid("9bd1cdda-1863-4abe-8f31-3b0d9d5dde71") },
                    { new Guid("8aab2149-ec36-4ec1-b90d-737e5f536fff"), null, "Building items", new Guid("9bd1cdda-1863-4abe-8f31-3b0d9d5dde71") },
                    { new Guid("ac486329-c4a3-46ae-b992-eeb8fecb4f52"), null, "Logic toys", new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014") },
                    { new Guid("b26c293e-0930-4a4b-bc67-5894f4c02da0"), null, "Craftwork toys", new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014") },
                    { new Guid("b3c1b119-65bd-4502-a743-e69f6db0e5f3"), null, "Tricycle", new Guid("d28e897c-0b3d-4687-9b9e-59732d64d485") },
                    { new Guid("ca6bfdcb-7e35-4b10-a482-9b3a46e4e0f8"), null, "LEGO", new Guid("9bd1cdda-1863-4abe-8f31-3b0d9d5dde71") },
                    { new Guid("de4ed3c6-a2b3-478d-9f2b-115fbe151efd"), null, "Months 18-24", new Guid("4a0828fd-b6ee-4736-87f8-514529f90c4a") },
                    { new Guid("e78b1ed7-36c1-4d9f-9d7c-0cc71ea5498a"), null, "Baby taxis", new Guid("d28e897c-0b3d-4687-9b9e-59732d64d485") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("1189eb93-b401-45fc-ab6c-1074ea669758"), 5.0, new Guid("72067225-7291-4723-a7bd-cffd63659d69"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("1398546b-c9f1-40a7-9897-d74c1274c96a"), 5.0, new Guid("55649fe1-d813-47ff-8153-54cde8fd45ab"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("1872ea14-ed04-457e-b701-6cf7b9eac0a8"), 5.0, new Guid("de4ed3c6-a2b3-478d-9f2b-115fbe151efd"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 },
                    { new Guid("423fb83a-4b8c-42ce-b339-743b32043d91"), 5.0, new Guid("72067225-7291-4723-a7bd-cffd63659d69"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("9b239bf4-9286-4908-9b9f-c33072757f96"), 4.9000000000000004, new Guid("65072fc9-8a34-487b-9881-c9ea06256eed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("a22e3c56-16e0-4383-8202-e754f2908b9d"), 5.0, new Guid("8aab2149-ec36-4ec1-b90d-737e5f536fff"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("ac2aa1d1-1598-4e43-8b25-0eb25e7f76e0"), 5.0, new Guid("65072fc9-8a34-487b-9881-c9ea06256eed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("ae29ac2b-9df1-4ec7-be14-bed57475b7d1"), 4.7999999999999998, new Guid("65072fc9-8a34-487b-9881-c9ea06256eed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("bc3e670d-ef8b-4ffc-84e1-9768fdb2606f"), 3.5, new Guid("73736bca-7644-4ee9-8468-14e632da548c"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("10e23abb-565f-4cf9-a0e7-34ae4422420d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2df8d222-2896-4170-85fd-049f3f5132ca"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6b56fb6a-4839-48c8-adf6-e149a5e47d75"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ac486329-c4a3-46ae-b992-eeb8fecb4f52"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b26c293e-0930-4a4b-bc67-5894f4c02da0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("b3c1b119-65bd-4502-a743-e69f6db0e5f3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ca6bfdcb-7e35-4b10-a482-9b3a46e4e0f8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e78b1ed7-36c1-4d9f-9d7c-0cc71ea5498a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1189eb93-b401-45fc-ab6c-1074ea669758"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1398546b-c9f1-40a7-9897-d74c1274c96a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1872ea14-ed04-457e-b701-6cf7b9eac0a8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("423fb83a-4b8c-42ce-b339-743b32043d91"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8e6e0ed5-970d-4717-bbb1-4d1132734f3c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9b239bf4-9286-4908-9b9f-c33072757f96"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a22e3c56-16e0-4383-8202-e754f2908b9d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ac2aa1d1-1598-4e43-8b25-0eb25e7f76e0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ae29ac2b-9df1-4ec7-be14-bed57475b7d1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bc3e670d-ef8b-4ffc-84e1-9768fdb2606f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("55649fe1-d813-47ff-8153-54cde8fd45ab"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("65072fc9-8a34-487b-9881-c9ea06256eed"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("72067225-7291-4723-a7bd-cffd63659d69"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("73736bca-7644-4ee9-8468-14e632da548c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("787f6360-0f23-4702-88c9-16ea9c86df72"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8aab2149-ec36-4ec1-b90d-737e5f536fff"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d28e897c-0b3d-4687-9b9e-59732d64d485"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("de4ed3c6-a2b3-478d-9f2b-115fbe151efd"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a0828fd-b6ee-4736-87f8-514529f90c4a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9bd1cdda-1863-4abe-8f31-3b0d9d5dde71"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c0a98065-5e9a-4a95-b0a8-6a5352842014"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9821ad6a-69d5-4795-b59d-ed1140bf2a21"));

            migrationBuilder.DropColumn(
                name: "Passcode",
                table: "SharedCart");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("63009118-1d90-4680-a8d2-c783350d2793"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("24700602-45dd-4dd5-8537-4fe32d9a347a"), null, "Plush figure", new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f") },
                    { new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8"), null, "Wooden toy", new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f") },
                    { new Guid("5122c69e-cb54-4f7d-9326-69af1a887ee4"), null, "Baby toy", new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f") },
                    { new Guid("5bf23d2f-5fe7-4475-9bb8-edf44e434afd"), null, "Construction toy", new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f") },
                    { new Guid("c3449edc-7420-476d-a79a-82dca50028ac"), null, "Bicycles", new Guid("120fc37c-2c81-4791-8c7f-96aec6ff4c0f") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("af51a65f-a4c2-4820-a981-a27082348d11"), 5.0, new Guid("63009118-1d90-4680-a8d2-c783350d2793"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("04139a6f-2332-4674-b30a-311146025400"), null, "Logic toys", new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8") },
                    { new Guid("042b3aad-840b-4f45-b005-99d7e7d62757"), null, "Tricycle", new Guid("c3449edc-7420-476d-a79a-82dca50028ac") },
                    { new Guid("0bcf2dd4-13f6-4c1f-83a3-cd48247d0a81"), null, "Months 6-18", new Guid("5122c69e-cb54-4f7d-9326-69af1a887ee4") },
                    { new Guid("3e7bb3aa-aa45-482c-9a4c-575ba67748cf"), null, "LEGO", new Guid("5bf23d2f-5fe7-4475-9bb8-edf44e434afd") },
                    { new Guid("5c5bf633-7c51-4bb8-80e9-07e1a42e8b9c"), null, "Motors", new Guid("c3449edc-7420-476d-a79a-82dca50028ac") },
                    { new Guid("5fb6b38b-c7be-42bc-9e63-8219a7c7ae5e"), null, "Months 18-24", new Guid("5122c69e-cb54-4f7d-9326-69af1a887ee4") },
                    { new Guid("67c5b3ed-6b66-41fb-b2a4-9777e8b49610"), null, "Building items", new Guid("5bf23d2f-5fe7-4475-9bb8-edf44e434afd") },
                    { new Guid("86e6ca67-cba6-47f9-a033-84a8c0f428e7"), null, "DUPLO", new Guid("5bf23d2f-5fe7-4475-9bb8-edf44e434afd") },
                    { new Guid("9517b41e-b31b-41f2-8d85-73636373b1b3"), null, "Craftwork toys", new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8") },
                    { new Guid("c94eb95a-b826-4f7b-ae28-7e46cd6bcc0a"), null, "Months 0-6", new Guid("5122c69e-cb54-4f7d-9326-69af1a887ee4") },
                    { new Guid("e631a76c-5852-4449-9376-8b540f7ecadb"), null, "Building blocks", new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8") },
                    { new Guid("e92a2400-fd6d-4c29-81fb-5ca23ca3dbab"), null, "Toys for skill development", new Guid("2a14cb4c-bc64-4986-ba87-6b7072554ed8") },
                    { new Guid("f91fa7e7-01d0-45d4-a664-480bf2f5a191"), null, "Baby taxis", new Guid("c3449edc-7420-476d-a79a-82dca50028ac") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("2eb45e43-1179-4b23-97b5-8d92d394ebcf"), 5.0, new Guid("e631a76c-5852-4449-9376-8b540f7ecadb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("400e8674-0ab0-40b3-a6a3-81d36aa11420"), 3.5, new Guid("86e6ca67-cba6-47f9-a033-84a8c0f428e7"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("af6f5c87-71f9-479d-abb4-a7712e1c10f7"), 5.0, new Guid("67c5b3ed-6b66-41fb-b2a4-9777e8b49610"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("c60ba20a-9a52-40b7-b69a-eea8c87c85d7"), 5.0, new Guid("c94eb95a-b826-4f7b-ae28-7e46cd6bcc0a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 },
                    { new Guid("d95855be-5483-43b0-8033-d583d717b704"), 5.0, new Guid("0bcf2dd4-13f6-4c1f-83a3-cd48247d0a81"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("e462bbc7-14ee-423b-b453-7fa62ef104b9"), 4.9000000000000004, new Guid("e631a76c-5852-4449-9376-8b540f7ecadb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("f36d0a56-4462-42aa-9727-48440c401243"), 4.7999999999999998, new Guid("e631a76c-5852-4449-9376-8b540f7ecadb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("f4360516-d856-4f48-96e5-da89690e206e"), 5.0, new Guid("c94eb95a-b826-4f7b-ae28-7e46cd6bcc0a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("f89ba57e-7fc0-44ca-8692-ae106738b369"), 5.0, new Guid("5fb6b38b-c7be-42bc-9e63-8219a7c7ae5e"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 }
                });
        }
    }
}
