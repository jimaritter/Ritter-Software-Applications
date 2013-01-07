using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchFileMap : FixedLengthMap<AchFile>
    {
        public AchFileMap()
        {
            MapRenderable<AchFileHeaderRecord, AchFileHeaderRecordFormatter>(x => x.FileHeaderRecord);
            MapRenderable<AchBatchHeaderRecord, AchBatchHeaderRecordFormatter>(x => x.BatchHeaderRecord);
            MapEnumerable<AchEntryDetailRecord, AchEntryDetailRecordFormatter>(x => x.EntryDetailRecord);
            MapRenderable<AchBatchControlRecord, AchBatchControlRecordFormatter>(x => x.BatchControlRecord);
            MapRenderable<AchFileControlRecord, AchFileControlRecordFormatter>(x => x.FileControlRecord);
        }
    }
}
