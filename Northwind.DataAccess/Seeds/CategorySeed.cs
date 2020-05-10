using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindFramework.Entities.Models;


namespace NorthwindFramework.DataAccess.Seeds

{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;
        public CategorySeed(int[] ids)
        {
            _ids = ids;

        }


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id = _ids[0], Name = "Kalemler" });
            builder.HasData(new Category { Id = _ids[1], Name = "Defterler" });
        }
    }
}
