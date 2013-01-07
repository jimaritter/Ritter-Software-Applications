#region Using Statements

using System;
using System.ComponentModel;

#endregion

namespace ACH.Model.Enums
{
    [Serializable]
    public enum AchTransactionCodes
    {
        [Description("This will be returned if GetValueOrDefault is called on a nullable enum")]
        Null = 0,
        /// <summary>
        /// Checking Deposit/Credit
        /// </summary>
        [Description("Checking Deposit/Credit")]
        CheckingDepositCredit = 22,
        /// <summary>
        /// Checking Prenote
        /// </summary>
        [Description("Checking Prenote Deposit/Credit")]
        CheckingPrenoteDepositCredit = 23,
        /// <summary>
        /// Checking Withdrawal/Debit
        /// </summary>
        [Description("Checking Withdrawal/Debit")]
        CheckingWithdrawalDebit = 27,
        /// <summary>
        /// Checking Prenote
        /// </summary>
        [Description("Prenote Checking Withdrawal/Debit")]
        CheckingPrenoteWithdrawalDebit = 28,
        /// <summary>
        /// Savings Depostit/Credit
        /// </summary>
        [Description("Savings Depostit/Credit")]
        SavingsDepositCredit = 32,
        /// <summary>
        /// Savings Prenote Deposit/Credit
        /// </summary>
        [Description("Savings Prenote Deposit/Credit")]
        SavingsPrenoteDepositCredit = 33,
        /// <summary>
        /// Savings Withdrawal/Debit
        /// </summary>
        [Description("Savings Withdrawal/Debit")]
        SavingsWithdrawalDebit = 37,
        /// <summary>
        /// Savings Prenote
        /// </summary>
        [Description("Savings Prenote")]
        SavingsPrenote = 38     
    }
}