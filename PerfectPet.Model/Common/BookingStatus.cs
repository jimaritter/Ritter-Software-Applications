using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    public enum BookingStatus
    {
        [EnumDescription("Cancelled")]
        Cancelled,
        [EnumDescription("Customer Checked In")]
        Checkin,
        [EnumDescription("Customer Checked Out")]
        Checkout,
        [EnumDescription("Customer No Show")]
        Noshow,
        [EnumDescription("Future Booking")]
        Future
    }
}
