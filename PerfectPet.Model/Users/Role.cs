using System;
using System.ComponentModel;

namespace PerfectPet.Model.Users
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
