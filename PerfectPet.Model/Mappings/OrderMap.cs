using FluentNHibernate.Mapping;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
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
