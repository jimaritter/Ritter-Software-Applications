using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using VetMed.Model.Persons;

namespace VetMed.Model.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName)
               .Length(50)
               .Not.Nullable();
            Map(x => x.MiddleName)
                .Length(50);
            Map(x => x.LastName)
                .Length(50)
                .Not.Nullable();
            References(x => x.PersonType);
            HasMany(x => x.Addresses);
            HasMany(x => x.Phones);
            Map(x => x.Active)
                .Length(1)
                .Not.Nullable();
            Map(x => x.AddedBy)
                .Length(15);
            Map(x => x.AddedDate)
                .Length(20);
            Map(x => x.ModifiedBy)
                .Length(15);
            Map(x => x.ModifiedDate)
                .Length(20);  
        }
    }
}
