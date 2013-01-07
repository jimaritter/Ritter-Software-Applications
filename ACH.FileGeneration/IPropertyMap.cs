#region Using Statements

using System.Reflection;

#endregion

namespace ACH.FileGeneration
{
    public interface IPropertyMap
    {
        PropertyInfo PropertyInfo { get; set; }
    }
}