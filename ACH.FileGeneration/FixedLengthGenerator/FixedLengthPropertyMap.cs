#region Using Statements

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using ACH.Shared;

#endregion

namespace ACH.FileGeneration.FixedLengthGenerator
{
    [DebuggerDisplay("PaddingChar = {PaddingChar}, PaddingTrails = {PaddingTrails}, PropertyName = {PropertyInfo.Name}")]
    public class FixedLengthPropertyMap : IFixedLengthPropertyMap
    {
        #region C'tors

        public FixedLengthPropertyMap()
        {
            AppliedActions = new List<Func<object, object>>();
        }

        #endregion

        #region IFixedLengthPropertyMap Members

        public int MaxLength { get; set; }
        public char PaddingChar { get; set; }
        public bool PaddingTrails { get; set; }
        public bool AppendingLine { get; set; }
        public IList<Func<object, object>> AppliedActions { get; private set; }
        public PropertyInfo PropertyInfo { get; set; }

        /// <summary>
        /// Sets the specified length.
        /// Default is 20
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.Length(int length)
        {
            MaxLength = length;
            return this;
        }

        /// <summary>
        /// Sets the padding to be applied by leading the property value
        /// Default is Trailing
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.Leading()
        {
            PaddingTrails = false;
            return this;
        }

        /// <summary>
        /// Sets the padding to be applied by trailing the property value
        /// This is the default
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.Trailing()
        {
            PaddingTrails = true;
            return this;
        }

        /// <summary>
        /// Sets this to have a new line appended afterwards
        /// The default is Append()
        /// </summary>
        /// <returns></returns>
        public IFixedLengthPropertyMap AppendLine()
        {
            AppendingLine = true;
            return this;
        }

        /// <summary>
        /// Sets this to be appended to the same line.
        /// This is the default acton
        /// </summary>
        /// <returns></returns>
        public IFixedLengthPropertyMap Append()
        {
            AppendingLine = false;
            return this;
        }

        /// <summary>
        /// Casts the property value to type T.
        /// </summary>
        /// <typeparam name="T">Resulting type</typeparam>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.Cast<T>()
        {
            AppliedActions.Add(x => (T) x);
            return this;
        }

        /// <summary>
        /// Reads the description of the enum.
        /// Only works for enums with DescriptionAttribute
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.ReadDescription()
        {
            AppliedActions.Add(EnumerationParser.ReadDescription);
            return this;
        }

        /// <summary>
        /// Sets the padding character.
        /// Default is a space
        /// </summary>
        /// <param name="paddingChar">The padding char.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.PaddingCharacter(char paddingChar)
        {
            PaddingChar = paddingChar;
            return this;
        }

        /// <summary>
        /// Applies a custom action at runtime to the property
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap IFixedLengthPropertyMap.ApplyCustomAction(Func<object, object> action)
        {
            AppliedActions.Add(action);
            return this;
        }

        #endregion
    }
}