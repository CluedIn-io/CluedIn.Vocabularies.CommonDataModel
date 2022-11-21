using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionTypeEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionTypeEntityVocabulary()
        {
            VocabularyName = "Hcm Position Type Entity";
            KeyPrefix = "commonDataModel.hcmpositiontypeentity";
            KeySeparator = ".";
            Grouping = "/HcmPositionTypeEntity";

            AddGroup("HcmPositionTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Classification = group.Add(new VocabularyKey(nameof(Classification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionTypeId = group.Add(new VocabularyKey(nameof(PositionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Classification { get; private set; }
        public VocabularyKey PositionTypeId { get; private set; }
    }
}