using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Models;
using NorthwindFramework.Core.Repositories;
using System.Threading.Tasks;

namespace NorthwindFramework.DataAccess.Repositories
{
    public class ProductRepository : EntityRepository<Product>, IProductRepository
    {
        private NorthwindContext _northwindContext { get => _context as NorthwindContext; }
        public ProductRepository(NorthwindContext context) : base(context)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _northwindContext.Products.Include(c => c.Category).FirstOrDefaultAsync(p=>p.Id==productId);
        }

      
    }
}
