using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class SharedCartUserColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartUser_AspNetUsers_UsersId",
                table: "SharedCartUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartUser_SharedCart_SharedCartsId",
                table: "SharedCartUser");

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

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "SharedCartUser",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SharedCartsId",
                table: "SharedCartUser",
                newName: "SharedCartId");

            migrationBuilder.RenameIndex(
                name: "IX_SharedCartUser_UsersId",
                table: "SharedCartUser",
                newName: "IX_SharedCartUser_UserId");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("3891cd12-87a1-4b89-b796-695195e64b4a"), null, "Play house", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[] { new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf"), null, "Toy", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("2b4d917f-2e9a-42ed-b34b-0abd2c344187"), null, "Plush figure", new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf") },
                    { new Guid("4949404c-f84d-45ca-ac8c-6bc057ca396f"), null, "Bicycles", new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf") },
                    { new Guid("a3f25cf3-682b-4c76-a836-c74bd56955b3"), null, "Construction toy", new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf") },
                    { new Guid("ad208623-d50f-443e-9eae-8c3767cc3880"), null, "Wooden toy", new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf") },
                    { new Guid("f14ad72e-94f6-4d93-beca-6009328d595f"), null, "Baby toy", new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[] { new Guid("7211ec1b-3f1a-422d-b784-b704e075aa30"), 5.0, new Guid("3891cd12-87a1-4b89-b796-695195e64b4a"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Child supervision for 1 hour", 2.0, 0 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ImgUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("03a708d7-e39a-4381-a90c-bdf567d65e41"), null, "Craftwork toys", new Guid("ad208623-d50f-443e-9eae-8c3767cc3880") },
                    { new Guid("0bc37ace-0b74-4a21-bbe0-cdd49a930104"), null, "LEGO", new Guid("a3f25cf3-682b-4c76-a836-c74bd56955b3") },
                    { new Guid("1f834cbd-0a33-48a7-b68b-d871649155ce"), null, "Logic toys", new Guid("ad208623-d50f-443e-9eae-8c3767cc3880") },
                    { new Guid("23139a81-b713-4f9f-b393-4c48cef6a6d3"), null, "Building items", new Guid("a3f25cf3-682b-4c76-a836-c74bd56955b3") },
                    { new Guid("28bc0230-70a0-489c-80f0-42760ce7702b"), null, "DUPLO", new Guid("a3f25cf3-682b-4c76-a836-c74bd56955b3") },
                    { new Guid("292c22f7-c9f3-409f-9c4f-2dc9a7a244d4"), null, "Motors", new Guid("4949404c-f84d-45ca-ac8c-6bc057ca396f") },
                    { new Guid("51f38b0f-8d76-41c6-a1b5-623f99bea785"), null, "Tricycle", new Guid("4949404c-f84d-45ca-ac8c-6bc057ca396f") },
                    { new Guid("720512ff-ea17-4479-8011-9b65824d4c8d"), null, "Months 6-18", new Guid("f14ad72e-94f6-4d93-beca-6009328d595f") },
                    { new Guid("9b60687c-0808-4034-be0d-cc6900b131ed"), null, "Months 0-6", new Guid("f14ad72e-94f6-4d93-beca-6009328d595f") },
                    { new Guid("ab914465-9083-4742-a7e2-f5230ac51fc5"), null, "Building blocks", new Guid("ad208623-d50f-443e-9eae-8c3767cc3880") },
                    { new Guid("bd12144d-6b3d-47f0-81e0-0cec809b256d"), null, "Baby taxis", new Guid("4949404c-f84d-45ca-ac8c-6bc057ca396f") },
                    { new Guid("e8378a19-bd32-4ae8-87c1-36a72cd31be1"), null, "Toys for skill development", new Guid("ad208623-d50f-443e-9eae-8c3767cc3880") },
                    { new Guid("ed0e6101-8358-45d5-b723-fc759e6b0f67"), null, "Months 18-24", new Guid("f14ad72e-94f6-4d93-beca-6009328d595f") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AverageRating", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("2e1d7a8b-4763-4063-ba18-a15445736472"), 5.0, new Guid("720512ff-ea17-4479-8011-9b65824d4c8d"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Baby telephone", 9.3000000000000007, 18 },
                    { new Guid("84254591-65f7-4480-b288-bee9bd7e4cc4"), 5.0, new Guid("ab914465-9083-4742-a7e2-f5230ac51fc5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Mega Bloks 24 pcs", 10.800000000000001, 47 },
                    { new Guid("8684068d-3a47-452d-8dfb-3cac44b21809"), 4.9000000000000004, new Guid("ab914465-9083-4742-a7e2-f5230ac51fc5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Building Blocks 80 pcs", 10.9, 25 },
                    { new Guid("af7cb83d-52a0-41b8-a45e-de5d0f6bd4e6"), 5.0, new Guid("ed0e6101-8358-45d5-b723-fc759e6b0f67"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Fisher Price hammer toy", 20.899999999999999, 58 },
                    { new Guid("be9c2a4a-9efb-4f76-a486-6dfebd28dd5e"), 5.0, new Guid("23139a81-b713-4f9f-b393-4c48cef6a6d3"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego City harbour", 68.900000000000006, 12 },
                    { new Guid("c9dbb162-7c78-41d8-94cf-ff23e9c3aa35"), 5.0, new Guid("9b60687c-0808-4034-be0d-cc6900b131ed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Activity playgim", 18.75, 21 },
                    { new Guid("d1431401-4cb3-48af-af28-d9a407acf1b5"), 3.5, new Guid("28bc0230-70a0-489c-80f0-42760ce7702b"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Lego Duplo Excavator", 16.0, 26 },
                    { new Guid("d187d1f5-d14b-4440-8bd2-942313cf876c"), 4.7999999999999998, new Guid("ab914465-9083-4742-a7e2-f5230ac51fc5"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Maxi Blocks 56 pcs", 4.6500000000000004, 36 },
                    { new Guid("db26953b-dbd7-4da8-a43e-0d8481c39749"), 5.0, new Guid("9b60687c-0808-4034-be0d-cc6900b131ed"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.", null, "Colorful baby book", 4.3499999999999996, 58 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartUser_AspNetUsers_UserId",
                table: "SharedCartUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartUser_SharedCart_SharedCartId",
                table: "SharedCartUser",
                column: "SharedCartId",
                principalTable: "SharedCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartUser_AspNetUsers_UserId",
                table: "SharedCartUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SharedCartUser_SharedCart_SharedCartId",
                table: "SharedCartUser");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("03a708d7-e39a-4381-a90c-bdf567d65e41"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0bc37ace-0b74-4a21-bbe0-cdd49a930104"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1f834cbd-0a33-48a7-b68b-d871649155ce"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("292c22f7-c9f3-409f-9c4f-2dc9a7a244d4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b4d917f-2e9a-42ed-b34b-0abd2c344187"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("51f38b0f-8d76-41c6-a1b5-623f99bea785"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bd12144d-6b3d-47f0-81e0-0cec809b256d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("e8378a19-bd32-4ae8-87c1-36a72cd31be1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2e1d7a8b-4763-4063-ba18-a15445736472"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7211ec1b-3f1a-422d-b784-b704e075aa30"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84254591-65f7-4480-b288-bee9bd7e4cc4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8684068d-3a47-452d-8dfb-3cac44b21809"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("af7cb83d-52a0-41b8-a45e-de5d0f6bd4e6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("be9c2a4a-9efb-4f76-a486-6dfebd28dd5e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c9dbb162-7c78-41d8-94cf-ff23e9c3aa35"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d1431401-4cb3-48af-af28-d9a407acf1b5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d187d1f5-d14b-4440-8bd2-942313cf876c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("db26953b-dbd7-4da8-a43e-0d8481c39749"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("23139a81-b713-4f9f-b393-4c48cef6a6d3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("28bc0230-70a0-489c-80f0-42760ce7702b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3891cd12-87a1-4b89-b796-695195e64b4a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4949404c-f84d-45ca-ac8c-6bc057ca396f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("720512ff-ea17-4479-8011-9b65824d4c8d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9b60687c-0808-4034-be0d-cc6900b131ed"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ab914465-9083-4742-a7e2-f5230ac51fc5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ed0e6101-8358-45d5-b723-fc759e6b0f67"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3f25cf3-682b-4c76-a836-c74bd56955b3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ad208623-d50f-443e-9eae-8c3767cc3880"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f14ad72e-94f6-4d93-beca-6009328d595f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("d75576c3-4ecf-4f47-91d0-c4261ed5cbaf"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SharedCartUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "SharedCartId",
                table: "SharedCartUser",
                newName: "SharedCartsId");

            migrationBuilder.RenameIndex(
                name: "IX_SharedCartUser_UserId",
                table: "SharedCartUser",
                newName: "IX_SharedCartUser_UsersId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartUser_AspNetUsers_UsersId",
                table: "SharedCartUser",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SharedCartUser_SharedCart_SharedCartsId",
                table: "SharedCartUser",
                column: "SharedCartsId",
                principalTable: "SharedCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
