using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Products;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Description);
            Map(x => x.UnitCost);
            Map(x => x.SalePrice);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
        }
    }
}
