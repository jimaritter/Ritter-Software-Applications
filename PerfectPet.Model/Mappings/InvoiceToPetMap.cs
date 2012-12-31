using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
{
    public class InvoiceToPetMap : ClassMap<InvoiceToPet>
    {
        public InvoiceToPetMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            References(x => x.Invoice);
            References(x => x.Pet);
        }
    }
}
