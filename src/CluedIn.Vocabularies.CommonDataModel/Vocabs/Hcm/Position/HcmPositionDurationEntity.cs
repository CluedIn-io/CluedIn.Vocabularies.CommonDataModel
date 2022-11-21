using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionDurationEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionDurationEntityVocabulary()
        {
            VocabularyName = "Hcm Position Duration Entity";
            KeyPrefix = "commonDataModel.hcmpositiondurationentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionDurationEntity";

            AddGroup("HcmPositionDurationEntity Details", group =>
            {
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
    }
}