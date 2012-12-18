using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Pets;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
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
