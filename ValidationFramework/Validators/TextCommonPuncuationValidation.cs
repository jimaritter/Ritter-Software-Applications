#region Using Statements

using System;
using System.Text.RegularExpressions;
using ValidationFramework.Validators.Interfaces;

#endregion

namespace ValidationFramework.Validators
{
    public class TextCommonPuncuationValidation : ValidationBase<string>
    {
        #region Constants

        private const string TextRegex = @"^([ \u00c0-\u01ff\w\s\-\.\$\(\)\[\]\{\}\^\|\+\?\*#/!@%&'="":;])+$";

        #endregion

        #region Readonly & Static Fields

        private static readonly ValidationResult Fail = new ValidationResult {Message = "{0} contains invalid characters."};
        private static readonly ValidationResult Win = new ValidationResult {Message = "{0} is valid."};

        #endregion

        #region C'tors

        public TextCommonPuncuationValidation(RequiredValidation requiredValidation)
            : base(requiredValidation)
        {
            ValidationMethod = new Func<string, bool>(x => Regex.IsMatch(x.ToString(), TextRegex, RegexOptions.Multiline | RegexOptions.Compiled));
        }

        #endregion

        #region Instance Properties

        protected override ValidationResult FailureValidationResult
        {
            get { return Fail; }
        }

        protected override ValidationResult SuccessValidationResult
        {
            get { return Win; }
        }

        #endregion
    }
}