using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchFileHeaderRecordFormatter : FixedLengthMap<AchFileHeaderRecord>
    {
        public AchFileHeaderRecordFormatter()
        {
            Map(x => x.RecordTypeCode).Length(1);
            Map(x => x.PriorityCode).Length(2);
            Map(x => x.ImmediateDestination).Length(10).Leading().PaddingCharacter((char)32);
            Map(x => x.ImmediateOrigin).Length(10).Trailing().PaddingCharacter((char)32);
            Map(x => x.FileCreationDate).Length(6).Trailing();
            Map(x => x.FileCreationTime).Length(4).Trailing();
            Map(x => x.FileIdModifier).Length(1).Trailing();
            Map(x => x.RecordSize).Length(3).Leading().PaddingCharacter((char)48);
            Map(x => x.BlockingFactor).Length(2).Trailing();
            Map(x => x.FormatCode).Length(1).Trailing();
            Map(x => x.ImmediateDestinationName).Length(23).Trailing();
            Map(x => x.ImmediateOriginName).Length(23).Trailing();
            Map(x => x.ReferenceCode).Length(8).Leading().PaddingCharacter((char)48);
        }
    }
}