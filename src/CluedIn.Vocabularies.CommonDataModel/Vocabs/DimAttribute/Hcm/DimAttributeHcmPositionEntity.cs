using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeHcmPositionEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeHcmPositionEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeHcmPositionEntity";
            KeyPrefix = "commonDataModel.dimattributehcmpositionentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeHcmPositionEntity";

            AddGroup("Common Data Model DimAttributeHcmPositionEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}