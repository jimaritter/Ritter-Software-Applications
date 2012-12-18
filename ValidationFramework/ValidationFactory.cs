#region Using Statements

using System;
using StructureMap;
using ValidationFramework.Extensions;

#endregion

namespace ValidationFramework
{
    public static class ValidationFactory
    {
        #region Class Methods

        public static Result Validate<T>(T obj)
        {
            try
            {
                var validator = ObjectFactory.GetInstance<IValidator<T>>();
                return validator.Validate(obj);
            }
            catch (Exception ex)
            {
                var result = ex.ToResult();
                result.Messages.Insert(0, new ResultMessage {Message = string.Format("Error validating {0}", obj)});
                return result;
            }
        }

        #endregion
    }
}