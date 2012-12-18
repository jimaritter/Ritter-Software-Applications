using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Sales;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class LineItemMap : ClassMap<LineItem>
    {
        public LineItemMap()
        {
            Not.LazyLoad();
            Id(x => x.Id).GeneratedBy.HiLo("1001");
            Map(x => x.LineNumber);
            Map(x => x.Description);
            Map(x => x.Quantity);
            Map(x => x.UnitPrice);
            Map(x => x.Tax);
            References(x => x.Product);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
