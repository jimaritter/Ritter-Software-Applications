using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherishedPetBoarding.Model.Schedules
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
