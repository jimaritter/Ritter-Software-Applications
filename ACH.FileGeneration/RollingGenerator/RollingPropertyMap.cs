#region Using Statements

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using ACH.Shared;

#endregion

namespace ACH.FileGeneration.RollingGenerator
{
    [DebuggerDisplay("LeadingLabel = {LeadingLabel}, TrailingNotice = {TrailingNotice}, PropertyName = {PropertyInfo.Name}")]
    public class RollingPropertyMap : IRollingPropertyMap
    {
        #region C'tors

        public RollingPropertyMap()
        {
            AppliedActions = new List<Func<object, object>>();
        }

        #endregion

        #region IRollingPropertyMap Members

        /// <summary>
        /// Causes this property map to not display the leading and trailing
        /// notices or append any lines.
        /// The default is SkipEmpty(false) to display notices and append lines.
        /// </summary>
        /// <returns></returns>
        public IRollingPropertyMap SkipEmpty()
        {
            DisplayEmptyValue = false;
            return this;
        }

        /// <summary>
        /// Causes this property map to not display the leading and trailing
        /// notices or append any lines.
        /// The default is SkipEmpty(false) to display notices and append lines.
        /// </summary>
        /// <returns></returns>
        public IRollingPropertyMap SkipEmpty(bool skipEmpty)
        {
            DisplayEmptyValue = !skipEmpty;
            return this;
        }

        public int? MaxLength { get; set; }
        public string LeadingLabel { get; set; }
        public string TrailingNotice { get; set; }
        public bool DisplayEmptyValue { get; set; }
        public int? LinesToAppend { get; set; }
        public IList<Func<object, object>> AppliedActions { get; private set; }
        public PropertyInfo PropertyInfo { get; set; }

        /// <summary>
        /// Sets the property name to be the leading label
        /// </summary>
        /// <param name="seperator">The seperator between the property name and property value on write.</param>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.PropertyNameIsLabel(string seperator)
        {
            LeadingLabel = PropertyInfo.Name + seperator;
            return this;
        }

        /// <summary>
        /// Sets an optional max length that will truncate long text
        /// Default is null for no truncation.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.Length(int? length)
        {
            MaxLength = length;
            return this;
        }

        /// <summary>
        /// Sets text to appear immediately BEFORE the property value
        /// Default is string.Empty
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.Label(string label)
        {
            LeadingLabel = label;
            return this;
        }

        /// <summary>
        /// Sets text to appear immediatley AFTER the property value.
        /// Default is string.Empty
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.Notice(string notice)
        {
            TrailingNotice = notice;
            return this;
        }

        /// <summary>
        /// Sets a single new line after this instance.
        /// This is equivalent to AppendLines(1) the default
        /// is AppendLines(null) for no appending.
        /// </summary>
        /// <returns></returns>
        public IRollingPropertyMap AppendLine()
        {
            LinesToAppend = 1;
            return this;
        }

        /// <summary>
        /// Sets a variable amount of new line after this instance.
        /// The default is AppendLines(null) for no appending.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public IRollingPropertyMap AppendLines(int? lines)
        {
            LinesToAppend = lines;
            return this;
        }

        /// <summary>
        /// Casts the property value to type T.
        /// </summary>
        /// <typeparam name="T">Resulting type</typeparam>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.Cast<T>()
        {
            AppliedActions.Add(x => (T) x);
            return this;
        }

        /// <summary>
        /// Reads the description of the enum.
        /// Only works for enums with DescriptionAttribute
        /// </summary>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.ReadDescription<T>()
        {
            AppliedActions.Add(o => EnumerationParser.ReadDescription((T) o));
            return this;
        }

        /// <summary>
        /// Applies a custom action at runtime to the property
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        IRollingPropertyMap IRollingPropertyMap.ApplyCustomAction(Func<object, object> action)
        {
            AppliedActions.Add(action);
            return this;
        }

        #endregion
    }
}