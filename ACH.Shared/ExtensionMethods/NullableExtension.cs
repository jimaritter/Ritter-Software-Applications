#region Using Statements

using System;
using ACH.Shared.Enums;

#endregion

namespace ACH.Shared.ExtensionMethods
{
    public static class NullableExtension
    {
        #region Class Methods

        /// <summary>
        /// Conditionally returns thee string representation short date or string.Empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToConditionalShortDate(this DateTime? input)
        {
            return input.HasValue ? input.Value.ToShortDateString() : string.Empty;
        }

        /// <summary>
        /// Conditionally returns the string representation of the value or string.Empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToConditionalString(this Decimal? input)
        {
            return input.HasValue ? input.Value.ToString() : string.Empty;
        }

        /// <summary>
        /// Conditionally returns the string representation of the value or string.Empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string ToConditionalString(this int? input)
        {
            return input.HasValue ? input.Value.ToString() : string.Empty;
        }

        /// <summary>
        /// Conditionally returns the string representation of the value with applied format or string.Empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        public static string ToConditionalStringFormat(this DateTime? input, string format)
        {
            return input.HasValue ? input.Value.ToString(format) : string.Empty;
        }

        /// <summary>
        /// Conditionally returns a boolean representation the ConfirmationType enum
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>True if input is "Yes", False if input is "No" and null for all other cases.</returns>
        public static bool? AsAffirmative(this string input)
        {
            var ct = EnumerationParser.Parse<ConfirmationType?>(input);

            return ct.HasValue ? (bool?)(ct.Value == ConfirmationType.Yes) : null;
        }

        #endregion
    }
}