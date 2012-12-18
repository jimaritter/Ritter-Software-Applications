#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace CherishedPetBoarding.Model.Common
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

        #endregion
    }
}