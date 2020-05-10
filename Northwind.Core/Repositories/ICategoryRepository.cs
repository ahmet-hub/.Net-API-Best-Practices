using NorthwindFramework.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.Core.Repositories
{
    public interface ICategoryRepository:IEntityRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }

    
}
