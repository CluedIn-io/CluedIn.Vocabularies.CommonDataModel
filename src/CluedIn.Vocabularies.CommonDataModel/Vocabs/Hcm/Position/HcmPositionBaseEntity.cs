using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionBaseEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionBaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmPositionBaseEntity";
            KeyPrefix = "commonDataModel.hcmpositionbaseentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionBaseEntity";

            AddGroup("Common Data Model HcmPositionBaseEntity Details", group =>
            {
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PositionId { get; private set; }


    }
}