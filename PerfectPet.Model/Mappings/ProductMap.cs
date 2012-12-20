using FluentNHibernate.Mapping;
using PerfectPet.Model.Products;

namespace PerfectPet.Model.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.ProductNumber);
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
