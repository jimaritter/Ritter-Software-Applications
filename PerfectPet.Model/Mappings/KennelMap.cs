using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Kennels;

namespace PerfectPet.Model.Mappings
{
    public class KennelMap : ClassMap<Kennel>
    {
        public KennelMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Size);
            Map(x => x.Available);
            Map(x => x.CreatedDate);             
        }
    }
}
