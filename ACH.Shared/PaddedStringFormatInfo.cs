#region Using Statements

using System;

#endregion

namespace ACH.Shared
{
    public sealed class PaddedStringFormatInfo : IFormatProvider, ICustomFormatter
    {
        #region ICustomFormatter Members

        public string Format(string format, object argument, IFormatProvider formatProvider)
        {
            if (argument == null)
                throw new ArgumentNullException("argument");

            if (format == null)
                return argument.ToString();

            var args = format.Split(':');

            if (args.Length == 1)
                String.Format("{0, " + format + "}", argument);

            int padLength;

            if (!int.TryParse(args[0], out padLength))
                throw new ArgumentException("Padding length should be an integer");

            switch (args.Length)
            {
                case 2: //Padded format
                    var padChar = args[1][0];
                    return padLength > 0
                               ? (argument.ToString()).PadLeft(padLength, padChar)
                               : (argument.ToString()).PadRight(padLength*-1, padChar);
                default: //Use default string.format
                    return string.Format("{0," + format + "}", argument);
            }
        }

        #endregion

        #region IFormatProvider Members

        public object GetFormat(Type formatType)
        {
            return typeof (ICustomFormatter).Equals(formatType) ? this : null;
        }

        #endregion
    }
}