using Northwind.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.Core.Service
{
    public interface IProductService:IEntityService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
