using Northwind.Entities.Models;
using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.Service;
using NorthwindFramework.Core.UnitOfWork;
using System;
using System.Threading.Tasks;

namespace NorthwindFramework.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IEntityRepository<Product> repository) :
           base(unitOfWork, repository)
        {

        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
