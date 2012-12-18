using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Addresses;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class AddressTypeMap : ClassMap<AddressType>
    {
        public AddressTypeMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.CreatedDate);             
        }
    }
}
