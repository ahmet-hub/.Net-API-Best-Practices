using System;
using System.Collections.Generic;
using System.Text;
using NorthwindFramework.Entities.Abstract;

namespace NorthwindFramework.Entities.Models
{
    public  class Person:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
