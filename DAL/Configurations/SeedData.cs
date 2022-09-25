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
            Name = "Play house"
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
            ParentCategoryId = Category3.Id
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
            ParentCategoryId = Category5.Id
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
            Price = 7488,
            Stock = 21,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category8.Id
        };

        public static Product Product2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Colorful baby book",
            Price = 1738,
            Stock = 58,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category8.Id
        };

        public static Product Product3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Baby telephone",
            Price = 3725,
            Stock = 18,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category9.Id
        };

        public static Product Product4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Fisher Price hammer toy",
            Price = 8356,
            Stock = 58,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category10.Id
        };

        public static Product Product5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Mega Bloks 24 pcs",
            Price = 4325,
            Stock = 47,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category14.Id
        };

        public static Product Product6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Maxi Blocks 56 pcs",
            Price = 1854,
            Stock = 36,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category14.Id
        };

        public static Product Product7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Building Blocks 80 pcs",
            Price = 4362,
            Stock = 25,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category14.Id
        };

        public static Product Product8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Lego City harbour",
            Price = 27563,
            Stock = 12,
            Description = "Description for LEGO City Harbour",
            AverageRating = 5,
            CategoryId = Category13.Id
        };

        public static Product Product9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Lego Duplo Excavator",
            Price = 6399,
            Stock = 26,
            Description = "Description for LEGO Duplo Excavator",
            AverageRating = 5,
            CategoryId = Category11.Id
        };

        public static Product Product10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Child supervision for 1 hour",
            Price = 800,
            Stock = 0,
            Description = "Description",
            AverageRating = 5,
            CategoryId = Category2.Id
        };
    }
}
