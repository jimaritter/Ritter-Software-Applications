using System;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    public class AchAgentsDirectDeposit : BusinessEntity
    {
        public virtual string OracleID { get; protected internal set; }
        public virtual int PayID { get; protected set; }
        public virtual int UplineAgentID { get; set; }
        public virtual string AgentName { get; set; }
        public virtual string Company { get; set; }
        public virtual string CompanyEIN { get; set; }
        public virtual bool IsAchReady { get; set; }
        public virtual string IndividualName { get; set; }
        public virtual string IndividualIdentificationNumber { get; set; }
        public virtual string ReceivingDfiIdentification { get; set; }
        public virtual string CheckDigit { get; set; }
        public virtual string DfiAccountNumber { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Email { get; set; }
    }
}