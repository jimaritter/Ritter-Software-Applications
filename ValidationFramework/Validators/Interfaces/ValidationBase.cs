#region Using Statements

using System;

#endregion

namespace ValidationFramework.Validators.Interfaces
{
    public abstract class ValidationBase<T> : IValidation<T>
    {
        #region Readonly & Static Fields

        private readonly RequiredValidation _requiredValidation;
        private static readonly ValidationResult RequiredResult = new ValidationResult {Message = "{0} is required."};

        #endregion

        #region C'tors

        public ValidationBase(RequiredValidation requiredValidation)
        {
            _requiredValidation = requiredValidation;
        }

        #endregion

        #region Instance Properties

        protected abstract ValidationResult FailureValidationResult { get; }
        protected abstract ValidationResult SuccessValidationResult { get; }

        #endregion

        #region IValidation<T> Members

        public Func<T, bool> ValidationMethod { get; protected set; }

        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onFail">The on fail action.</param>
        public void Validate(T entity,  Action<ValidationResult> onFail)
        {
            Validate(entity, null, onFail, true);
        }

        /// <summary>
        /// Validates the specified entity. Allows entity to be null to successfully pass validation if required == false.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onFail">The on fail action.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        public void Validate(T entity, Action<ValidationResult> onFail, bool required)
        {
            Validate(entity, null, onFail, required);
        }

        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onSuccess">The on success.</param>
        /// <param name="onFail">The on fail action.</param>
        public void Validate(T entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail)
        {
            Validate(entity, onSuccess, onFail, true);
        }

        /// <summary>
        /// Validates the specified entity. Allows entity to be null to successfully pass validation if required == false.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onSuccess">The on success.</param>
        /// <param name="onFail">The on fail action.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        public void Validate(T entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail, bool required)
        {
            bool valid = false, exists = false;

            //Make sure the entity exists otherwise null reference exceptions will occur, fail not error
            _requiredValidation.Validate(entity, passAction => { exists = true; }, failAction => { valid = exists; });

            //if exists valid determined by validationMethod, otherwise it's valid if object is NOT required
            valid = exists ? ValidationMethod(entity) : !required;

            //pipe out results
            if (valid)
            {
                if (onSuccess == null)
                    return;

                onSuccess(SuccessValidationResult);
            }
            else if (!exists)
                onFail(RequiredResult);
            else
                onFail(FailureValidationResult);
        }

        #endregion
    }
}