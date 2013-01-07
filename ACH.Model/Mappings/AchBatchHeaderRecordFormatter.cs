using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchBatchHeaderRecordFormatter : FixedLengthMap<AchBatchHeaderRecord>
    {
       public AchBatchHeaderRecordFormatter()
       {
           Map(x => x.RecordTypeCode).Length(1).Trailing();
           Map(x => x.ServiceClassCode).Length(3).Trailing();
           Map(x => x.CompanyName).Length(16).Trailing();
           Map(x => x.CompanyDiscretionaryData).Length(20).Trailing();
           Map(x => x.CompanyIdentification).Length(10).Leading().PaddingCharacter((char)32);
           Map(x => x.StandardEntryClass).Length(3).Trailing();
           Map(x => x.CompanyEntryDescription).Length(10).Trailing();
           Map(x => x.CompanyDescriptiveDate).Length(6).Trailing();
           Map(x => x.EffectiveEntryDate).Length(6).Trailing();
           Map(x => x.SettleDate).Length(3).Trailing();
           Map(x => x.OriginatorStatusCode).Length(1).Trailing();
           Map(x => x.OriginatorDFIIdentification).Length(8).Trailing();
           Map(x => x.BatchNumber).Length(7).Leading().PaddingCharacter((char)48);
       } 
    }
}