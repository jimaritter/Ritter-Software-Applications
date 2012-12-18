using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.MiddleName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.Active);
            Map(x => x.Type).Not.Nullable();
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            HasMany(x => x.Addresses);
            HasMany(x => x.Pets);
            HasMany(x => x.Phones);

        }
    }
}
