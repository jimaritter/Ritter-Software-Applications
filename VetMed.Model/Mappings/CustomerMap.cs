using FluentNHibernate.Mapping;
using VetMed.Model.Customers;

namespace VetMed.Model.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public void CusomerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name)
               .Length(75)
               .Not.Nullable();
            Map(x => x.Active)
               .Length(1)
               .Not.Nullable();
            HasMany(x => x.Addresses);
            HasMany(x => x.Emails);
            HasMany(x => x.Phones);
            Map(x => x.AddedBy)
                .Length(15);
            Map(x => x.AddedDate)
                .Length(20);
            Map(x => x.ModifiedBy)
                .Length(15);
            Map(x => x.ModifiedDate)
                .Length(20);             
        }
    }
}
