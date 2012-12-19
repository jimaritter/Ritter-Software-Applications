using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;

namespace PerfectPet.Model.Mappings
{
    public class PetStatusMap : ClassMap<PetStatus>
    {
        public PetStatusMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1000");
            References(x => x.Person);
            References(x => x.Pet);
            References(x => x.Status);
            Map(x => x.AddedDate);
        }
    }
}
