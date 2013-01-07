#region Using Statements

using System;
using System.ComponentModel;

#endregion

namespace ACH.Model.Enums
{
    [Serializable]
    public enum AchReturnCodes
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        /// <summary>
        /// Insufficient Funds
        /// </summary>
        [Description("Insufficient Funds")]
        R01,
        /// <summary>
        /// Account Closed
        /// </summary>
        [Description("Account Closed")]
        R02,
        /// <summary>
        /// No Account/Unable to Locate Account
        /// </summary>
        [Description("No Account/Unable to Locate Account")]
        R03,
        /// <summary>
        /// Invalid Account Number
        /// </summary>
        [Description("Invalid Account Number")]
        R04,
        /// <summary>
        /// Unauthorized Debit to Consumer Account
        /// </summary>
        [Description("Unauthorized Debit to Consumer Account")]
        R05,
        /// <summary>
        /// Returned per ODFIs Request
        /// </summary>
        [Description("Returned per ODFIs Request")]
        R06,
        /// <summary>
        /// Authorization Revoked by Customer
        /// </summary>
        [Description("Authorization Revoked by Customer")]
        R07,
        /// <summary>
        /// Payment Stopped or Stop Payment on Item
        /// </summary>
        [Description("Payment Stopped or Stop Payment on Item")]
        R08,
        /// <summary>
        /// Uncollected Funds
        /// </summary>
        [Description("Uncollected Funds")]
        R09,
        /// <summary>
        /// Customer Advises Not Authorized
        /// </summary>
        [Description("Customer Advises Not Authorized")]
        R10,
        /// <summary>
        /// Check Truncation Entry Return
        /// </summary>
        [Description("Check Truncation Entry Return")]
        R11,
        /// <summary>
        /// Branch sold to another DFI
        /// </summary>
        [Description("Branch sold to another DFI")]
        R12,
        /// <summary>
        /// RDFI not qualified to participate
        /// </summary>
        [Description("RDFI not qualified to participate")]
        R13,
        /// <summary>
        /// Representment payee deceased or unable to continuein that capacity
        /// </summary>
        [Description("Representment payee deceased or unable to continuein that capacity")]
        R14,
        /// <summary>
        /// Beneficiary of account holder deceased
        /// </summary>
        [Description("Beneficiary of account holder deceased")]
        R15,
        /// <summary>
        /// Account Frozen
        /// </summary>
        [Description("Account Frozen")]
        R16,
        /// <summary>
        /// File record edit criteria
        /// </summary>
        [Description("File record edit criteria")]
        R17,
        /// <summary>
        /// Improper effective entry date
        /// </summary>
        [Description("Improper effective entry date")]
        R18,
        /// <summary>
        /// Amount field error
        /// </summary>
        [Description("Amount field error")]
        R19,
        /// <summary>
        /// Non-Transaction Account
        /// </summary>
        [Description("Non-Transaction Account")]
        R20,
        /// <summary>
        /// Invalid company identification
        /// </summary>
        [Description("Invalid company identification")]
        R21,
        /// <summary>
        /// Invalid individual ID number
        /// </summary>
        [Description("Invalid individual ID number")]
        R22,
        /// <summary>
        /// Credit entry refused by receiver
        /// </summary>
        [Description("Credit entry refused by receiver")]
        R23,
        /// <summary>
        /// Duplicate entry
        /// </summary>
        [Description("Duplicate entry")]
        R24,
        /// <summary>
        /// Addenda error
        /// </summary>
        [Description("Addenda error")]
        R25,
        /// <summary>
        /// Mandatory field error
        /// </summary>
        [Description("Mandatory field error")]
        R26,
        /// <summary>
        /// Trace number error
        /// </summary>
        [Description("Trace number error")]
        R27,
        /// <summary>
        /// Routing number check digit error
        /// </summary>
        [Description("Routing number check digit error")]
        R28,
        /// <summary>
        /// Corporate customer advises not authorized
        /// </summary>
        [Description("Corporate customer advises not authorized")]
        R29,
        /// <summary>
        /// RDFI not participant in check truncation program
        /// </summary>
        [Description("RDFI not participant in check truncation program")]
        R30,
        /// <summary>
        /// Permissible return entry
        /// </summary>
        [Description("Permissible return entry")]
        R31,
        /// <summary>
        /// RDFI non-settlement
        /// </summary>
        [Description("RDFI non-settlement")]
        R32,
        /// <summary>
        /// Return of XCK entry
        /// </summary>
        [Description("Return of XCK entry")]
        R33,
        /// <summary>
        /// Limited participation DFI
        /// </summary>
        [Description("Limited participation DFI")]
        R34,
        /// <summary>
        /// Return of improper debit entry
        /// </summary>
        [Description("Return of improper debit entry")]
        R35,
        /// <summary>
        /// Return of improper credit entry
        /// </summary>
        [Description("Return of improper credit entry")]
        R36,
        /// <summary>
        /// Stop Payment on Source Document
        /// </summary>
        [Description("Stop Payment on Source Document")]
        R38,
        /// <summary>
        /// Return of ENR entry by Federal Government Agency (ENR Only)
        /// </summary>
        [Description("Return of ENR entry by Federal Government Agency (ENR Only)")]
        R40,
        /// <summary>
        /// Invalid transaction code (ENR Only)
        /// </summary>
        [Description("Invalid transaction code (ENR Only)")]
        R41,
        /// <summary>
        /// Routing number/check digit error (ENR only)
        /// </summary>
        [Description("Routing number/check digit error (ENR only)")]
        R42,
        /// <summary>
        /// Invalid DFI account number (ENR only)
        /// </summary>
        [Description("Invalid DFI account number (ENR only)")]
        R43,
        /// <summary>
        /// Invalid individual ID number (ENR only)
        /// </summary>
        [Description("Invalid individual ID number (ENR only)")]
        R44,
        /// <summary>
        /// Invalid individual name/company name (ENR only)
        /// </summary>
        [Description("Invalid individual name/company name (ENR only)")]
        R45,
        /// <summary>
        /// Invalid representative payee indicator (ENR only)
        /// </summary>
        [Description("Invalid representative payee indicator (ENR only)")]
        R46,
        /// <summary>
        /// Duplicate enrollment
        /// </summary>
        [Description("Duplicate enrollment")]
        R47,
        /// <summary>
        /// State Law Affecting RCK Acceptance
        /// </summary>
        [Description("State Law Affecting RCK Acceptance")]
        R50,
        /// <summary>
        /// Item is Ineligible, Notice Not Provided, Signature not genuine
        /// </summary>
        [Description("Item is Ineligible, Notice Not Provided, Signature not genuine")]
        R51,
        /// <summary>
        /// Stop Payment on Item
        /// </summary>
        [Description("Stop Payment on Item")]
        R52,
        /// <summary>
        /// Misrouted return
        /// </summary>
        [Description("Misrouted return")]
        R61,
        /// <summary>
        /// Incorrect trace number
        /// </summary>
        [Description("Incorrect trace number")]
        R62,
        /// <summary>
        /// Incorrect dollar amount
        /// </summary>
        [Description("Incorrect dollar amount")]
        R63,
        /// <summary>
        /// Incorrect individual identification
        /// </summary>
        [Description("Incorrect individual identification")]
        R64,
        /// <summary>
        /// Incorrect transaction code
        /// </summary>
        [Description("Incorrect transaction code")]
        R65,
        /// <summary>
        /// Incorrect company identification
        /// </summary>
        [Description("Incorrect company identification")]
        R66,
        /// <summary>
        /// Duplicate return
        /// </summary>
        [Description("Duplicate return")]
        R67,
        /// <summary>
        /// Untimely Return
        /// </summary>
        [Description("Untimely Return")]
        R68,
        /// <summary>
        /// Multiple Errors
        /// </summary>
        [Description("Multiple Errors")]
        R69,
        /// <summary>
        /// Permissible return entry not accepted
        /// </summary>
        [Description("Permissible return entry not accepted")]
        R70,
        /// <summary>
        /// Misrouted dishonored return
        /// </summary>
        [Description("Misrouted dishonored return")]
        R71,
        /// <summary>
        /// Untimely dishonored return
        /// </summary>
        [Description("Untimely dishonored return")]
        R72,
        /// <summary>
        /// Timely original return
        /// </summary>
        [Description("Timely original return")]
        R73,
        /// <summary>
        /// Corrected return
        /// </summary>
        [Description("Corrected return")]
        R74,
        /// <summary>
        /// Cross-Border Payment Coding Error
        /// </summary>
        [Description("Cross-Border Payment Coding Error")]
        R80,
        /// <summary>
        /// Non-Participant in Cross-Border Program
        /// </summary>
        [Description("Non-Participant in Cross-Border Program")]
        R81,
        /// <summary>
        /// Invalid Foreign Receiving DFI Identification
        /// </summary>
        [Description("Invalid Foreign Receiving DFI Identification")]
        R82,
        /// <summary>
        /// Foreign Receiving DFI Unable to Settle
        /// </summary>
        [Description("Foreign Receiving DFI Unable to Settle")]
        R83,
        /// <summary>
        /// Incorrect DFI Account Number
        /// </summary>        
        [Description("Incorrect DFI Account Number")]
        C01,
        /// <summary>
        /// Incorrect Transit/Routing Number
        /// </summary>
        [Description("Incorrect Transit/Routing Number")]
        C02,
        /// <summary>
        /// Incorrect Transit/Routing Number and Incorrect DFI Account Number
        /// </summary>
        [Description("Incorrect Transit/Routing Number and Incorrect DFI Account Number")]
        C03,
        /// <summary>
        /// Incorrect Individual Name
        /// </summary>
        [Description("Incorrect Individual Name")]
        C04,
        /// <summary>
        /// Incorrect Transaction Code
        /// </summary>
        [Description("Incorrect Transaction Code")]
        C05,
        /// <summary>
        /// Incorrect DFI Account Number and Incorrect Transaction Code
        /// </summary>
        [Description("Incorrect DFI Account Number and Incorrect Transaction Code")]
        C06,
        /// <summary>
        /// Incorrect Transit/Routing Number, Incorrect DFI Account Number, and Incorrect Transaction Code
        /// </summary>
        [Description("Incorrect Transit/Routing Number, Incorrect DFI Account Number, and Incorrect Transaction Code")]
        C07,
        /// <summary>
        /// Reserved
        /// </summary>
        [Description("Reserved")]
        C08,
        /// <summary>
        /// Incorrect Individual Identification Number
        /// </summary>
        [Description("Incorrect Individual Identification Number")]
        C09,
        /// <summary>
        /// Incorrect Company Name
        /// </summary>
        [Description("Incorrect Company Name")]
        C10,
        /// <summary>
        /// Incorrect Company Identification
        /// </summary>
        [Description("Incorrect Company Identification")]
        C11,
        /// <summary>
        /// Incorrect Company Name and Company Identification
        /// </summary>
        [Description("Incorrect Company Name and Company Identification")]
        C12,
        /// <summary>
        /// Addenda Format Error
        /// </summary>
        [Description("Addenda Format Error")]
        C13,
        /// <summary>
        /// Misrouted Notification of Change
        /// </summary>
        [Description("Misrouted Notification of Change")]
        C61,
        /// <summary>
        /// Incorrect Trace Number
        /// </summary>
        [Description("Incorrect Trace Number")]
        C62,
        /// <summary>
        /// Incorrect Company Identification Number
        /// </summary>
        [Description("Incorrect Company Identification Number")]
        C63,
        /// <summary>
        /// Incorrect Individual Identification Number
        /// </summary>
        [Description("Incorrect Individual Identification Number")]
        C64,
        /// <summary>
        /// Incorrectly Formatted Corrected Data
        /// </summary>
        [Description("Incorrectly Formatted Corrected Data")]
        C65,
        /// <summary>
        /// Incorrect Discretionary Data
        /// </summary>
        [Description("Incorrect Discretionary Data")]
        C66,
        /// <summary>
        /// Routing Number Not From Original Entry Detail Record
        /// </summary>
        [Description("Routing Number Not From Original Entry Detail Record")]
        C67,
        /// <summary>
        /// DFI Account Number Not From Original Entry Detail Record
        /// </summary>
        [Description("DFI Account Number Not From Original Entry Detail Record")]
        C68,
        /// <summary>
        /// Incorrect Transaction Code
        /// </summary>
        [Description("Incorrect Transaction Code")]
        C69
    }
}