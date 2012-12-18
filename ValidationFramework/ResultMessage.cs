using System;
using System.Diagnostics;
using ValidationFramework.Enums;

namespace ValidationFramework
{
    [Serializable]
    [DebuggerDisplay("Severity = {Severity}, Message = {Message}")]
    public class ResultMessage
    {
        #region Instance Properties

        public string Message { get; set; }
        public MessageSeverity Severity { get; set; }

        #endregion
    }
}