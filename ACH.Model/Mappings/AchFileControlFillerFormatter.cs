using ACH.FileGeneration.FixedLengthGenerator;

namespace ACH.Model.Mappings
{
    public sealed class AchFileControlFillerFormatter : FixedLengthMap<AchFileControlRecord>
    {
        public AchFileControlFillerFormatter()
        {
            Map(x => x.FillerLines).Length(94).PaddingCharacter((char)57);
        }        
    }
}