using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum TaskStatus
    {
        [Description("Open")]
        Open,
        [Description("Pending")]
        Pending,
        [Description("Canceled")]
        Canceled,
        [Description("Closed")]
        Closed
    }
}
