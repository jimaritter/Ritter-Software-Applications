using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;

namespace PerfectPet.Model.Mappings
{
    public class StatusMap : ClassMap<Status>
    {
        public StatusMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1000");
            Map(x => x.Title).Not.Nullable();            
        }
    }
}
