using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Category)
                .WithMany();

            builder.HasData(
                SeedData.Product1,
                SeedData.Product2,
                SeedData.Product3,
                SeedData.Product4,
                SeedData.Product5,
                SeedData.Product6,
                SeedData.Product7,
                SeedData.Product8,
                SeedData.Product9,
                SeedData.Product10);
        }
    }
}
