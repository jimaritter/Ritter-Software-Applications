using System;
using System.Diagnostics;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("RecordTypeCode = {RecordTypeCode}, TransactionCode = {TransactionCode}, ReceivingDFIIdentification = {ReceivingDFIIdentification}, CheckDigit = {CheckDigit}, DFIAccountNumber = {DFIAccountNumber}, DollarAmount = {DollarAmount}, IndividualIdentificationNumber = {IndividualIdentificationNumber}, IndividualName = {IndividualName}, DiscreteData = {DiscreteData}, AddendaRecordIndicator = {AddendaRecordIndicator}, TraceNumber = {TraceNumber}")]
    public class AchEntryDetailRecord : BusinessEntity

    {

        public virtual string OracleID { get; protected internal set; }

        /// <summary>
        /// <para>Name = RecordTypeCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 1</para>
        /// <para>Length = 1</para>
        /// <para>Contents = AchStruct.EntryDetailType</para>
        /// <para>Example = 6</para>
        /// </summary>
        public virtual char RecordTypeCode { get; set; }
        /// <summary>
        /// <para>Name = TransactionCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 2-3</para>
        /// <para>Length = 2</para>
        /// <para>Contents = Uses value from AchTransactionCodes Enum. ex 22 = "CheckingDepositCredit"</para>
        /// <para>Example = 22</para>
        /// </summary>
        public virtual int TransactionCode { get; set; }
        /// <summary>
        /// <para>Name = ReceivingDFIIdentification</para>
        /// <para>Required = true</para>
        /// <para>Position = 4-11</para>
        /// <para>Length = 8</para>
        /// <para>Contents = The Banks Transit/Routing Number being paid or charged</para>
        /// <para>Example = 03130213</para>
        /// </summary>
        public virtual string ReceivingDFIIdentification { get; set; }
        /// <summary>
        /// <para>Name = CheckDigit</para>
        /// <para>Required = true</para>
        /// <para>Position = 12</para>
        /// <para>Length = 1</para>
        /// <para>Contents = Bank Transit/Routing check digit</para>
        /// <para>Example = 3</para>
        /// </summary>
        public virtual string CheckDigit { get; set; }
        /// <summary>
        /// <para>Name = DFIAccountNumber</para>
        /// <para>Required = true</para>
        /// <para>Position = 13-29</para>
        /// <para>Length = 17</para>
        /// <para>Contents = Numeric No Hyphens. The Account Number being paid or charged.</para>
        /// <para>Example = 1112223333</para>
        /// </summary>
        public virtual string DFIAccountNumber { get; set; }
        /// <summary>
        /// <para>Name = DollarAmount</para>
        /// <para>Required = true</para>
        /// <para>Position = 30-39</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric Zero Filled. Decimal Point is assumed; prenotes must have $0</para>
        /// <para>Example = 0000100000</para>
        /// </summary>
        public virtual string DollarAmount { get; set; }
        /// <summary>
        /// <para>Name = IndividualIdentificationNumber</para>
        /// <para>Required = false</para>
        /// <para>Position = 40-54</para>
        /// <para>Length = 15</para>
        /// <para>Contents = Alphanumeric - Employee Number, Tax ID number, etc. Blank if not used (space filled for length).</para>
        /// <para>Example = 123-45-6789</para>
        /// </summary>
        public virtual string IndividualIdentificationNumber { get; set; }
        /// <summary>
        /// <para>Name = IndividualName</para>
        /// <para>Required = true</para>
        /// <para>Position = 55-76</para>
        /// <para>Length = 22</para>
        /// <para>Contents = The person or company being paid or charged.</para>
        /// <para>Example = Bunny, Bugs</para>
        /// </summary>
        public virtual string IndividualName { get; set; }
        /// <summary>
        /// <para>Name = DiscreteData</para>
        /// <para>Required = false</para>
        /// <para>Position = 77-78</para>
        /// <para>Length = 2</para>
        /// <para>Contents = Numeric - Blank if not used (space filled for length).</para>
        /// <para>Example =</para>
        /// </summary>
        public virtual string DiscreteData { get; set; }
        /// <summary>
        /// <para>Name = AddendaRecordIndicator</para>
        /// <para>Required = true</para>
        /// <para>Position = 79</para>
        /// <para>Length = 1</para>
        /// <para>Contents = Binary: 0 = off, 1 = on.</para>
        /// <para>Example = 0</para>
        /// </summary>
        public virtual string AddendaRecordIndicator { get; set; }
        /// <summary>
        /// <para>Name = TraceNumber</para>
        /// <para>Required = true</para>
        /// <para>Position = 80-88</para>
        /// <para>Length = 8</para>
        /// <para>Contents = Banks Transit/Routing number followed by '0000001' and incremented by 1 for each detail record.</para>
        /// <para>Example = 03130142</para>
        /// </summary>
        public virtual string TraceNumber { get; set; }
        /// <summary>
        /// <para>Name = TraceNumberFiller</para>
        /// <para>Required = true</para>
        /// <para>Position = 89-94</para>
        /// <para>Length = 7</para>
        /// <para>Contents = '0000001' and incremented by 1 for each detail record.</para>
        /// <para>Example = 0000001</para>
        /// </summary>
        public virtual string TraceNumberFiller { get; set; }

    }
}