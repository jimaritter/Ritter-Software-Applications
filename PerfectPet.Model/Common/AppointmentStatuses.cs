using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum AppointmentStatuses
    {
        Free = 1,
        Busy = 2,
        Unavailable = 3,
        Tentative = 4
    }
}
