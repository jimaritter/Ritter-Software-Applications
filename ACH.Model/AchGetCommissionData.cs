using System;
using System.Diagnostics;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("PayID = {PayID}, OracleID = {OracleID}, SubmitDate = {SubmitDate}")]
    public class AchGetCommissionData
    {
        public virtual int PayID { get; set; }
        public virtual int UplineAgentID { get; set; }
        public virtual string OracleID { get; set; }
        public virtual string IndividualName { get; set; }
        public virtual string IndividualIdentificationNumber { get; set; }
        public virtual string ReceivingDFIIdentification { get; set; }
        public virtual string CheckDigit { get; set; }
        public virtual string DFIAccountNumber { get; set; }
        public virtual Guid? AchAgentsDirectDepositID { get; protected set; }
        public virtual string SumOfNetCommission { get; set; }
        public virtual bool Hold { get; set; }
        public virtual DateTime? SubmitDate { get; set; }
        public virtual string Email { get; set; }
        public virtual int ID { get; set; }
        public virtual string SubmitDateID { get; set; }
    }
}