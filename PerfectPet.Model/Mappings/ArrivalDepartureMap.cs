using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class ArrivalDepartureMap : ClassMap<ArrivalDeparture>
    {
        public ArrivalDepartureMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Notes);
            Map(x => x.ArriveDate);
            Map(x => x.DepartureDate);
            Map(x => x.ArriveTime);
            Map(x => x.DepartureTime);
            Map(x => x.CheckedIn);
            Map(x => x.CheckedOut);
            References(x => x.Resources);
            Map(x => x.CreatedDate);
            References(x => x.Pet);
        }
    }
}
