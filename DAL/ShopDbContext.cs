using DAL.Configurations;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopDbContext: IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SharedCart> SharedCarts { get; set; }
        public DbSet<SharedCartItem> SharedCartItems { get; set; }
        public DbSet<SharedOrder> SharedOrders { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CartItemConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new SharedCartItemConfiguration());
            modelBuilder.ApplyConfiguration(new SharedCartConfiguration());
            modelBuilder.ApplyConfiguration(new SharedOrderConfiguration());
        }
    }
}
