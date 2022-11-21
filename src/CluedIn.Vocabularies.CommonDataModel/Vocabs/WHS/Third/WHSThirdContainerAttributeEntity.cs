using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSThirdContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSThirdContainerAttributeEntityVocabulary()
        {
            VocabularyName = "WHS Third Container Attribute Entity";
            KeyPrefix = "commonDataModel.whsthirdcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSThirdContainerAttributeEntity";

            AddGroup("WHSThirdContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}