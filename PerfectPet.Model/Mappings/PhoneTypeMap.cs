using FluentNHibernate.Mapping;
using PerfectPet.Model.Phones;

namespace PerfectPet.Model.Mappings
{
    public class PhoneTypeMap : ClassMap<PhoneType>
    {
        public PhoneTypeMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.CreatedDate);
        }
    }
}
