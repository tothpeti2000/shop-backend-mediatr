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
    public class SharedOrderConfiguration : IEntityTypeConfiguration<SharedOrder>
    {
        public void Configure(EntityTypeBuilder<SharedOrder> builder)
        {
            builder.ToTable("SharedOrder");
            builder.HasKey(o => o.Id);
        }
    }
}
