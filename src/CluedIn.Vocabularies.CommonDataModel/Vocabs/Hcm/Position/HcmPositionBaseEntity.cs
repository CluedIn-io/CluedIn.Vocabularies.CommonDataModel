using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionBaseEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionBaseEntityVocabulary()
        {
            VocabularyName = "Hcm Position Base Entity";
            KeyPrefix = "commonDataModel.hcmpositionbaseentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionBaseEntity";

            AddGroup("HcmPositionBaseEntity Details", group =>
            {
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PositionId { get; private set; }
    }
}