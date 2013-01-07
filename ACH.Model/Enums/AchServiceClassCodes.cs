#region Using Statements

using System;
using System.ComponentModel;

#endregion

namespace ACH.Model.Enums
{
    [Serializable]
    public enum AchServiceClassCodes
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        [Description("Mixed Debits and Credits")]
        MixedDebitsAndCredits = 200,
        [Description("Credits Only")]
        CreditsOnly = 220,
        [Description("Debits Only")]
        DebitsOnly = 225
    }
}