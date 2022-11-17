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
    public class SharedCartItemConfiguration: IEntityTypeConfiguration<SharedCartItem>
    {
        public void Configure(EntityTypeBuilder<SharedCartItem> builder)
        {
            builder.ToTable("SharedCartItem");
            builder.HasKey(ci => ci.Id);

            builder.HasOne(ci => ci.SharedCart)
                .WithMany(c => c.CartItems);

            builder.HasOne(ci => ci.Product)
                .WithMany();
        }
    }
}
