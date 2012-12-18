#region Using Statements



#endregion

using System.Collections.Generic;

namespace PerfectPet.Model.Common
{
    public static class ObjectExtension
    {
        #region Class Methods

        public static bool IsDefault<T>(this T obj)
        {
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

        #endregion
    }
}