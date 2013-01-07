using System;
using System.Diagnostics;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("RecordTypeCode = {RecordTypeCode}, BatchCount = {BatchCount}, BlockCount = {BlockCount}, EntryAddendaCount = {EntryAddendaCount}, EntryHash = {EntryHash}, TotalDebitEntryDollarAmount = {TotalDebitEntryDollarAmount}, TotalCreditDollarAmount = {TotalCreditDollarAmount}, Reserved = {Reserved}")]
    public class AchFileControlRecord : BusinessEntity
    {
        /// <summary>
        /// <para>Name = RecordTypeCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 1</para>
        /// <para>Length = 1</para>
        /// <para>Contents = '9'</para>
        /// <para>Example = 9</para>
        /// </summary>
        public virtual char RecordTypeCode { get; set; }
        /// <summary>
        /// <para>Name = BatchCount</para>
        /// <para>Required = true</para>
        /// <para>Position = 2-7</para>
        /// <para>Length = 6</para>
        /// <para>Contents = Numeric Zero Filled - Number of batch header records in the file.</para>
        /// <para>Example = 000001</para>
        /// </summary>
        public virtual string BatchCount { get; set; }
        /// <summary>
        /// <para>Name = BlockCount</para>
        /// <para>Required = true</para>
        /// <para>Position = 8-13</para>
        /// <para>Length = 6</para>
        /// <para>Contents = Numeric Zero Filled - Number of blocks in the file (1 block = 10 records).</para>
        /// <para>Example = 000001</para>
        /// </summary>
        public virtual string BlockCount { get; set; }
        /// <summary>
        /// <para>Name = EntryAddendaCount</para>
        /// <para>Required = true</para>
        /// <para>Position = 14-21</para>
        /// <para>Length = 8</para>
        /// <para>Contents = Numeric Zero Filled - Add up Field 3(EntryAddendaCount) from each batch control record in the file.</para>
        /// <para>Example = 0000003</para>
        /// </summary>
        public virtual string EntryAddendaCount { get; set; }
        /// <summary>
        /// <para>Name = EntryHash</para>
        /// <para>Required = true</para>
        /// <para>Position = 22-31</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric Zero Filled - Add up Field 4(EntryHash) from each batch control record in the file (Right Justify if needed).</para>
        /// <para>Example = 0009391717</para>
        /// </summary>
        public virtual string EntryHash { get; set; }
        /// <summary>
        /// <para>Name = TotalDebitEntryDollarAmount</para>
        /// <para>Required = true</para>
        /// <para>Position = 32-43</para>
        /// <para>Length = 12</para>
        /// <para>Contents = Numeric Zero Filled - Add up Field 5(TotalDebitEntryDollarAmount) from each batch control record in the file.</para>
        /// <para>Example = 000000200000</para>
        /// </summary>
        public virtual string TotalDebitEntryDollarAmount { get; set; }
        /// <summary>
        /// <para>Name = TotalCreditDollarAmount</para>
        /// <para>Required = true</para>
        /// <para>Position = 44-55</para>
        /// <para>Length = 12</para>
        /// <para>Contents = Numeric Zero Filled - Add up Field 6(TotalCreditDollarAmount) from each batch control record in the file.</para>
        /// <para>Example = 000000200000</para>
        /// </summary>
        public virtual string TotalCreditDollarAmount { get; set; }
        /// <summary>
        /// <para>Name = Reserved</para>
        /// <para>Required = true</para>
        /// <para>Position = 56-94</para>
        /// <para>Length = 39</para>
        /// <para>Contents = Blank</para>
        /// <para>Example = Add Padding of spaces for the length (39)</para>
        /// </summary>
        public virtual string Reserved { get; set; }

        public virtual string FillerLines { get; set; }

    }
}