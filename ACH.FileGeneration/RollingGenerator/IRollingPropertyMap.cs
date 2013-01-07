#region Using Statements

using System;
using System.Collections.Generic;

#endregion

namespace ACH.FileGeneration.RollingGenerator
{
    public interface IRollingPropertyMap : IPropertyMap
    {
        #region Instance Properties

        IList<Func<object, object>> AppliedActions { get; }
        bool DisplayEmptyValue { get; set; }
        string LeadingLabel { get; set; }
        int? LinesToAppend { get; set; }
        int? MaxLength { get; set; }
        string TrailingNotice { get; set; }

        #endregion

        #region Instance Methods

        /// <summary>
        /// Sets a single new line after this instance.
        /// This is equivalent to AppendLines(1) the default
        /// is AppendLines(null) for no appending.
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap AppendLine();

        /// <summary>
        /// Sets a variable amount of new line after this instance.
        /// The default is AppendLines(null) for no appending.
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap AppendLines(int? lines);

        /// <summary>
        /// Applies a custom action at runtime to the property
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        IRollingPropertyMap ApplyCustomAction(Func<object, object> action);

        /// <summary>
        /// Casts the property value to type T.
        /// </summary>
        /// <typeparam name="T">Resulting type</typeparam>
        /// <returns></returns>
        IRollingPropertyMap Cast<T>();

        /// <summary>
        /// Sets text to appear immediately BEFORE the property value
        /// Default is string.Empty
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        IRollingPropertyMap Label(string label);

        /// <summary>
        /// Sets an optional max length that will truncate long text
        /// Default is null for no truncation.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        IRollingPropertyMap Length(int? length);

        /// <summary>
        /// Sets text to appear immediatley AFTER the property value.
        /// Default is string.Empty
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        IRollingPropertyMap Notice(string notice);

        /// <summary>
        /// Sets the property name to be the leading label
        /// </summary>
        /// <param name="seperator">The seperator between the property name and property value on write.</param>
        /// <returns></returns>
        IRollingPropertyMap PropertyNameIsLabel(string seperator);

        /// <summary>
        /// Reads the description of the enum.
        /// Only works for enums with DescriptionAttribute
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap ReadDescription<T>();

        /// <summary>
        /// Causes this property map to not display the leading and trailing
        /// notices or append any lines.
        /// The default is SkipEmpty(false) to display notices and append lines.
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap SkipEmpty();

        /// <summary>
        /// Causes this property map to not display the leading and trailing
        /// notices or append any lines.
        /// The default is SkipEmpty(false) to display notices and append lines.
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap SkipEmpty(bool skipEmpty);

        #endregion
    }
}