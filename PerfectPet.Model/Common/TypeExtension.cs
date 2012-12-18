#region Using Statements

using System;
using System.Linq;

#endregion

namespace PerfectPet.Model.Common
{
    public static class TypeExtension
    {
        #region Class Methods

        /// <summary>
        /// Reads the underlying type if it is a nullable type otherwise it returns the input type
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static Type ConcreteType(this Type type)
        {
            if (IsNullable(type))
                type = UnderlyingTypeOf(type);
            return type;
        }

        /// <summary>
        /// Returns whether the specified type is assignable to T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type</param>
        /// <returns></returns>
        public static bool IsTypeOf<T>(this Type type)
        {
            return typeof (T).IsAssignableFrom(type);
        }

        /// <summary>
        /// Determines whether [is type concrete] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// 	<c>true</c> if [is type concrete] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsConcreteType(this Type type)
        {
            return !type.IsAbstract && !type.IsInterface;
        }

        /// <summary>
        /// Returns whether the specified type closes an openType T
        /// </summary>
        /// <param name="type">The type</param>
        /// <param name="openType">open generic Type.</param>
        /// <returns>
        /// 	<c>true</c> if the specified type closes; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsClosingTypeOf(this Type type, Type openType)
        {            
            if (openType.IsInterface)
            {
                bool val =type.GetInterfaces().Count(x => x.IsGenericType &&  x.GetGenericTypeDefinition() == openType) > 0;
                return val;
            }

            Type baseType = type.BaseType;
            if (baseType == null || baseType == typeof(object)) return false;

            bool closes = baseType.IsGenericType && baseType.GetGenericTypeDefinition() == openType;
            return closes || (type.BaseType == null ? false : type.BaseType.IsClosingTypeOf(openType));
        }


        /// <summary>
        /// Determines whether the specified t is nullable.
        /// </summary>
        /// <param name="type">The t.</param>
        /// <returns>
        /// 	<c>true</c> if the specified t is nullable; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullable(this Type type)
        {
            if (!type.IsGenericType)
                return false;
            var g = type.GetGenericTypeDefinition();
            return (g.Equals(typeof (Nullable<>)));
        }

        /// <summary>
        /// Returns the underlying Type of T
        /// </summary>
        /// <param name="t">the type</param>
        /// <returns></returns>
        private static Type UnderlyingTypeOf(Type t)
        {
            return t.GetGenericArguments()[0];
        }

        #endregion
    }
}