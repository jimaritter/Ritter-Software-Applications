#region Using Statements

using System;
using System.Collections.Generic;

#endregion

namespace ACH.FileGeneration.FixedLengthGenerator
{
    
    public interface IFixedLengthPropertyMap : IPropertyMap
    {
        #region Instance Properties

        bool AppendingLine { get; set; }
        IList<Func<object, object>> AppliedActions { get; }
        int MaxLength { get; set; }
        char PaddingChar { get; set; }
        bool PaddingTrails { get; set; }

        #endregion

        #region Instance Methods

        /// <summary>
        /// Sets this to be appended to the same line.
        /// This is the default acton
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap Append();


        /// <summary>
        /// Sets this to have a new line appended afterwards
        /// The default is Append()
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap AppendLine();

        /// <summary>
        /// Applies a custom action at runtime to the property
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap ApplyCustomAction(Func<object, object> action);

        /// <summary>
        /// Casts the property value to type T.
        /// </summary>
        /// <typeparam name="T">Resulting type</typeparam>
        /// <returns></returns>
        IFixedLengthPropertyMap Cast<T>();

        /// <summary>
        /// Sets the padding to be applied by leading the property value
        /// Default is Trailing
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap Leading();

        /// <summary>
        /// Sets the specified length.
        /// Default is 20
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap Length(int length);

        /// <summary>
        /// Sets the padding character.
        /// Default is a space
        /// </summary>
        /// <param name="paddingChar">The padding char.</param>
        /// <returns></returns>
        IFixedLengthPropertyMap PaddingCharacter(char paddingChar);

        /// <summary>
        /// Reads the description of the enum.
        /// Only works for enums with DescriptionAttribute
        /// </summary>
        /// <returns></returns>       
        IFixedLengthPropertyMap ReadDescription();

        /// <summary>
        /// Sets the padding to be applied by trailing the property value
        /// This is the default
        /// </summary>
        /// <returns></returns>
        IFixedLengthPropertyMap Trailing();

        #endregion
    }
}