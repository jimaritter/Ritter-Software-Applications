using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPet.Model.Common
{
    [Serializable]
    public enum PhoneTypeList
    {
        [Description("Home")]
        Home,
        [Description("Cell")]
        Cell,
        [Description("Fax")]
        Fax,
        [Description("Work")]
        Work,
        [Description("Main")]
        Main
    }
}
