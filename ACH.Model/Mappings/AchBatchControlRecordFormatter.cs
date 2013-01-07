using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchBatchControlRecordFormatter : FixedLengthMap<AchBatchControlRecord>
    {
        public AchBatchControlRecordFormatter()
        {
            Map(x => x.RecordTypeCode).Length(1);
            Map(x => x.ServiceClassCode).Length(3);
            Map(x => x.EntryAddendaCount).Length(6).Leading().PaddingCharacter((char)48);
            Map(x => x.EntryHash).Length(10).Leading().PaddingCharacter((char)48);
            Map(x => x.TotalDebitEntyDollarAmount).Length(12).Leading().PaddingCharacter((char)48);
            Map(x => x.TotalCreditEntryDollarAmount).Length(12).Leading().PaddingCharacter((char)48);
            Map(x => x.CompanyIdentification).Length(10).PaddingCharacter((char)48);
            Map(x => x.MessageAuthenticationCode).Length(19).PaddingCharacter((char)32);
            Map(x => x.Reserved).Length(6).PaddingCharacter((char)32);
            Map(x => x.OriginatingDFIIdentification).Length(8).Leading();
            Map(x => x.BatchNumber).Length(7).Leading().PaddingCharacter((char)48);
        }
    }
}
