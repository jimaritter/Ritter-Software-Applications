#region Using Statements

using System;
using System.Text.RegularExpressions;
using ValidationFramework.Validators.Interfaces;

#endregion

namespace ValidationFramework.Validators
{
    public class EmailValidation : ValidationBase<string>
    {
        #region Constants

        private const string EmailRegex =
            @"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$";

        #endregion

        #region Readonly & Static Fields

        private static readonly ValidationResult Fail = new ValidationResult {Message = "{0} is invalid."};
        private static readonly ValidationResult Win = new ValidationResult {Message = "{0} is valid."};

        #endregion

        #region C'tors

        public EmailValidation(RequiredValidation requiredValidation) : base(requiredValidation)
        {
            ValidationMethod = new Func<string, bool>(x => Regex.IsMatch(x, EmailRegex, RegexOptions.Compiled));
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