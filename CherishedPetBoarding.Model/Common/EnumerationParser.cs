#region Using Statements

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

#endregion

namespace CherishedPetBoarding.Model.Common
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

        /// <summary>
        /// Gets the <see cref="DescriptionAttribute" /> of an <see cref="Enum" />
        /// type value.
        /// </summary>
        /// <param name="value">The <see cref="Enum" /> type value.</param>
        /// <returns>A string containing the text of the
        /// <see cref="DescriptionAttribute"/>.</returns>
        public static string GetDescription(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            EnumDescriptionAttribute[] attributes =
               (EnumDescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            return description;
        }

        /// <summary>
        /// Converts the <see cref="Enum" /> type to an <see cref="IList" /> 
        /// compatible object.
        /// </summary>
        /// <param name="type">The <see cref="Enum"/> type.</param>
        /// <returns>An <see cref="IList"/> containing the enumerated
        /// type value and description.</returns>
        public static IList ToList(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }

            return list;
        }

        // your enum->string method (I just decluttered it a bit :))
        public static string GetEnumDescription(Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return ((DescriptionAttribute)attributes[0]).Description;
            else
                return value.ToString();
        }

        // the method to go from string->enum
        public static T GetEnumFromDescription<T>(string stringValue)
            where T : struct
        {
            foreach (object e in Enum.GetValues(typeof(T)))
                if (GetEnumDescription((Enum)e).Equals(stringValue))
                    return (T)e;
            throw new ArgumentException("No matching enum value found.");
        }

        // and a method to get a list of string values - no KeyValuePair needed
        public static IEnumerable<string> GetEnumDescriptions(Type enumType)
        {
            var strings = new Collection<string>();
            foreach (Enum e in Enum.GetValues(enumType))
                strings.Add(GetEnumDescription(e));
            return strings;
        }

        #endregion
    }

    /// <summary>
    /// Provides a description for an enumerated type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field,
     AllowMultiple = false)]
    public sealed class EnumDescriptionAttribute : Attribute
    {
        private string description;

        /// <summary>
        /// Gets the description stored in this attribute.
        /// </summary>
        /// <value>The description stored in the attribute.</value>
        public string Description
        {
            get
            {
                return this.description;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EnumDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="description">The description to store in this attribute.
        /// </param>
        public EnumDescriptionAttribute(string description)
            : base()
        {
            this.description = description;
        }
    }
}