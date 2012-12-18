using FluentNHibernate.Mapping;
using PerfectPet.Model.Phones;

namespace PerfectPet.Model.Mappings
{
    public class PhoneMap : ClassMap<Phone>
    {
        public PhoneMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Number).Not.Nullable();
            Map(x => x.Type);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            References(x => x.Person);
        }
    }
}
