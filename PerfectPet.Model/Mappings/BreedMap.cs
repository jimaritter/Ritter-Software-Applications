using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;

namespace PerfectPet.Model.Mappings
{
    public class BreedMap : ClassMap<Breed>
    {
        public BreedMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.SpeciesId);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
