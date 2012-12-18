using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum PersonTypeList
    {
        [Description("Customer")]
        Customer = 1,
        [Description("Employee")]
        Employee = 2,
        [Description("Sales")]
        Sales = 3,
        [Description("Vendor")]
        Vendor = 4,
        [Description("Manager")]
        Manager = 5
    }
}
