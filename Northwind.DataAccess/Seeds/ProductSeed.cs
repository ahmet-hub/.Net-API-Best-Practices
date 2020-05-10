using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Entities.Models;


namespace NorthwindFramework.DataAccess.Seeds
{
    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
            
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id = 1, Name = "Pilot Kalem", Price = 12.50m, Stock = 10, CategoryId = _ids[0] });
            builder.HasData(new Product { Id = 2, Name = "Kurşun Kalem", Price = 5.50m, Stock = 10, CategoryId = _ids[0] });
            builder.HasData(new Product { Id = 3, Name = "Tükenmez Kalem", Price = 15.50m, Stock = 10, CategoryId = _ids[0] });
            builder.HasData(new Product { Id = 4, Name = "Küçük Defter", Price = 15.50m, Stock = 10, CategoryId = _ids[1] });
            builder.HasData(new Product { Id = 5, Name = "Büyük Kalem", Price = 20.50m, Stock = 10, CategoryId = _ids[1] });


        }
    }
}
