using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherishedPetBoarding.Model.Users
{
    [Serializable]
    public enum Role
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        [Description("User")]
        User,
        [Description("Administrator")]
        Administrator,
        [Description("None")]
        None
    }
}
