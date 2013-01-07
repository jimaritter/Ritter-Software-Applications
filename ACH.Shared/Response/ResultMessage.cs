using System;
using System.Diagnostics;
using ACH.Shared.Enums;

namespace ACH.Shared.Response
{
    [Serializable]
    [DebuggerDisplay("Severity = {Severity}, Message = {Message}, Exception = {Exception}")]
    public class ResultMessage
    {
        #region Instance Properties

        public string Message { get; set; }
        public MessageSeverity Severity { get; set; }
        public Exception Exception { get; set; }

        #endregion
    }
}