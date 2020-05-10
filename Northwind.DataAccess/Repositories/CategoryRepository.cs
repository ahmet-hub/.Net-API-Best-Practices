using Microsoft.EntityFrameworkCore;
using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Entities.Models;
using System.Threading.Tasks;

namespace NorthwindFramework.DataAccess.Repositories
{
    public class CategoryRepository : EntityRepository<Category>, ICategoryRepository
    {
        private NorthwindContext _northwindContext { get => _context as NorthwindContext; }
        public CategoryRepository(NorthwindContext context) : base(context)
        {

        }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            var category= await _northwindContext.Categories.Include(x => x.Products)
                .SingleOrDefaultAsync(x => x.Id == categoryId);
            return category;
        }
    }
}
