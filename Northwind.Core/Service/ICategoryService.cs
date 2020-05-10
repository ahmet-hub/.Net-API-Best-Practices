using NorthwindFramework.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.Core.Service
{
    public interface ICategoryService:IEntityService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
