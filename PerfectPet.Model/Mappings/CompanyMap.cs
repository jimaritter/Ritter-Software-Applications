using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Companies;

namespace PerfectPet.Model.Mappings
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.CompanyName);
            Map(x => x.Description).Length(500);
            Map(x => x.TaxNumber);
            Map(x => x.Street);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Phone);
            Map(x => x.Cell);
            Map(x => x.Fax);
            Map(x => x.Web);
            Map(x => x.Email);
            Map(x => x.TaxRate);
            Map(x => x.Logo).CustomSqlType("varbinary").Length(2147483647);
            HasMany(x => x.Employees);
        }
    }
}
