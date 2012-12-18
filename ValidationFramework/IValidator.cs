#region Using Statements



#endregion

namespace ValidationFramework
{
    public interface IValidator<T>
    {
        #region Instance Methods

        Result Validate(T obj);
        Result Validate(T obj, bool suppressWarnings);

        #endregion
    }
}