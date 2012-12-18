using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Workorders;

namespace PerfectPet.Model.Mappings
{
    public class WorkorderMap : ClassMap<Workorder>
    {
        public WorkorderMap()
        {
            Not.LazyLoad();
            Id(c => c.WorkorderId).GeneratedBy.HiLo("1001");
            References(x => x.Person);
            References(x => x.Address);
            HasMany(x => x.Pets);
            HasMany(x => x.Products);
            HasMany(x => x.Services);
        }
    }
}
