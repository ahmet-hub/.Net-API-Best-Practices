using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindFramework.Entities.Models;

namespace NorthwindFramework.DataAccess.Seeds
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private readonly int[] _ids;
        public PersonSeed(int[] ids)
        {
            _ids = ids;

        }
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person {Id = _ids[0], Name = "Ahmet", LastName = "Yardımcı"});
            ;
            builder.HasData(new Person {Id = _ids[1], Name = "Samet", LastName = "Yardımcı"});
        }
    }
}
