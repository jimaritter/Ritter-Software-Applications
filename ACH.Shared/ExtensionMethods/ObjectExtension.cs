#region Using Statements



#endregion

using System.Collections.Generic;

namespace ACH.Shared.ExtensionMethods
{
    public static class ObjectExtension
    {
        #region Class Methods

        public static bool IsDefault<T>(this T obj)
        {
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

        public static string ToStringSafe(this object input)
        {
            return input != null ? input.ToString() : string.Empty;
        }

        #endregion
    }
}