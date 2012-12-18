using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Sales;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            References(x => x.Invoice);
        }
    }
}
