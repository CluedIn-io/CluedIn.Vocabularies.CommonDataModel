using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSSecondContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSSecondContainerAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSSecondContainerAttributeEntity";
            KeyPrefix = "commonDataModel.whssecondcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSSecondContainerAttributeEntity";

            AddGroup("Common Data Model WHSSecondContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }


    }
}