using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class AppointmentsMap : ClassMap<Appointments>
    {
        public AppointmentsMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Start);
            Map(x => x.EndDate);
            Map(x => x.Summary);
            Map(x => x.Description);
            Map(x => x.Location);
            Map(x => x.RecurrenceRule);
            Map(x => x.BackgroundId);
            Map(x => x.MasterEventId);
            Map(x => x.Visible);
            References(x => x.Resource);


        }
    }
}
