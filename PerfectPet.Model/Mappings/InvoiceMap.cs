﻿using FluentNHibernate.Mapping;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Sales;

namespace PerfectPet.Model.Mappings
{
    public class InvoiceMap : ClassMap<Invoice>
    {
        public InvoiceMap()
        {
            Not.LazyLoad();
            Id(x => x.InvoiceId).GeneratedBy.HiLo("1001");
            Map(x => x.Number).Not.Nullable();
            Map(x => x.Description);
            Map(x => x.InvoiceDate);
            Map(x => x.DeliveryDate);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            Map(x => x.Voided);
            Map(x => x.VoidReason);
            References(x => x.InvoiceAddress);
            References(x => x.Company);
            References(x => x.Person);
            References(x => x.Phone);
            HasMany(x => x.LineItems);
            HasManyToMany(x => x.Pets)
                .Table("InvoicesToPets")
                .ParentKeyColumn("InvoiceId")
                .ChildKeyColumn("PetId")
                .Cascade.All().LazyLoad();

        } 
    }
}