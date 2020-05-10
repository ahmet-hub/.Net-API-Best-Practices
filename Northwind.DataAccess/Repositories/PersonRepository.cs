using System;
using System.Collections.Generic;
using System.Text;
using NorthwindFramework.Core.Repositories;
using NorthwindFramework.Entities.Models;

namespace NorthwindFramework.DataAccess.Repositories
{
    public class PersonRepository : EntityRepository<Person>, IPersonRepository
    {
        private NorthwindContext _northwindContext { get => _context as NorthwindContext; }
        public PersonRepository(NorthwindContext context) : base(context)
        {

        }

    }
}
