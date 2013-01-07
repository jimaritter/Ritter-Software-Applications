using System;

namespace ACH.Model
{
    public class AchSettingsValues
    {
        #region These constants set the RecordType property (These are in the order that they are presented in the file)
        //public const char FileHeaderType = '1';
        //public const char BatchHeaderType = '5';
        //public const char EntryDetailType = '6';
        //public const char BatchControlType = '8';
        //public const char FileControlType = '9';
        //public const char AddendaType = '7';            
        #endregion

        #region These constants can be used as labels to determine position of values in the records
        //public const string LabelAchHeaderTop = "         1         2         3         4         5         6         7         8         9 ";
        //public const string LabelAchHeaderBottom = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234";
        //public const string LabelLine =            "----------------------------------------------------------------------------------------------";
        #endregion

            public const string FileName = @"{0}.txt";
            public const string FolderName = @"C:\Temp\Commissions\Deposits\{0}";
            
            /// <summary>
            ///  ACH FileHeaderRecord Data
            /// </summary>
            public const char FileHeaderRecordRecordTypeCode = '1';
            public const string FileHeaderRecordPriorityCode = "01";
            public const string FileHeaderRecordImmediateDestination = "031301422";
            public const string FileHeaderRecordImmediateOrigin = "362058600";
            public const string FileHeaderRecordFileIdModifier = "A";
            public const int FileHeaderRecordRecordSize = 94;
            public const int BlockingFactor = 10;
            public const char FormatCode = '1';
            public const string FileHeaderRecordImmediateDestinationName = "FULTON BANK";
            public const string FileHeaderRecordImmediateOriginName = "Ritter Insurance Marketing LLC";        
            public string FileHeaderRecordFileCreationDate()
            {
                return DateTime.Now.ToString("yyMMdd");
            }

            public static string FileHeaderRecordFileCreationTime()
            {
                return DateTime.Now.ToString("HHmm");
            }

            public static string FileHeaderRecordReferenceCode()
            {
                return DateTime.Now.ToString("yyyyMMdd");
            }

            /// <summary>
            /// ACH BatchHeaderRecord Data
            /// </summary>
            public const char BatchHeaderRecordRecordTypeCode = '5';
            public const string BatchHeaderRecordCompanyName = "Ritter Insurance Marketing LLC";
            public const string BatchHeaderRecordCompanyDiscretionaryData = "";
            public const string BatchHeaderRecordCompanyIdentification = "260000997";
            public const string BatchHeaderRecordCompanyEntryDescription = "COMMISSION";
            public const string BatchHeaderRecordCompanyDescriptiveDate = "";

            public string BatchHeaderRecordEffectiveEntryDate()
            {
                return DateTime.Now.ToString("yyMMdd");
            }

            
    }
}