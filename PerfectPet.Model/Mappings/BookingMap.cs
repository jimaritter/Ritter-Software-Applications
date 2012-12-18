using FluentNHibernate.Mapping;
using PerfectPet.Model.Bookings;

namespace PerfectPet.Model.Mappings
{
    public class BookingMap : ClassMap<Booking>
    {
        public BookingMap()
        {
            Not.LazyLoad();
            Id(c => c.Id).GeneratedBy.HiLo("1001");
            Map(x => x.NumberOfDays);
            Map(x => x.Location);
            Map(x => x.Summary);
            Map(x => x.Description).Not.Nullable();
            HasMany(x => x.Pet);
            References(x => x.Person).Not.Nullable();
            HasMany(x => x.Kennels);
            Map(x => x.ScheduleType);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);  
            Map(x => x.BackgroundId);
            Map(x => x.StatusId);
            Map(x => x.RecurrenceId);
            Map(x => x.ResourceId);
        }

    }
}
