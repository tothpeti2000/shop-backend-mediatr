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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.ParentCategory)
                .WithMany();

            builder.HasData(
                SeedData.Category1,
                SeedData.Category2,
                SeedData.Category3,
                SeedData.Category4,
                SeedData.Category5,
                SeedData.Category6,
                SeedData.Category7,
                SeedData.Category8,
                SeedData.Category9,
                SeedData.Category10,
                SeedData.Category11,
                SeedData.Category12,
                SeedData.Category13,
                SeedData.Category14,
                SeedData.Category15,
                SeedData.Category16,
                SeedData.Category17,
                SeedData.Category18,
                SeedData.Category19,
                SeedData.Category20);
        }
    }
}
