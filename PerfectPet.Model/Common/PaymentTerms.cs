using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum PaymentTerms
    {
        [Description("Due Upon Receipt")]
        DueUponReceipt = 1,
        [Description("Net 15 Days")]
        Net15 = 2,
        [Description("Net 30 Days")]
        Net30 = 3
    }
}
