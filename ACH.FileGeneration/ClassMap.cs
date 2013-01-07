#region Using Statements

using System;
using System.Linq.Expressions;

#endregion

namespace ACH.FileGeneration
{
    public abstract class ClassMap<TMappableObject, TMap>
    {
        protected const string DollarSeparator = ": $";
        protected const string ColonSeparator = ": ";
        public abstract TMap Map(Expression<Func<TMappableObject, object>> expression);
        public abstract string Write(TMappableObject mappableObject);       
    }
}