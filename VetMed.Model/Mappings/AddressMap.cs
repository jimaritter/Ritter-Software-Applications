using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using VetMed.Model.Adresses;

namespace VetMed.Model.Mappings
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(x => x.Id);
            Map(x => x.Street)
               .Length(100)
               .Not.Nullable();
            Map(x => x.City)
               .Length(100)
               .Not.Nullable();
            Map(x => x.State)
               .Length(50)
               .Not.Nullable();
            Map(x => x.Country)
               .Length(100)
               .Not.Nullable();
            Map(x => x.AddedBy)
                .Length(15);
            Map(x => x.AddedDate)
                .Length(15);
            Map(x => x.ModifiedBy)
                .Length(15);
            Map(x => x.ModifiedDate)
                .Length(15);
            Map(x => x.AddedBy)
                .Length(15);
            References(x => x.AddressType);
        }
    }
}
