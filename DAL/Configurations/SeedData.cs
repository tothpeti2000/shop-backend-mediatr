using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public static class SeedData
    {
        public static Category Category1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Toy"
        };

        public static Category Category2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Play house",
            ImgUrl = "https://i.picsum.photos/id/450/1000/1000.jpg?hmac=Owfb_XGQV9jOBL2HnKL5bvMvlA4V6XtKLSW0JVQZx-M"
        };

        public static Category Category3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Baby toy",
            ParentCategoryId = Category1.Id
        };

        public static Category Category4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Construction toy",
            ParentCategoryId = Category1.Id
        };

        public static Category Category5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Wooden toy",
            ParentCategoryId = Category1.Id
        };

        public static Category Category6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Plush figure",
            ParentCategoryId = Category1.Id
        };

        public static Category Category7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Bicycles",
            ParentCategoryId = Category1.Id
        };

        public static Category Category8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Months 0-6",
            ParentCategoryId = Category3.Id,
            ImgUrl = "https://i.picsum.photos/id/385/1000/1000.jpg?hmac=RPOWB-zg2EA9rKylAZiYRlOMwcOyTADrTqU6r3iFL3w"
        };

        public static Category Category9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Months 6-18",
            ParentCategoryId = Category3.Id
        };

        public static Category Category10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Months 18-24",
            ParentCategoryId = Category3.Id
        };

        public static Category Category11 = new()
        {
            Id = Guid.NewGuid(),
            Name = "DUPLO",
            ParentCategoryId = Category4.Id
        };

        public static Category Category12 = new()
        {
            Id = Guid.NewGuid(),
            Name = "LEGO",
            ParentCategoryId = Category4.Id
        };

        public static Category Category13 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Building items",
            ParentCategoryId = Category4.Id
        };

        public static Category Category14 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Building blocks",
            ParentCategoryId = Category5.Id,
            ImgUrl = "https://i.picsum.photos/id/299/1000/1000.jpg?hmac=DRpkgVaALpt0f0Y4kSTUOtLJ66_ULgUDZn2n6pbuafA"
        };

        public static Category Category15 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Toys for skill development",
            ParentCategoryId = Category5.Id
        };

        public static Category Category16 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Logic toys",
            ParentCategoryId = Category5.Id
        };

        public static Category Category17 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Craftwork toys",
            ParentCategoryId = Category5.Id
        };

        public static Category Category18 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Baby taxis",
            ParentCategoryId = Category7.Id
        };

        public static Category Category19 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Motors",
            ParentCategoryId = Category7.Id
        };

        public static Category Category20 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Tricycle",
            ParentCategoryId = Category7.Id
        };


        public static Product Product1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Activity playgim",
            Price = 18.75,
            Stock = 21,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category8.Id,
            ImgUrl = "https://i.picsum.photos/id/327/1000/1000.jpg?hmac=Th1XeWH2ua76frL7a8K82YuaROT3uSk3f_o5LO_3row"
        };

        public static Product Product2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Colorful baby book",
            Price = 4.35,
            Stock = 58,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category8.Id,
            ImgUrl = "https://i.picsum.photos/id/235/1000/1000.jpg?hmac=Of5tErj6Ycj_VJNGohIzGzzs37NpCUEllDPDtClgUrU"
        };

        public static Product Product3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Baby telephone",
            Price = 9.3,
            Stock = 18,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category9.Id,
            ImgUrl = "https://i.picsum.photos/id/29/1000/1000.jpg?hmac=zM2FTvPtz6CXt1Bzr_J98LjswsUrmf-3Pu9qUo6hFQ0"
        };

        public static Product Product4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Fisher Price hammer toy",
            Price = 20.9,
            Stock = 58,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category10.Id,
            ImgUrl = "https://i.picsum.photos/id/8/1000/1000.jpg?hmac=Q5oihxGkEUjwyAhaqO9C5cx1rtTqQNJOppecSfAsAc0"
        };

        public static Product Product5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Mega Blocks 24 pcs",
            Price = 10.8,
            Stock = 47,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category14.Id,
            ImgUrl = "https://i.picsum.photos/id/278/1000/1000.jpg?hmac=8BLH_ePU2_RxgsOzMddCiD72NHSMt7U9T9U6NFycNjY"
        };

        public static Product Product6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Maxi Blocks 56 pcs",
            Price = 4.65,
            Stock = 36,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 4.8,
            CategoryId = Category14.Id,
            ImgUrl = "https://i.picsum.photos/id/28/1000/1000.jpg?hmac=MOxf3493-WAfg36txWAkIAlj2qJY_RXm36atJaccRZc"
        };

        public static Product Product7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Building Blocks 80 pcs",
            Price = 10.9,
            Stock = 25,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 4.9,
            CategoryId = Category14.Id,
            ImgUrl = "https://i.picsum.photos/id/214/1000/1000.jpg?hmac=PYFsJHb1io7myR36YsXzd5zuUbjksBoazPvQrjX-n5E"
        };

        public static Product Product8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Lego City harbour",
            Price = 68.9,
            Stock = 12,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category13.Id,
            ImgUrl = "https://i.picsum.photos/id/74/1000/1000.jpg?hmac=qyw_GbDDT5ax1EE8yALr-sc0E7PyJyLByU4xUdyfRHA"
        };

        public static Product Product9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Lego Duplo Excavator",
            Price = 16,
            Stock = 26,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 3.5,
            CategoryId = Category11.Id,
            ImgUrl = "https://i.picsum.photos/id/93/1000/1000.jpg?hmac=sF1Aco6Mg-JGRiATFCB08Kx1hNkERckjuRnEuphU1Sw"
        };

        public static Product Product10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Child supervision for 1 hour",
            Price = 2,
            Stock = 0,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla ac nisl tortor. Nulla consectetur pellentesque sagittis. Nulla sed condimentum tortor, eu vehicula erat. Etiam non pellentesque nisl, at porta orci. Pellentesque porttitor venenatis molestie. Cras sit amet nunc vitae quam vestibulum ornare. Vestibulum viverra erat ac leo rhoncus ullamcorper. Praesent volutpat lacus eu magna congue congue. Nullam faucibus at risus ut accumsan. Vivamus nec vulputate enim. Maecenas dapibus eu elit vel sollicitudin. Morbi non feugiat lacus. Curabitur sit amet luctus diam. Mauris aliquam porta massa, tristique venenatis nibh viverra sed. Mauris pharetra vulputate quam, id lacinia sapien imperdiet quis.\r\n\r\nNunc in ex convallis, pellentesque nisi eget, laoreet dui. Aenean velit sem, tristique quis porttitor sit amet, bibendum et enim. Aliquam erat volutpat. Donec finibus ligula a ex pharetra pulvinar. Etiam et urna id quam euismod maximus. Proin congue est quis dolor dictum tempus. Aenean in arcu nulla.\r\n\r\nProin bibendum metus sed lorem commodo, vel rutrum orci egestas. Vivamus venenatis tellus vitae interdum hendrerit. Nam accumsan, nisl at sollicitudin blandit, eros elit sollicitudin turpis, et pulvinar tellus felis vel elit. Quisque vestibulum eros sit amet vestibulum scelerisque. Vestibulum finibus diam felis, a vulputate metus molestie non. Duis in pellentesque ex. Etiam.",
            AverageRating = 5,
            CategoryId = Category2.Id,
            ImgUrl = "https://i.picsum.photos/id/10/1000/1000.jpg?hmac=8imXWM_Cxe6_cWjyUbT2Vh7oxwiz12HfzJHp6CLoGwM"
        };
    }
}
