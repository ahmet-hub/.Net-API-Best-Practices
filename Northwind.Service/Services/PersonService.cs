using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Core.Service;
using NorthwindFramework.Core.UnitOfWork;
using NorthwindFramework.Entities.Models;

namespace NorthwindFramework.Service.Services
{
    public class PersonService:Service<Person>,IPersonService
    {
        public PersonService(IUnitOfWork unitOfWork, IEntityRepository<Person> repository) :
            base(unitOfWork, repository)
        {

        }
    }
}
