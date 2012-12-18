using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class DepartureMap : ClassMap<Departure>
    {
        public DepartureMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.ArriveDate);
            References(x => x.Pet);
            Map(x => x.CreatedDate);            
        }
    }
}
