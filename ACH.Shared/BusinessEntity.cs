#region Using Statements

using System;
using System.Diagnostics;

#endregion

namespace ACH.Shared
{
    [Serializable]
    [DebuggerDisplay("Id = {Id}, Created = {Created}, CreatedBy = {CreatedBy.LastName}, Updated = {Updated}, UpdatedBy = {UpdatedBy.LastName}")]
    public abstract class BusinessEntity
    {
        public virtual User CreatedBy { get;  protected internal set; }
        public virtual User UpdatedBy { get;  protected internal set; }

        #region Instance Properties

        public virtual DateTime? Created { get; protected internal set; }
        public virtual Guid? Id { get; protected internal set; }
        public virtual DateTime? Updated { get; protected internal set; }

        #endregion
    }
}