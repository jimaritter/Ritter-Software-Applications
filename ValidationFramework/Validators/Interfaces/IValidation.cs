#region Using Statements

using System;

#endregion

namespace ValidationFramework.Validators.Interfaces
{
    public interface IValidation<T>
    {
        #region Instance Properties

        Func<T, bool> ValidationMethod { get; }

        #endregion

        #region Instance Methods

        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onSuccess">The on success action.</param>
        /// <param name="onFail">The on fail action.</param>
        void Validate(T entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail);

        /// <summary>
        /// Validates the specified entity. Allows entity to be null to successfully pass validation if required == false.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onSuccess">The on success action.</param>
        /// <param name="onFail">The on fail action.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        void Validate(T entity, Action<ValidationResult> onSuccess, Action<ValidationResult> onFail, bool required);

        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onFail">The on fail action.</param>
        void Validate(T entity, Action<ValidationResult> onFail);

        /// <summary>
        /// Validates the specified entity. Allows entity to be null to successfully pass validation if required == false.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="onFail">The on fail action.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        void Validate(T entity, Action<ValidationResult> onFail, bool required);

        #endregion
    }
}