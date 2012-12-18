#region Using Statements

using System;
using System.Text.RegularExpressions;
using ValidationFramework.Validators.Interfaces;

#endregion

namespace ValidationFramework.Validators
{
    public class NumericValidation : ValidationBase<string>
    {
        #region Constants

        private const string NumericRegex =@"^([\d])+$";

        #endregion

        #region Readonly & Static Fields

        private static readonly ValidationResult Fail = new ValidationResult {Message = "{0} is not numeric."};
        private static readonly ValidationResult Win = new ValidationResult {Message = "{0} is numeric."};

        #endregion

        #region C'tors

        public NumericValidation(RequiredValidation requiredValidation): base(requiredValidation)
        {
            ValidationMethod = new Func<string, bool>(x => Regex.IsMatch(x.ToString(), NumericRegex, RegexOptions.Compiled));
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