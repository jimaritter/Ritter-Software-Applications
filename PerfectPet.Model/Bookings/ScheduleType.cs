using System;
using System.ComponentModel;

namespace PerfectPet.Model.Bookings
{
    [Serializable]
    public enum ScheduleType
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        [Description("Boarding")]
        Boarding,
        [Description("Grooming")]
        Grooming,
        [Description("Sitting")]
        Sitting
    }
}
