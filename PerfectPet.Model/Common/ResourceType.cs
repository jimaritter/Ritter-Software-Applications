using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum ResourceType
    {
        [Description("Cat Enclosure")]
        Cat,
        [Description("Small Enclosure")]
        SmallEnclosure,
        [Description("Medium Enclosure")]
        MediumEnclosure,
        [Description("Large Enclosure")]
        LargeEnclosure,
        [Description("Small Run")]
        SmallRun,
        [Description("Medium Run")]
        MediumRun,
        [Description("Large Run")]
        LargeRun,
        [Description("Meeting")]
        Meeting,
        [Description("Out of Office")]
        OutOfOffice
    }
}
