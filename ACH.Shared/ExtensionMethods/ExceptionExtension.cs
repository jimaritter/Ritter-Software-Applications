#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;
using ACH.Shared.Enums;
using ACH.Shared.Response;

#endregion

namespace ACH.Shared.ExtensionMethods
{
    public static class ExceptionExtension
    {
        #region Class Methods

        /// <summary>
        /// Converts an exception to a Result Message collection.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        public static Result ToResult(this Exception exception)
        {
            var result = new Result {Messages = FlattenError(exception).ToList()};
            return result;
        }

        private static IEnumerable<ResultMessage> FlattenError(Exception exception)
        {
            if(exception == null) throw new ArgumentException("exception");

            var currentException = exception;

            do
            {
                yield return new ResultMessage {Message = exception.Message, Severity = MessageSeverity.Error, Exception = currentException};
                currentException = currentException.InnerException;
            } while (currentException != null);
        }

        #endregion
    }
}