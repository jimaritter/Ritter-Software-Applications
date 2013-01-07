using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchEntryDetailRecordFormatter : FixedLengthMap<AchEntryDetailRecord>
    {

        public AchEntryDetailRecordFormatter()
        {
            Map(x => x.RecordTypeCode).Length(1).Leading();
            Map(x => x.TransactionCode).Length(2).Leading();
            Map(x => x.ReceivingDFIIdentification).Length(8).Leading().PaddingCharacter((char)48);
            Map(x => x.CheckDigit).Length(1).Leading();
            Map(x => x.DFIAccountNumber).Length(17).Leading().PaddingCharacter((char)32);
            Map(x => x.DollarAmount).Length(10).Leading().PaddingCharacter((char)48);
            Map(x => x.IndividualIdentificationNumber).Trailing().Length(15).PaddingCharacter((char)32);
            Map(x => x.IndividualName).Length(22).Trailing().PaddingCharacter((char)32);
            Map(x => x.DiscreteData).Length(2).Leading().PaddingCharacter((char)48);
            Map(x => x.AddendaRecordIndicator).Length(1).Leading();
            Map(x => x.TraceNumber).Length(8).Trailing().PaddingCharacter((char)48);
            Map(x => x.TraceNumberFiller).Length(7).Leading().PaddingCharacter((char)48);
        }

    }
}
