using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Addresses;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Active);
            Map(x => x.Type).Not.Nullable();
            Map(x => x.Street).Not.Nullable();
            Map(x => x.City).Not.Nullable();
            Map(x => x.StateId).Not.Nullable();
            Map(x => x.Zip).Not.Nullable();
            References(x => x.Person);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
