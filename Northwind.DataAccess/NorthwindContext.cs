using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Models;
using NorthwindFramework.DataAccess.Configurations;
using NorthwindFramework.DataAccess.Seeds;
using NorthwindFramework.Entities.Models;

namespace NorthwindFramework.DataAccess
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new PersonSeed(new int[] { 1, 2 }));
        }
    }
}
