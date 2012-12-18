using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum PetSize
    {
        [Description("Extra Large")]
        XLarge,
        [Description("Large")]
        Large,
        [Description("Medium")]
        Medium,
        [Description("Small")]
        Small,
        [Description("Toy")]
        Toy
    }
}
