using System;
using System.Collections.Generic;
using ACH.Shared;

namespace ACH.Model
{
    public class AchFile : BusinessEntity
    {

        //Designates whether the file is flat or contains carriage returns

        #region Fields

        #endregion

        #region C'tors

        public AchFile()
        {
            FileHeaderRecord = new AchFileHeaderRecord();
            BatchHeaderRecord = new AchBatchHeaderRecord();
            EntryDetailRecord = new List<AchEntryDetailRecord>();
            BatchControlRecord = new AchBatchControlRecord();
            FileControlRecord = new AchFileControlRecord();
            AgentCommissionTable = new List<AchAgentCommissionTable>();
        }

        #endregion

        #region Instance Properties

        //The '1' RecordTypeCode
        public virtual AchFileHeaderRecord FileHeaderRecord { get; protected set; }
        //The '5' RecordTypeCode
        public virtual AchBatchHeaderRecord BatchHeaderRecord { get; protected set; }
        //The '6' RecordTypeCode
        public virtual IList<AchEntryDetailRecord> EntryDetailRecord { get; protected set; }
        //The '8' RecordTypeCode
        public virtual AchBatchControlRecord BatchControlRecord { get; protected set; }
        //The '9' RecordTypeCode
        public virtual AchFileControlRecord FileControlRecord { get; protected set; }
        //This is the View that contains data for submission
        public virtual IList<AchAgentCommissionTable> AgentCommissionTable { get; protected set; }


        public virtual long BatchCount { get; set; }
        public virtual long BlockCount { get; set; }
        public virtual long TraceNumber { get; set; }
        public virtual double CreditDollarAmount { get; set; }
        public virtual double DebitDollarAmount { get; set; }
        public virtual long EntryAddendaCount { get; set; }
        public virtual double EntryHash { get; set; }
        /// <summary>
        /// This is used to run a test...submitting $0 values
        /// </summary>
        public virtual bool IsPreNote { get; set; }
        public virtual long RecordCount { get; set; }
        public virtual long NumberOfFillerLines { get; set; }
        public virtual DateTime? SubmitDate { get; set; }

        #endregion
    }
}