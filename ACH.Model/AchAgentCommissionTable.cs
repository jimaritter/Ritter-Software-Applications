using System;
using System.Diagnostics;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("Id = {Id}, OracleId = {OracleId}, PayID = {PayID}, IndividualName = {IndividualName}, SubmitDate = {SubmitDate}")]
    public class AchAgentCommissionTable : BusinessEntity
    {
        public virtual int PayID { get; set; }
        public virtual int UplineAgentID { get; set; }
        public virtual string OracleID { get; set; }
        public virtual string IndividualName { get; set; }
        public virtual string IndividualIdentificationNumber { get; set; }
        public virtual string ReceivingDfiIdentification { get; set; }
        public virtual string CheckDigit { get; set; }
        public virtual string DfiAccountNumber { get; set; }
        public virtual string SumOfNetCommission { get; set; }
        public virtual bool Hold { get; set; }
        public virtual DateTime? SubmitDate { get; set; }
        public virtual string Email { get; set; }
    }
}
