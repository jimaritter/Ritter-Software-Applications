using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum Salutation
    {
        [Description("Mr.")]
        Mr,
        [Description("Mrs.")]
        Mrs,
        [Description("Miss")]
        Miss,
        [Description("Dr.")]
        Dr,
        [Description("Rev.")]
        Rev

    }
}
