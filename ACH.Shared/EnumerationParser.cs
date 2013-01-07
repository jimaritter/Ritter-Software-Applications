#region Using Statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ACH.Shared.ExtensionMethods;

#endregion

namespace ACH.Shared
{
    ///<summary>
    /// Handles operations for Enumerations
    ///</summary>
    public static class EnumerationParser
    {
        #region Class Methods

        /// <summary>
        /// Enumerates the enum as code value pairs for any type of T: Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertDefaultItem">if set to <c>true</c> [insert default item].</param>
        /// <param name="defaultItemText">The default item text.</param>
        /// <returns></returns>
        public static IEnumerable<CodeValuePair> EnumerateAsCodeValuePairs<T>(bool insertDefaultItem, string defaultItemText)
        {
            var type = typeof (T).ConcreteType();
            var names = Enum.GetNames(type);

            if (insertDefaultItem)
            {
                yield return new CodeValuePair {Code = defaultItemText, Value = string.Empty};
            }

            foreach (var name in names.Where(name => name != "Null"))
            {
                yield return new CodeValuePair {Code = ReadDescriptionFromText<T>(name), Value = name};
            }
        }

        /// <summary>
        /// Enumerates the enum as code value pairs for any type of T: Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<CodeValuePair> EnumerateAsCodeValuePairs<T>()
        {
            return EnumerateAsCodeValuePairs<T>(false, null);
        }

        /// <summary>
        /// Parses any string to the type of T: Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumText">The enum text.</param>
        /// <returns></returns>
        public static T Parse<T>(string enumText)
        {
            return Parse<T>(enumText, false);
        }


        /// <summary>
        /// Parses any string to the type of T: Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumText">The enum text.</param>
        /// <param name="ignoreCase">if set to <c>true</c> [ignore case].</param>
        /// <returns></returns>
        public static T Parse<T>(string enumText, bool ignoreCase)
        {
            if (enumText.IsNullEmptyOrWhitespace())
                if (typeof (T).IsNullable())
                    return default(T);
                else
                    throw new ArgumentException("enumText is required for non-nullable enum");

            var type = typeof (T).ConcreteType();

            return (T) Enum.Parse(type, enumText.Trim(), ignoreCase);
        }

        /// <summary>
        /// Parses the enum by description.
        /// </summary>
        /// <param name="descriptionValue">The description value.</param>
        /// <returns></returns>
        public static T ParseEnumByDescription<T>(string descriptionValue)
        {
            if (descriptionValue.IsNullEmptyOrWhitespace())
                if (typeof (T).IsNullable())
                    return default(T);
                else
                    throw new ArgumentException("descriptionValue is required for non-nullable enum");

            var type = typeof (T).ConcreteType();

            var names = Enum.GetNames(type).Select(textVal => Parse<T>(textVal));

            var parsedEnum = names.SingleOrDefault(enumMember => CompareEnumDescription(enumMember, descriptionValue));

            if (parsedEnum.IsDefault() && !typeof (T).IsNullable())
                throw new ArgumentException("The string is not a description or value of the specified enum.");

            return parsedEnum;
        }

        /// <summary>
        /// Reads the description attribute tag from an enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumMember">The enum member.</param>
        /// <returns></returns>
        public static string ReadDescription<T>(T enumMember)
        {
            if (typeof (T).IsNullable() && enumMember == null)
                return null;

            var type = (typeof (T).ConcreteType());

            var fi = type.GetField(enumMember.ToString());
            var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : enumMember.ToString();
        }


        /// <summary>
        /// Reads the description from text.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumText">The enum text.</param>
        /// <returns></returns>
        public static string ReadDescriptionFromText<T>(string enumText)
        {
            return ReadDescription(Parse<T>(enumText));
        }


        /// <summary>
        /// Compares the enum description.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumMember">The enum member.</param>
        /// <param name="descriptionInput">The description input.</param>
        /// <returns></returns>
        private static bool CompareEnumDescription<T>(T enumMember, string descriptionInput)
        {
            return ReadDescription(enumMember).Equals(descriptionInput, StringComparison.InvariantCultureIgnoreCase);
        }

        #endregion
    }
}