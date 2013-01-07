using System;
using System.Diagnostics;
using ACH.Shared;

namespace ACH.Model
{
    [Serializable]
    [DebuggerDisplay("RecordTypeCode = {RecordTypeCode}, PriorityCode = {PriorityCode}, ImmediateDestination = {ImmediateDestination}, ImmediateOrigin = {ImmediateOrigin}, FileCreationDate = {FileCreationDate}, FileCreationTime = {FileCreationTime}, FileIdModifier = {FileIdModifier}, RecordSize = {RecordSize}, BlockingFactor = {BlockingFactor}, FormatCode = {FormatCode}, ImmediateDestinationName = {ImmediateDestinationName}, ImmediateOriginName = {ImmediateOriginName}, ReferenceCode = {ReferenceCode}")]
    public class AchFileHeaderRecord : BusinessEntity
    {

        /// <summary>
        /// <para>Name = RecordTypeCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 1</para>
        /// <para>Length = 1</para>
        /// <para>Contents = '1'</para>
        /// <para>Example = 1</para>
        /// </summary>
        public virtual char RecordTypeCode { get; set; }
        /// <summary>
        /// <para>Name = PriorityCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 2-3</para>
        /// <para>Length = 2</para>
        /// <para>Contents = '01'</para>
        /// <para>Example = 01</para>
        /// </summary>
        public virtual string PriorityCode { get; set; }
        /// <summary>
        /// <para>Name = ImmediateDestination</para>
        /// <para>Required = true</para>
        /// <para>Position = 4-13</para>
        /// <para>Length = 10</para>
        /// <para>Contents = A space preceding the bank's transit/routing number with check digit.</para>
        /// <para>Example = 031301422</para>
        /// </summary>
        public virtual string ImmediateDestination { get; set; }
        /// <summary>
        /// <para>Name = ImmediateOrigin</para>
        /// <para>Required = true</para>
        /// <para>Position = 14-23</para>
        /// <para>Length = 10</para>
        /// <para>Contents = Numeric No Hyphens - A '1' or space preceding the company's tax id number.</para>
        /// <para>Example = 1231234567</para>
        /// </summary>
        public virtual string ImmediateOrigin { get; set; }
        /// <summary>
        /// <para>Name = FileCreationDate</para>
        /// <para>Required = true</para>
        /// <para>Position = 24-29</para>
        /// <para>Length = 6</para>
        /// <para>Contents = YYMMDD - six digit date, year first.</para>
        /// <para>Example = 031217</para>
        /// </summary>
        public virtual string FileCreationDate { get; set; }
        /// <summary>
        /// <para>Name = FileCreationTime</para>
        /// <para>Required = false</para>
        /// <para>Position = 30-33</para>
        /// <para>Length = 4</para>
        /// <para>Contents = HHMM - 24-hour time (blank if not used, space filled for length)</para>
        /// <para>Example = 0900</para>
        /// </summary>
        public virtual string FileCreationTime { get; set; }
        /// <summary>
        /// <para>Name = FileIdModifier</para>
        /// <para>Required = true</para>
        /// <para>Position = 34</para>
        /// <para>Length = 1</para>
        /// <para>Contents = Caps or Numeric - A-Z or 0-9</para>
        /// <para>Example = A</para>
        /// </summary>
        public virtual string FileIdModifier { get; set; }
        /// <summary>
        /// <para>Name = RecordSize</para>
        /// <para>Required = true</para>
        /// <para>Position = 35-37</para>
        /// <para>Length = 3</para>
        /// <para>Contents = '094'</para>
        /// <para>Example = 094</para>
        /// </summary>
        public virtual int RecordSize { get; set; }
        /// <summary>
        /// <para>Name = BlockingFactor</para>
        /// <para>Required = true</para>
        /// <para>Position = 38-39</para>
        /// <para>Length = 2</para>
        /// <para>Contents = '10'</para>
        /// <para>Example = 10</para> 
        /// </summary>
        public virtual int BlockingFactor { get; set; }
        /// <summary>
        /// <para>Name = FormatCode</para>
        /// <para>Required = true</para>
        /// <para>Position = 40</para>
        /// <para>Length = 1</para>
        /// <para>Contents = '1'</para>
        /// <para>Example = 1</para> 
        /// </summary>
        public virtual char FormatCode { get; set; }
        /// <summary>
        /// <para>Name = ImmediateDestinationName</para>
        /// <para>Required = true</para>
        /// <para>Position = 41-63</para>
        /// <para>Length = 23</para>
        /// <para>Contents = AlphaNumeric - The name of the bank receiving the file.</para>
        /// <para>Example = FULTON BANK</para>
        /// </summary>
        public virtual string ImmediateDestinationName { get; set; }
        /// <summary>
        /// <para>Name = ImmediateOriginName</para>
        /// <para>Required = true</para>
        /// <para>Position = 64-86</para>
        /// <para>Length = 23</para>
        /// <para>Contents = AlphaNumeric - The name of the company sending or creating the file.</para>
        /// <para>Example = RITTER IM</para>
        /// </summary>
        public virtual string ImmediateOriginName { get; set; }
        /// <summary>
        /// <para>Name = ReferenceCode</para>
        /// <para>Required = false</para>
        /// <para>Position = 87-94</para>
        /// <para>Length = 8</para>
        /// <para>Contents = AlphaNumeric - Blank if not used (space filled for length.</para>
        /// <para>Example = 00000001</para>
        /// </summary>
        public virtual string ReferenceCode { get; set; }

    }
}