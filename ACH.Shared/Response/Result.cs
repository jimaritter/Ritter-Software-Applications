#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;
using ACH.Shared.Enums;
using ACH.Shared.ExtensionMethods;

#endregion

namespace ACH.Shared.Response
{
    [Serializable]
    public class Result
    {
        #region C'tors

        public Result()
        {
            Messages = new List<ResultMessage>();
        }

        #endregion

        #region Instance Properties

        public List<ResultMessage> Messages { get; internal set; }

        public bool Success
        {
            get { return Messages.FirstOrDefault(msg => msg.Severity == MessageSeverity.Error) == null; }
        }

        #endregion

        #region Instance Methods

        /// <summary>
        /// Adds the error. 
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        public Result AddError(string errorMessage)
        {
            Messages.Add(new ResultMessage {Message = errorMessage, Severity = MessageSeverity.Error});
            return this;
        }

        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="values">The values.</param>
        public Result AddErrorFormat(string errorMessage, params object[] values)
        {
            Messages.Add(new ResultMessage {Message = string.Format(errorMessage, values), Severity = MessageSeverity.Error});
            return this;
        }

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="informationalMessage">The informational message.</param>
        public Result AddMessage(string informationalMessage)
        {
            Messages.Add(new ResultMessage {Message = informationalMessage, Severity = MessageSeverity.Informational});
            return this;
        }

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <param name="informationalMessage">The informational message.</param>
        /// <param name="values">The values.</param>
        public Result AddMessageFormat(string informationalMessage, params object[] values)
        {
            Messages.Add(new ResultMessage {Message = string.Format(informationalMessage, values), Severity = MessageSeverity.Informational});
            return this;
        }

        /// <summary>
        /// Adds the warning. 
        /// </summary>
        /// <param name="warningMessage">The warning message.</param>
        public Result AddWarning(string warningMessage)
        {
            Messages.Add(new ResultMessage {Message = warningMessage, Severity = MessageSeverity.Warning});
            return this;
        }

        /// <summary>
        /// Adds the warning.
        /// </summary>
        /// <param name="warningMessage">The warning message.</param>
        /// <param name="values">The values.</param>
        public Result AddWarningFormat(string warningMessage, params object[] values)
        {
            Messages.Add(new ResultMessage {Message = string.Format(warningMessage, values), Severity = MessageSeverity.Warning});
            return this;
        }

        /// <summary>
        /// Appends the specified result. If result has no messages nothing is appended
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns></returns>
        public Result Append(Result result)
        {
            if (result.Messages.Count == 0) return this;

            Messages.AddRange(result.Messages);

            return this;
        }

        /// <summary>
        /// Sets the most recently added item as the first in the list
        /// </summary>
        /// <returns></returns>
        public Result AsFirst()
        {
            var msg = Messages.Last();
            Messages.Remove(msg);
            Messages.Insert(0, msg);

            return this;
        }

        #endregion

        #region Class Methods

        /// <summary>
        /// Executes the supplied action
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public static Result WrapException(Action action)
        {
            try
            {
                action();
                return new Result();
            }
            catch (Exception exception)
            {
                //Exceptions.Log(exception);
                return exception.ToResult();
            }
        }

        #endregion
    }
}