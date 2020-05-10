using Northwind.Entities.Models;
using NorthwindFramework.Entities.Abstract;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NorthwindFramework.Entities.Models
{
    public class Category:IEntity
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<Product> Products { get; set; }
        
    }
}
