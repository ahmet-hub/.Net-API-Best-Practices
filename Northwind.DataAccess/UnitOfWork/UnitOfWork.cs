using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.UnitOfWork;
using NorthwindFramework.DataAccess.Repositories;
using System.Threading.Tasks;

namespace NorthwindFramework.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _northwindContext;

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private PersonRepository _personRepository;
        public IProductRepository Products => _productRepository ??= new ProductRepository(_northwindContext);

        public ICategoryRepository Categories => _categoryRepository ??= new CategoryRepository(_northwindContext);

        public IPersonRepository Persons => _personRepository ??= new PersonRepository(_northwindContext);

        public UnitOfWork(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public void Commit()
        {
            _northwindContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _northwindContext.SaveChangesAsync();
        }
    }
}
