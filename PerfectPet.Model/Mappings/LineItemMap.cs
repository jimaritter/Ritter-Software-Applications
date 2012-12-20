using FluentNHibernate.Mapping;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
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
            Map(x => x.LineTotal);
            References(x => x.Product);
            References(x => x.Service);
            References(x => x.Invoice);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
