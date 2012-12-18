#region Using Statements

using System;
using ValidationFramework.Validators.Interfaces;

#endregion

namespace ValidationFramework.Validators
{
    public class IsTrueValidation : ValidationBase<bool>
    {
        #region Readonly & Static Fields

        private static readonly ValidationResult Fail = new ValidationResult {Message = "{0} is not true."};
        private static readonly ValidationResult Win = new ValidationResult {Message = "{0} is true."};

        #endregion

        #region C'tors

        public IsTrueValidation(RequiredValidation requiredValidation): base(requiredValidation)
        {
            ValidationMethod = new Func<bool, bool>(x => x);
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