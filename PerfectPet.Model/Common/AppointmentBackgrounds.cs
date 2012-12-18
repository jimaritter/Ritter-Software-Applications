using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum AppointmentBackgrounds
    {
        None = 1,
        Important = 2,
        Business = 3,
        Personal = 4,
        Vacation = 5,
        MustAttend = 6,
        TravelRequired = 7,
        NeedsPreparation = 8,
        Birthday = 9,
        Anniversary = 10,
        PhoneCall = 11

    }
}
