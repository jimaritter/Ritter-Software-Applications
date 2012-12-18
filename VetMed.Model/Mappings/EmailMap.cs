using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using VetMed.Model.Emails;

namespace VetMed.Model.Mappings
{
    public class EmailMap : ClassMap<Email>
    {
        public EmailMap()
        {
            Id(x => x.Id);
            Map(x => x.Address)
               .Length(75)
               .Not.Nullable();
            Map(x => x.Active)
               .Length(1)
               .Not.Nullable();
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
