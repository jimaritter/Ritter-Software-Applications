using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum AddressTypeList
    {
        [Description("Home")]
        Home = 1,
        [Description("Shipping")]
        Shipping = 2,
        [Description("Billing")]
        Billing = 3,
        [Description("Work")]
        Work = 4,
        [Description("Main Offce")]
        MainOffice = 5
    }
}
