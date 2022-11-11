using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSThirdContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSThirdContainerAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSThirdContainerAttributeEntity";
            KeyPrefix = "commonDataModel.whsthirdcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSThirdContainerAttributeEntity";

            AddGroup("Common Data Model WHSThirdContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }


    }
}