#region Using Statements

using System;
using System.ComponentModel;

#endregion

namespace ValidationFramework.Enums
{
    [Serializable]
    public enum MessageSeverity
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")] Null = 0,
        Informational,
        Warning,
        Error
    }
}