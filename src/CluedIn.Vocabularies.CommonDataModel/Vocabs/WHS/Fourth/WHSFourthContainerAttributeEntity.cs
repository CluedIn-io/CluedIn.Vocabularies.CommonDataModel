using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFourthContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFourthContainerAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSFourthContainerAttributeEntity";
            KeyPrefix = "commonDataModel.whsfourthcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFourthContainerAttributeEntity";

            AddGroup("Common Data Model WHSFourthContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }


    }
}