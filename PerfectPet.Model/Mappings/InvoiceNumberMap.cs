using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
{
    public class InvoiceNumberMap : ClassMap<InvoiceNumber>
    {
        public InvoiceNumberMap()
        {
            Not.LazyLoad();
            Id(x => x.Id);
            Map(x => x.Number);
        }
    }
}
