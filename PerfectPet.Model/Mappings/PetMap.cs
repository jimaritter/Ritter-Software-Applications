using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
{
    public class PetMap : ClassMap<Pet>
    {
        public PetMap()
        {
            Not.LazyLoad();
            Id(c => c.PetId).GeneratedBy.HiLo("1001");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Age);
            Map(x => x.Color);
            Map(x => x.Size);
            Map(x => x.Weight);
            Map(x => x.Diet);
            Map(x => x.Temperment);
            HasMany(x => x.Medications);
            Map(x => x.Species);
            Map(x => x.Notes);
            Map(x => x.Biter);
            Map(x => x.MixedBreed);
            Map(x => x.Vaccintated);
            Map(x => x.Deceased);
            Map(x => x.Picture).CustomSqlType("varbinary").Length(2147483647);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            HasMany(x => x.Workorder);
            HasMany(x => x.Products);
            HasMany(x => x.Services);
            References(x => x.Person);
            Map(x => x.Breed);
            HasManyToMany(x => x.Invoices)
                .Table("InvoicesToPets")
                .ParentKeyColumn("PetId")
                .ChildKeyColumn("InvoiceId")
                .Cascade.All().Inverse().FetchType.Join();
            //HasMany(x => x.InvoicesPets)
            //.Cascade.AllDeleteOrphan()
            //.Fetch.Join()
            //.Inverse().KeyColumn("PetId");

        }
    }
}
