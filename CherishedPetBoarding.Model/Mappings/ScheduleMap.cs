using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Schedules;
using FluentNHibernate.Mapping;

namespace CherishedPetBoarding.Model.Mappings
{
    public class ScheduleMap : ClassMap<Schedule>
    {
        public ScheduleMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.Description).Not.Nullable();
            References(x => x.Pet).Not.Nullable();
            References(x => x.Person).Not.Nullable();
            Map(x => x.ScheduleType);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);           
        }

    }
}
