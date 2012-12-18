using FluentNHibernate.Mapping;
using PerfectPet.Model.People;

namespace PerfectPet.Model.Mappings
{
    public class PersonTypeMap : ClassMap<PersonType>
    {
        public PersonTypeMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.CreatedDate);            
        }
    }
}
