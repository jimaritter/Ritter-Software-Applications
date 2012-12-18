using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class ArrivalMap : ClassMap<Arrival>
    {
        public ArrivalMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.ArriveDate);
            Map(x => x.CreatedDate);
            References(x => x.Pet);
        }
    }
}
