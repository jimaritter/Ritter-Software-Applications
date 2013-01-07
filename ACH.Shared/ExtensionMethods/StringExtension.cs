#region Using Statements

using System;
using System.Globalization;
using System.Linq;

#endregion

namespace ACH.Shared.ExtensionMethods
{
    public static class StringExtension
    {
        #region Class Methods

        /// <summary>
        /// Joins the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="join">The join.</param>
        /// <returns></returns>
        public static string Append(this string input, string join)
        {
            return string.Join(string.Empty, input, join);
        }

        /// <summary>
        /// Joins the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="join">The join.</param>
        /// <returns></returns>
        public static string Append(this string input, params string[] join)
        {
            return input.Append(string.Join(string.Empty, join));
        }

        /// <summary>
        /// Converts the string as an boolean.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A boolean or null if it failed conversion</returns>
        public static bool? AsBool(this string input)
        {
            bool num;

            return bool.TryParse(input.TrimSafe(), out num) ? (bool?) num : null;
        }

        /// <summary>
        /// Converts the string as adate time.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A DateTime or null if it failed conversion</returns>
        public static DateTime? AsDateTime(this string input)
        {
            DateTime date;

            return DateTime.TryParse(input.TrimSafe(), out date) ? (DateTime?) date : null;
        }

        /// <summary>
        /// Converts the string as a Decimal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A Decimal or null if it failed conversion</returns>
        public static Decimal? AsDecimal(this string input)
        {
            if (input.IsNullEmptyOrWhitespace())
                return null;

            string data = input.Replace('$', ' ').Replace('%', ' ').Trim();

            Decimal num;

            return Decimal.TryParse(data, out num) ? (Decimal?) num : null;
        }

        /// <summary>
        /// Converts the string as a Guid.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>A Guid or null if it failed conversion</returns>
        public static Guid? AsGuid(this string input)
        {
            try
            {
                return new Guid(input);
            }
            catch (FormatException)
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the string as an int.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>An int or null if it failed conversion</returns>
        public static int? AsInt(this string input)
        {
            if (input.IsNullEmptyOrWhitespace())
                return null;

            string data = input.Replace('$', ' ').Replace('%', ' ').Trim();

            int num;

            return int.TryParse(data, out num) ? (int?) num : null;
        }

        /// <summary>
        /// Returns the numeric literals out of a string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string AsNumeric(this string input)
        {
            //    var matches = Regex.Matches(input, @"[0-9]+", RegexOptions.Compiled);

            //    return String.Join(string.Empty, matches.Cast<Match>().Select(x => x.Value).ToArray());
            return new string(input.Where(Char.IsDigit).ToArray());
        }

        /// <summary>
        /// Gets the value or default.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static string GetValueOrDefault(this string input, string defaultValue = null)
        {
            return string.IsNullOrEmpty(input) ? (defaultValue ?? string.Empty) : input;
        }

        /// <summary>
        /// Determines whether [is null empty or whitespace] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// 	<c>true</c> if [is null empty or whitespace] [the specified input]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullEmptyOrWhitespace(this string input)
        {
            return (string.IsNullOrEmpty(input) || string.Empty.Equals(input.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Determines whether [is null or empty] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// 	<c>true</c> if [is null or empty] [the specified input]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Parses the enumeration.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static TEnum ParseEnumeration<TEnum>(this string input)
        {
            return EnumerationParser.Parse<TEnum>(input);
        }

        /// <summary>
        /// Splits the camel case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>  
        /// Source from David M Morton MVP, Moderator on social.msdn.com.
        /// http://social.msdn.microsoft.com/Forums/en-US/csharpgeneral/thread/791963c8-9e20-4e9e-b184-f0e592b943b0
        public static string SplitCamelCase(this string input)
        {
            int i = 0;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                string.Join(string.Empty,
                            input.Select(c => new
                                                  {
                                                      Character = c.ToString(),
                                                      Start = i++ == 0
                                                              || (Char.IsUpper(input[i - 1])
                                                                  && (!Char.IsUpper(input[i - 2])
                                                                      || (i < input.Length && !Char.IsUpper(input[i]))))
                                                  })
                                .Select(x => x.Start ? " " + x.Character : x.Character)
                                .ToArray()))
                .Trim();
        }

        /// <summary>
        /// Returns string.Trim without a risk of null reference exception
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static string TrimSafe(this string input)
        {
            return input == null ? input : input.Trim();
        }

        #endregion
    }
}