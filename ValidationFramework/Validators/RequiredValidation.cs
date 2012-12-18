#region Using Statements

using System;
using ValidationFramework.Validators.Interfaces;

#endregion

namespace ValidationFramework.Validators
{
    public class RequiredValidation : IValidation<object>
    {
        #region Readonly & Static Fields

        private static readonly ValidationResult Fail = new ValidationResult {Message = "{0} is required."};
        private static readonly ValidationResult Win = new ValidationResult {Message = "{0} is valid."};

        #endregion

        #region C'tors

        public RequiredValidation()
        {
            ValidationMethod =
                new Func<object, bool>(arg => arg != null && (arg.GetType() != typeof (string) || arg.ToString().Trim() != string.Empty));
        }

        #endregion

        #region IValidation<object> Members

        public Func<object, bool> ValidationMethod { get; private set; }

        public void Validate(object entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail)
        {
            Validate(entity, onSuccess, onFail, true);
        }

        public void Validate(object entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail, bool required)
        {
            bool valid = !required || ValidationMethod(entity);

            if (valid)
            {
                if (onSuccess == null)
                    return;

                onSuccess(Win);
            }
            else
                onFail(Fail);
        }

        public void Validate(object entity, Action<ValidationResult> onFail)
        {
            Validate(entity, null, onFail, true);
        }

        public void Validate(object entity, Action<ValidationResult> onFail, bool required)
        {
            Validate(entity, null, onFail, required);
        }

        #endregion
    }
}