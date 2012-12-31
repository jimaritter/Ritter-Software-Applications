using FluentNHibernate.Mapping;
using PerfectPet.Model.Inventories;

namespace PerfectPet.Model.Mappings
{
    public class InventoryMap : ClassMap<Inventory>
    {
        public InventoryMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Number);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Description).Length(500);
            Map(x => x.Cost);
            Map(x => x.Retail);
            Map(x => x.TaxExempt);
            Map(x => x.Active);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
