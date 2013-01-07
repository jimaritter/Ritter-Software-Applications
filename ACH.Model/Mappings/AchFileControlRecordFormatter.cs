using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchFileControlRecordFormatter : FixedLengthMap<AchFileControlRecord>
    {
        public AchFileControlRecordFormatter()
        {
            Map(x => x.RecordTypeCode).Length(1).Trailing();
            Map(x => x.BatchCount).Length(6).Leading().PaddingCharacter((char)48);
            Map(x => x.BlockCount).Length(6).Leading().PaddingCharacter((char)48);
            Map(x => x.EntryAddendaCount).Length(8).Leading().PaddingCharacter((char)48);
            Map(x => x.EntryHash).Length(10).Leading().PaddingCharacter((char)48);
            Map(x => x.TotalDebitEntryDollarAmount).Length(12).Leading().PaddingCharacter((char)48);
            Map(x => x.TotalCreditDollarAmount).Length(12).Leading().PaddingCharacter((char)48);
            Map(x => x.Reserved).Length(39).PaddingCharacter((char)32);
        }
    }
}