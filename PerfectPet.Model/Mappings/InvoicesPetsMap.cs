using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
{
    public class InvoicesPetsMap : ClassMap<InvoicesPets>
    {
        public InvoicesPetsMap()
        {
            Not.LazyLoad();
            Table("InvoicesPets");
            Id(c => c.InvoicesPetsId).GeneratedBy.HiLo("1001");
            References(x => x.Invoice)
               .Not.Nullable()
               .Cascade.SaveUpdate()
               .Column("InvoiceId");
            References(x => x.Pet)
                .Not.Nullable()
                .Cascade.SaveUpdate()
                .Column("PetId");
      
        }
    }
}
