#region Using Statements

using System;
using System.Diagnostics;

#endregion

namespace CherishedPetBoarding.Model.Common
{
    [Serializable]
    [DebuggerDisplay("Code = {Code}, Value = {Value}")]
    public class CodeValuePair
    {
        #region Instance Properties

        public string Code { get; set; }
        public string Value { get; set; }

        #endregion
    }
}