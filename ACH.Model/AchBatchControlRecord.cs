using System;
using System.Diagnostics;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("RecordTypeCode = {RecordTypeCode}, ServiceClassCode = {ServiceClassCode}, EntryAddendaCount = {EntryAddendaCount}, EntryHash = {EntryHash}, TotalDebitEntyDollarAmount = {TotalDebitEntyDollarAmount}, TotalCreditEntryDollarAmount = {TotalCreditEntryDollarAmount}, CompanyIdentification = {CompanyIdentification}, MessageAuthenticationCode = {MessageAuthenticationCode}, Reserved = {Reserved}, OriginatingDFIIdentification = {OriginatingDFIIdentification}, BatchNumber = {BatchNumber}")]
    public class AchBatchControlRecord : BusinessEntity 
    {
        /// <summary>
        /// <para>Name = RecordTypeCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 1</para>
        /// <para>Length = 1</para>
        /// <para>Contents = AchStaticValues</para>
        /// <para>Example = 8</para>
        /// </summary>
        public virtual char RecordTypeCode { get; set; }
        /// <summary>
        /// <para>Name = ServiceClassCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 2-4</para>
        /// <para>Length = 3</para>
        /// <para>Contents = Value from ServiceClassCodes Enum - Must match Field 2(ServiceClassCode) from AchBatchHeaderRecord</para>
        /// <para>Example = 200</para>
        /// </summary>
        public virtual int ServiceClassCode { get; set; }
        /// <summary>
        /// <para>Name = EntryAddendaCount</para>
        /// <para>Required = true</para>
        /// <para>Position = 5-10</para>
        /// <para>Length = 6</para>
        /// <para>Contents = Numeric Zero Filled - Number of records in AchEntryDetailRecord</para>
        /// <para>Example = 000003</para>
        /// </summary>
        public virtual string EntryAddendaCount { get; set; }
        /// <summary>
        /// <para>Name = EntryHash</para>
        /// <para>Required = true</para>
        /// <para>Position = 11-20</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric Zero Filled - Add up Field 3(ReceivingDFIIdentification) from each record in AchEntryDetailRecord. Right Justify if over 10 digits.</para>
        /// <para>Example = 0009391717</para>
        /// </summary>
        public virtual string EntryHash { get; set; }
        /// <summary>
        /// <para>Name = TotalDebitEntyDollarAmount</para>
        /// <para>Required = true</para>
        /// <para>Position = 21-32</para>
        /// <para>Length = 12</para>
        /// <para>Contents = Numeric Zero Filled - Add up all debits in Field 6(DollarAmount) from each record in AchEntryDetailRecord. This is determined by the TransactionCode type for that record.</para>
        /// <para>Example = 000000200000</para>
        /// </summary>
        public virtual string TotalDebitEntyDollarAmount { get; set; }
        /// <summary>
        /// <para>Name = TotalCreditEntryDollarAmount</para>
        /// <para>Required = true</para>
        /// <para>Position = 33-44</para>
        /// <para>Length = 12</para>
        /// <para>Contents = Numeric Zero Filled - Add up all credits in Field 6(DollarAmount) from each record in AchEntryDetailRecord. This is determined by the TransactionCode type for that record.</para>
        /// <para>Example = 000000200000</para>
        /// </summary>
        public virtual string TotalCreditEntryDollarAmount { get; set; }
        /// <summary>
        /// <para>Name = CompanyIdentification</para>
        /// <para>Required = true</para>
        /// <para>Position = 45-54</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric Zero Filled - Must match Field 5(CompanyIdentification) from AchBatchHeaderRecord</para>
        /// <para>Example = 1231234567</para>
        /// </summary>
        public virtual string CompanyIdentification { get; set; }
        /// <summary>
        /// <para>Name = MessageAuthenticationCode</para>
        /// <para>Required = false</para>
        /// <para>Position = 55-73</para>
        /// <para>Length = 19</para>
        /// <para>Contents = AlphaNumeric - Blank if not used.</para>
        /// <para>Example = </para>
        /// </summary>
        public virtual string MessageAuthenticationCode { get; set; }
        /// <summary>
        /// <para>Name = Reserved</para>
        /// <para>Required = true</para>
        /// <para>Position = 74-79</para>
        /// <para>Length = 6</para>
        /// <para>Contents = Blank</para>
        /// <para>Example = </para>
        /// </summary>
        public virtual string Reserved { get; set; }
        /// <summary>
        /// <para>Name = OriginatingDFIIdentification</para>
        /// <para>Required = true</para>
        /// <para>Position = 80-87</para>
        /// <para>Length = 8</para>
        /// <para>Contents = Must match Field 12(OriginatorDFIIdentification) from AchBatchHeaderRecord</para>
        /// <para>Example = 03130142</para>
        /// </summary>
        public virtual string OriginatingDFIIdentification { get; set; }
        /// <summary>
        /// <para>Name = BatchNumber</para>
        /// <para>Required = true</para>
        /// <para>Position = 88-94</para>
        /// <para>Length = 7</para>
        /// <para>Contents = Must match Field 13(BatchNumber) from AchBatchHeaderRecord</para>
        /// <para>Example = 0000001</para>
        /// </summary>
        public virtual string BatchNumber { get; set; }
    }
}