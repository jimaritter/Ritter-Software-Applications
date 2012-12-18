using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Sales;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class InvoiceMap : ClassMap<Invoice>
    {
        public InvoiceMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Number).Not.Nullable();
            Map(x => x.Description);
            Map(x => x.InvoiceDate);
            Map(x => x.DeliveryDate);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            References(x => x.OriginAddress);
            References(x => x.DestinationAddress);
            References(x => x.Person);
            HasMany(x => x.LineItems);
        } 
    }
}
