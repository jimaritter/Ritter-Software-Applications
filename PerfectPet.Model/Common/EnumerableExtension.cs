#region Using Statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

#endregion

namespace PerfectPet.Model.Common
{
    public static class EnumerableExtension
    {
        #region Class Methods

        /// <summary>
        /// Iterates over the collection applying the action to each item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">The action.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var t in enumerable)
                action(t);
        }

        /// <summary>
        /// Finds the first item that matches the specific conditional criteria otherwise returns the first time.
        /// Throws an exception if the collection is empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="conditional">The conditional.</param>
        /// <returns></returns>
        public static T FirstSpecificOrFirstAny<T>(this IEnumerable<T> enumerable, Func<T, bool> conditional) where T : class
        {
            return enumerable.FirstOrDefault(conditional) ?? enumerable.First();
        }

        /// <summary>
        /// Gets the string of an DescriptionAttribute of an Enum.
        /// </summary>
        /// <param name="value">The Enum value for which the description is needed.</param>
        /// <returns>If a DescriptionAttribute is set it return the content of it.
        /// Otherwise just the raw name as string.</returns>
        /// e.Value = Enum.GetName(typeof(States), e.Value).Description;
        public static string Description(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }

            return description;
        }

        #endregion
    }
}