using FluentNHibernate.Mapping;
using PerfectPet.Model.People;

namespace PerfectPet.Model.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Number);
            Map(x => x.Salutation);
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.MiddleName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.Email);
            Map(x => x.Notes);
            Map(x => x.Active);
            Map(x => x.Type);
            Map(x => x.Discount);
            Map(x => x.Balance);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            HasMany(x => x.Addresses);
            HasMany(x => x.Pets);
            HasMany(x => x.Phones);

        }
    }
}
