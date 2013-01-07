#region Using Statements

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ACH.FileGeneration.Converters;
using ACH.Model.Enums;
using ACH.Model.Mappings;
using ACH.Shared;

#endregion

namespace ACH.Model
{
    public class AchAgentCommissionModel : IAgentCommissionModel
    {
        #region Readonly & Static Fields

        private readonly AchSettingsValues _achSettingsValues;
        private readonly IAchCommissionDataProvider _localeProvider;
        private readonly StringBuilder _stringACHFileOutput;

        #endregion

        #region C'tors

        public AchAgentCommissionModel(IAchCommissionDataProvider localeProvider)
        {
            _localeProvider = localeProvider;
            _stringACHFileOutput = new StringBuilder();
            _achSettingsValues = new AchSettingsValues();
        }

        #endregion

        //TODO: Pass in submitDateId

        #region Instance Methods

        private string CreateAchEntryDetailRecords(AchFile achFile, string submitDateId)
        {
            IList<AchGetCommissionData> list = _localeProvider.GetCommissionData(submitDateId);
            var converter = new FixedLengthConverter();
            //var outputentryDetailRecord = new ArrayList();
            int x = 0;
            try
            {
                if (list != null)
                {
                    foreach (AchEntryDetailRecord record in list.Select(row => new AchEntryDetailRecord
                                                                                   {
                                                                                       RecordTypeCode = '6',
                                                                                       TransactionCode = GetTransactionCodeTypeByIdentificationNumber((row.IndividualIdentificationNumber)),
                                                                                       ReceivingDFIIdentification = row.ReceivingDFIIdentification,
                                                                                       CheckDigit = row.CheckDigit,
                                                                                       DFIAccountNumber = row.DFIAccountNumber,
                                                                                       DollarAmount = row.SumOfNetCommission.ToString().Replace(".", ""),
                                                                                       IndividualIdentificationNumber = row.IndividualIdentificationNumber,
                                                                                       IndividualName = row.IndividualName,
                                                                                       DiscreteData = "",
                                                                                       AddendaRecordIndicator = "0",
                                                                                       TraceNumber = achFile.BatchHeaderRecord.OriginatorDFIIdentification,
                                                                                       TraceNumberFiller = (x++).ToString()
                                                                                   })
                        )

                    {
                        achFile.EntryDetailRecord.Add(record);
                        return converter.Render<AchEntryDetailRecord, AchEntryDetailRecordFormatter>(record);
                    }
                    return "";
                }
                return "";
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        private string CreateFileHeader(AchFile achFile)
        {
            var converter = new FixedLengthConverter();
            try
            {
                achFile.FileHeaderRecord.RecordTypeCode = AchSettingsValues.FileHeaderRecordRecordTypeCode;
                achFile.FileHeaderRecord.PriorityCode = AchSettingsValues.FileHeaderRecordPriorityCode;
                achFile.FileHeaderRecord.ImmediateDestination = AchSettingsValues.FileHeaderRecordImmediateDestination;
                achFile.FileHeaderRecord.ImmediateOrigin = AchSettingsValues.FileHeaderRecordImmediateOrigin;
                achFile.FileHeaderRecord.FileCreationDate = _achSettingsValues.FileHeaderRecordFileCreationDate();
                achFile.FileHeaderRecord.FileCreationTime = AchSettingsValues.FileHeaderRecordFileCreationTime();
                achFile.FileHeaderRecord.FileIdModifier = AchSettingsValues.FileHeaderRecordFileIdModifier;
                achFile.FileHeaderRecord.RecordSize = AchSettingsValues.FileHeaderRecordRecordSize;
                achFile.FileHeaderRecord.BlockingFactor = AchSettingsValues.BlockingFactor;
                achFile.FileHeaderRecord.FormatCode = AchSettingsValues.FormatCode;
                achFile.FileHeaderRecord.ImmediateDestinationName = AchSettingsValues.FileHeaderRecordImmediateDestinationName;
                achFile.FileHeaderRecord.ImmediateOriginName = AchSettingsValues.FileHeaderRecordImmediateOriginName;
                achFile.FileHeaderRecord.ReferenceCode = AchSettingsValues.FileHeaderRecordReferenceCode();
                return converter.Render<AchFileHeaderRecord, AchFileHeaderRecordFormatter>(achFile.FileHeaderRecord);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        private string CreateHeaderRecord(AchFile achFile)
        {
            var converter = new FixedLengthConverter();
            try
            {
                achFile.BatchHeaderRecord.RecordTypeCode = AchSettingsValues.BatchHeaderRecordRecordTypeCode;
                achFile.BatchHeaderRecord.ServiceClassCode = (int) AchServiceClassCodes.CreditsOnly;
                achFile.BatchHeaderRecord.CompanyName = AchSettingsValues.BatchHeaderRecordCompanyName;
                achFile.BatchHeaderRecord.CompanyDiscretionaryData = AchSettingsValues.BatchHeaderRecordCompanyDiscretionaryData;
                achFile.BatchHeaderRecord.CompanyIdentification = AchSettingsValues.BatchHeaderRecordCompanyIdentification;
                achFile.BatchHeaderRecord.StandardEntryClass = EnumerationParser.Parse<AchStandardEntryCodes?>("PPD");
                achFile.BatchHeaderRecord.CompanyEntryDescription = AchSettingsValues.BatchHeaderRecordCompanyEntryDescription;
                achFile.BatchHeaderRecord.CompanyDescriptiveDate = AchSettingsValues.BatchHeaderRecordCompanyDescriptiveDate;
                achFile.BatchHeaderRecord.EffectiveEntryDate = _achSettingsValues.BatchHeaderRecordEffectiveEntryDate();
                achFile.BatchHeaderRecord.SettleDate = "";
                achFile.BatchHeaderRecord.OriginatorStatusCode = Convert.ToChar("1");
                achFile.BatchHeaderRecord.OriginatorDFIIdentification = "03130142";
                achFile.BatchHeaderRecord.BatchNumber = "1";
                return converter.Render<AchBatchHeaderRecord, AchBatchHeaderRecordFormatter>(achFile.BatchHeaderRecord);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        #endregion

        #region IAgentCommissionModel Members

        public AchFile GenerateAchFile(string submitDateId)
        {
            var achFile = new AchFile();
            _stringACHFileOutput.AppendLine(CreateFileHeader(achFile));
            _stringACHFileOutput.AppendLine(CreateHeaderRecord(achFile));
            _stringACHFileOutput.Append(CreateAchEntryDetailRecords(achFile, submitDateId));
            CalculateBatchControl(achFile);
            _stringACHFileOutput.AppendLine(CreateBatchControlRecord(achFile));
            _stringACHFileOutput.AppendLine(CreateFileControlRecord(achFile));
            _stringACHFileOutput.Append(CreateFillerLines(achFile));
            return achFile;
        }

        public void WriteNachaToDisk()
        {
            if (_stringACHFileOutput != null) GenerateNachaFile(_stringACHFileOutput.ToString());
        }

        public void Save(AchFile achFile)
        {
            if (achFile == null) return;
            _localeProvider.Save(achFile);
        }

        #endregion

        #region Class Methods

        private static void CalculateBatchControl(AchFile achFile)
        {
            try
            {
                int currentIndex = -1;

                if (achFile.EntryDetailRecord == null)
                {
                    //TODO: Add code to handle null EntryDetailRecord
                }
                else
                {
                    int count = achFile.EntryDetailRecord.Count;

                    //Used to get total number of '6' records. Zero filled.
                    achFile.EntryAddendaCount = achFile.EntryDetailRecord.Count + 1;

                    //TODO: Comment what this is
                    string tempBlockCount = ((double) (achFile.EntryAddendaCount + 4)/10).ToString("0");

                    achFile.BlockCount = Convert.ToInt64(tempBlockCount);

                    long remainder;

                    Math.DivRem((achFile.EntryAddendaCount + 4), 10, out remainder);

                    achFile.NumberOfFillerLines = remainder;

                    //Used to calculate EntryHash for the '8' Record
                    achFile.BatchCount = 1;
                    achFile.EntryHash = 0;

                    //Used to calculate the total Credit Dollar Amount
                    achFile.CreditDollarAmount = 0;

                    achFile.TraceNumber = 0000001;

                    foreach (AchEntryDetailRecord renderedEntry in achFile.EntryDetailRecord)
                    {
                        if (currentIndex < count)
                        {
                            //Add up total of ReceivingDFIIdentification from field 3 of '6' record
                            achFile.EntryHash += Convert.ToDouble(renderedEntry.ReceivingDFIIdentification);
                            achFile.TraceNumber++;

                            if (!achFile.IsPreNote)
                            {
                                switch (renderedEntry.TransactionCode)
                                {
                                    case (int) AchTransactionCodes.CheckingDepositCredit:
                                        achFile.CreditDollarAmount += Convert.ToDouble(renderedEntry.DollarAmount);
                                        break;
                                    case (int) AchTransactionCodes.CheckingWithdrawalDebit:
                                        achFile.DebitDollarAmount += Convert.ToDouble(renderedEntry.DollarAmount);
                                        break;
                                    case (int) AchTransactionCodes.CheckingPrenoteDepositCredit:
                                        achFile.CreditDollarAmount = 0;
                                        achFile.DebitDollarAmount = 0;
                                        break;
                                }
                            }
                            else
                            {
                                switch (renderedEntry.TransactionCode)
                                {
                                    case (int) AchTransactionCodes.CheckingPrenoteDepositCredit:
                                        achFile.CreditDollarAmount = 0;
                                        break;
                                    case (int) AchTransactionCodes.CheckingPrenoteWithdrawalDebit:
                                        achFile.DebitDollarAmount = 0;
                                        break;
                                    default:
                                        achFile.CreditDollarAmount = 0;
                                        achFile.DebitDollarAmount = 0;
                                        break;
                                }
                            }
                        }
                        //counter++;
                        currentIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Need to add logging/error message
                achFile.EntryAddendaCount = 0;
                achFile.EntryHash = 0;
                achFile.CreditDollarAmount = 0;
                achFile.DebitDollarAmount = 0;
                throw new Exception(ex.Message);
            }
        }

        private static string CreateBatchControlRecord(AchFile achFile)
        {
            var converter = new FixedLengthConverter();
            try
            {
                achFile.BatchControlRecord.RecordTypeCode = '8';
                achFile.BatchControlRecord.ServiceClassCode = (int) AchServiceClassCodes.CreditsOnly;
                achFile.BatchControlRecord.EntryAddendaCount = achFile.EntryAddendaCount.ToString();
                achFile.BatchControlRecord.EntryHash = achFile.EntryHash.ToString();
                achFile.BatchControlRecord.TotalDebitEntyDollarAmount = achFile.DebitDollarAmount.ToString();
                achFile.BatchControlRecord.TotalCreditEntryDollarAmount = achFile.CreditDollarAmount.ToString();
                achFile.BatchControlRecord.CompanyIdentification = achFile.BatchHeaderRecord.CompanyIdentification;
                achFile.BatchControlRecord.MessageAuthenticationCode = "";
                achFile.BatchControlRecord.Reserved = "";
                achFile.BatchControlRecord.OriginatingDFIIdentification = achFile.BatchHeaderRecord.OriginatorDFIIdentification;
                achFile.BatchControlRecord.BatchNumber = achFile.BatchHeaderRecord.BatchNumber;
                return converter.Render<AchBatchControlRecord, AchBatchControlRecordFormatter>(achFile.BatchControlRecord);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        private static string CreateFileControlRecord(AchFile achFile)
        {
            var converter = new FixedLengthConverter();

            try
            {
                achFile.FileControlRecord.RecordTypeCode = '9';
                achFile.FileControlRecord.BatchCount = "000001";
                achFile.FileControlRecord.BlockCount = achFile.BlockCount.ToString();
                achFile.FileControlRecord.EntryAddendaCount = achFile.EntryAddendaCount.ToString();
                achFile.FileControlRecord.EntryHash = achFile.EntryHash.ToString();
                achFile.FileControlRecord.TotalDebitEntryDollarAmount = achFile.BatchControlRecord.TotalDebitEntyDollarAmount;
                achFile.FileControlRecord.TotalCreditDollarAmount = achFile.BatchControlRecord.TotalCreditEntryDollarAmount;
                achFile.FileControlRecord.Reserved = "";
                return converter.Render<AchFileControlRecord, AchFileControlRecordFormatter>(achFile.FileControlRecord);
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        private static string CreateFillerLines(AchFile achFile)
        {
            var converter = new FixedLengthConverter();
            achFile.FileControlRecord.FillerLines = achFile.NumberOfFillerLines.ToString();
            return converter.Render<AchFileControlRecord, AchFileControlFillerFormatter>(achFile.FileControlRecord);
        }

        private static void GenerateNachaFile(string strValue)
        {
            if (strValue == null) return;
            DirectoryInfo directoryInfo =
                Directory.CreateDirectory(string.Format(AchSettingsValues.FolderName, DateTime.Now.ToString("yyMMdd")));

            using (
                StreamWriter sw =
                    File.CreateText(directoryInfo.FullName + @"\" +
                                    string.Format("RITTERINSURANCEACH" + AchSettingsValues.FileName,
                                                  DateTime.Now.ToString("yyMMddHHmm"))))
            {
                sw.Write(strValue);
                sw.Close();
            }
        }

        private static int GetTransactionCodeTypeByIdentificationNumber(string id)
        {
            switch (id)
            {
                case "260000997":
                    return (int) AchTransactionCodes.CheckingWithdrawalDebit;
                default:
                    return (int) AchTransactionCodes.CheckingDepositCredit;
            }
        }

        #endregion
    }
}