using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class ResourcesMap : ClassMap<Resources>
    {
        public ResourcesMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Image).CustomSqlType("varbinary").Length(2147483647);
            Map(x => x.Visible);
            Map(x => x.Size);
            Map(x => x.Description);
        }
    }
}
