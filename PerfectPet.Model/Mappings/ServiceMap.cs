using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Services;

namespace PerfectPet.Model.Mappings
{
    public class ServiceMap : ClassMap<Service>
    {
        public ServiceMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Length(500);
            Map(x => x.Description);
            Map(x => x.Active);
            Map(x => x.Cost);
            Map(x => x.Retail);
            Map(x => x.TaxExempt);
            Map(x => x.CreatedDate);
        }
    }
}
