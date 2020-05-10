using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.Service;
using NorthwindFramework.Core.UnitOfWork;
using NorthwindFramework.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.Service.Services
{
    public class CategoryService:Service<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IEntityRepository<Category> repository):
            base(unitOfWork,repository)
        {

        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductByIdAsync(categoryId);
        }
    }
}
