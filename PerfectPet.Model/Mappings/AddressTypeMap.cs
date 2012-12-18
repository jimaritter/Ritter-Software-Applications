using FluentNHibernate.Mapping;
using PerfectPet.Model.Addresses;

namespace PerfectPet.Model.Mappings
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
