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
    public class SharedCartConfiguration: IEntityTypeConfiguration<SharedCart>
    {
        public void Configure(EntityTypeBuilder<SharedCart> builder)
        {
            builder.ToTable("SharedCart");
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Users)
                .WithMany(u => u.SharedCarts)
                .UsingEntity<Dictionary<string, object>>(
                    "SharedCartUser",
                    c => c.HasOne<User>()
                            .WithMany()
                            .HasForeignKey("UserId"),
                    u => u.HasOne<SharedCart>()
                            .WithMany()
                            .HasForeignKey("SharedCartId"));
        }
    }
}
