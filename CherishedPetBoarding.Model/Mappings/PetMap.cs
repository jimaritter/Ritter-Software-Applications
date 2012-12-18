using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Pets;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class PetMap : ClassMap<Pet>
    {
        public PetMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Age);
            Map(x => x.Color);
            Map(x => x.Medications);
            Map(x => x.Species);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            References(x => x.Person);
            References(x => x.Breed);
        }
    }
}
