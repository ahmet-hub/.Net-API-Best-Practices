using Northwind.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.Core.Repositories
{
    public interface IProductRepository:IEntityRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);

    }
}
