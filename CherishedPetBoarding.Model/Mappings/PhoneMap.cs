using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Phones;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
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
        }
    }
}
