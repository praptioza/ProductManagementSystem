//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Models;
namespace ProductManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Set decimal precision for CostPrice
            modelBuilder.Entity<Product>()
                .Property(p => p.CostPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductNo = 1, ProductName = "Man Shirts", CostPrice = 220, Qty = 10 },
                new Product { ProductNo = 2, ProductName = "Women Tops", CostPrice = 450, Qty = 20 }
            );
        }


        // DbSet for the Product entity
        public DbSet<Product> Products { get; set; }

    }
}


