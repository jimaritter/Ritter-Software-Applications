using System;
using System.ComponentModel;

namespace ACH.Model.Enums
{
    [Serializable]
    public enum AchStandardEntryCodes
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        /// <summary>
        /// <remarks>Converted checks received via the US mail or at a dropbox location</remarks>
        /// </summary>
        [Description("Accounts Receivable Check")]
        ARC,
        /// <summary>
        /// <remarks>Converted checks received by merchant at the point-of-purchase or at manned bill payment locations, and processed during back office operations</remarks>
        /// </summary>
        [Description("Back Office Conversion")]
        BOC,
        /// <summary>
        /// <remarks>Transfer of funds between business acounts or to consolidate funds from several accounts of the same business</remarks>
        /// </summary>
        [Description("Cash Concentration or Disbursement")]
        CCD,
        /// <summary>
        /// <remarks>Credit entry initiated by an individual (usually through a bill payment service) used to pay some sort of obligation</remarks>
        /// </summary>
        [Description("Customer Initiated Entry")]
        CIE,
        /// <summary>
        /// <remarks>Payment or collection of obligations between separate businesses</remarks>
        /// </summary>
        [Description("Corporate Trade Exchange")]
        CTX,
        /// <summary>
        /// <remarks>Notice initiated by an agency of the Federal government to advise an RDFI of the death of an individual (Includes addenda record with details)</remarks>
        /// </summary>
        [Description("Death Notification Entry")]
        DNE,
        /// <summary>
        /// <remarks>Entry submitted by Financial Institution to enroll member in direct deposit of Federal government benefit payment</remarks>
        /// </summary>
        [Description("Automated Enrollment Entry")]
        ENR,
        /// <summary>
        /// <remarks>Transaction involving a financial agency’s office that is not located in the territorial jurisdiction of the United States</remarks>
        /// </summary>
        [Description("International ACH Transaction")]
        IAT,
        /// <summary>
        /// <remarks>Converted checks received by merchant at the point-of-sale</remarks>
        /// </summary>
        [Description("Point-of-Purchase Entry")]
        POP,
        /// <summary>
        /// <remarks>Entry initiated by individual at a merchant location using a merchant-issued card for payment of goods or services</remarks>
        /// </summary>
        [Description("Point-of-Sale Entry")]
        POS,
        /// <summary>
        /// <remarks>Recurring entry for direct deposit of payroll, pension, etc., or for direct payment of recurring bills such as utilities, loans, insurance, etc.</remarks>
        /// </summary>
        [Description("Prearranged Payment and Deposit Entry")]
        PPD,
        /// <summary>
        /// <remarks>Merchant collection of checks that had been returned as NSF or Uncollected Funds</remarks>
        /// </summary>
        [Description("Represented Check Entry")]
        RCK,
        /// <summary>
        /// <remarks>Entry submitted pursuant to an oral authorization obtained solely via the telephone</remarks>
        /// </summary>
        [Description("Telephone Authorized Entry")]
        TEL,
        /// <summary>
        /// <remarks>Entry submitted pursuant to an authorization obtained solely via the Internet</remarks>
        /// </summary>
        [Description("Internet Authorized Entry")]
        WEB,
        /// <summary>
        /// <remarks>Replacement entry for check that is lost or destroyed while within the check clearing system</remarks>
        /// </summary>
        [Description("Destroyed Check Entry")]
        XCK

    }
}