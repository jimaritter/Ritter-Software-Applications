#region Using Statements

using System;
using System.ComponentModel;

#endregion

namespace ACH.Shared.Enums
{
    [Serializable]
    public enum DisplayType
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")] Null = 0,

        Visible,
        Hidden,
    }
}