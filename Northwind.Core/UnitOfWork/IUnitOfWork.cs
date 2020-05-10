using NorthwindFramework.Core.Repositories;
using System.Threading.Tasks;

namespace NorthwindFramework.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository  Categories { get; }
        IPersonRepository Persons { get; }
        Task CommitAsync();
        void Commit();
    }
}
