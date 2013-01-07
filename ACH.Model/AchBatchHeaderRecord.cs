using System;
using System.Diagnostics;
using ACH.Model.Enums;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("RecordTypeCode = {RecordTypeCode}, ServiceClassCode = {ServiceClassCode}, CompanyName = {CompanyName}, CompanyDiscretionaryData = {CompanyDiscretionaryData}, CompanyIdentification = {CompanyIdentification}, StandardEntryClass = {StandardEntryClass}, CompanyEntryDescription = {CompanyEntryDescription}, CompanyDescriptiveDate = {CompanyDescriptiveDate}, EffectiveEntryDate = {EffectiveEntryDate}, SettleDate = {SettleDate}, OriginatorStatusCode = {OriginatorStatusCode}, OriginatorDFIIdentification = {OriginatorDFIIdentification}, BatchNumber = {BatchNumber}")]
    public class AchBatchHeaderRecord : BusinessEntity
    {
        /// <summary>
        /// <para>Name = RecordTypeCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 1</para>
        /// <para>Length = 1</para>
        /// <para>Contents = AchStruct.BatchHeaderType</para>
        /// <para>Example = 5</para>
        /// </summary>
        public virtual char RecordTypeCode { get; set; }
        /// <summary>
        /// <para>Name = ServiceClassCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 2-4</para>
        /// <para>Length = 3</para>
        /// <para>Contents = One of the values from the AchServiceClassCodes enum values.</para>
        /// <para>Example = 200</para>
        /// </summary>
        public virtual int ServiceClassCode { get; set; }
        /// <summary>
        /// <para>Name = CompanyName</para>
        /// <para>Required = true</para>
        /// <para>Position = 5-20</para>
        /// <para>Length = 16</para>
        /// <para>Contents = AlphaNumeric</para>
        /// <para>Example = RITTER IM</para>
        /// </summary>
        public virtual string CompanyName { get; set; }
        /// <summary>
        /// <para>Name = CompanyDiscretionaryData</para>
        /// <para>Required = false</para>
        /// <para>Position = 21-40</para>
        /// <para>Length = 20</para>
        /// <para>Contents = AlphaNumeric - blank (space filled for length) if not used</para>
        /// <para>Example = Add padding for length if not used</para>
        /// </summary>
        public virtual string CompanyDiscretionaryData { get; set; }
        /// <summary>
        /// <para>Name = CompanyIdentification</para>
        /// <para>Required = true</para>
        /// <para>Position = 41-50</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric No Hyphens - a '1' or space preceding the company's tax id number.</para>
        /// <para>Example = 1231234567</para>
        /// </summary>
        public virtual string CompanyIdentification { get; set; }
        /// <summary>
        /// <para>Name = StandardEntryClass</para>
        /// <para>Required = true</para>
        /// <para>Position = 51-53</para>
        /// <para>Length = 3</para>
        /// <para>Contents = Value from AchStandardEntryCodes enum</para>
        /// <para>Example = PPD</para>
        /// </summary>
        public virtual AchStandardEntryCodes? StandardEntryClass { get; set; }
        /// <summary>
        /// <para>Name = CompanyEntryDescription</para>
        /// <para>Required = true</para>
        /// <para>Position = 54-63</para>
        /// <para>Length = 10</para>
        /// <para>Contents = AlphaNumeric - The type of transaction ex: commission, payroll,clubs,auto debit, etc.</para>
        /// <para>Example = COMMISSION</para>
        /// </summary>
        public virtual string CompanyEntryDescription { get; set; }
        /// <summary>
        /// <para>Name = CompanyDescriptiveDate</para>
        /// <para>Required = false</para>
        /// <para>Position = 64-69</para>
        /// <para>Length = 6</para>
        /// <para>Contents = YYMMDD - six digit date, year first. Blank if not used (space filled for length).</para>
        /// <para>Example =</para>
        /// </summary>
        public virtual string CompanyDescriptiveDate { get; set; }
        /// <summary>
        /// <para>Name = EffectiveEntryDate</para>
        /// <para>Required = true</para>
        /// <para>Position = 70-75</para>
        /// <para>Length = 6</para>
        /// <para>Contents = YYMMDD - six digit date, year first.</para>
        /// <para>Example = 031219</para>
        /// </summary>
        public virtual string EffectiveEntryDate { get; set; }
        /// <summary>
        /// <para>Name = SettleDate</para>
        /// <para>Required = false</para>
        /// <para>Position = 76-78</para>
        /// <para>Length = 3</para>
        /// <para>Contents = Numeric - Julian Date (Leave Blank - space filled for length.)</para>
        /// <para>Example =</para>
        /// </summary>
        public virtual string SettleDate { get; set; }
        /// <summary>
        /// <para>Name = OriginatorStatusCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 79</para>
        /// <para>Length = 1</para>
        /// <para>Contents = '1'</para>
        /// <para>Example = 1</para>
        /// </summary>
        public virtual char OriginatorStatusCode { get; set; }
        /// <summary>
        /// <para>Name = OriginatorDFIIdentification</para>
        /// <para>Required = true</para>
        /// <para>Position = 80-87</para>
        /// <para>Length = 8</para>
        /// <para>Contents = The banks transit/routing number</para>
        /// <para>Example = 03130142</para>
        /// </summary>
        public virtual string OriginatorDFIIdentification { get; set; }
        /// <summary>
        /// <para>Name = BatchNumber</para>
        /// <para>Required = true</para>
        /// <para>Position = 88-94</para>
        /// <para>Length = 7</para>
        /// <para>Contents = Numeric Zero filled. Increase by 1 for each batch header record.</para>
        /// <para>Example = 0000001</para>
        /// </summary>
        public virtual string BatchNumber { get; set; }         
    }
}