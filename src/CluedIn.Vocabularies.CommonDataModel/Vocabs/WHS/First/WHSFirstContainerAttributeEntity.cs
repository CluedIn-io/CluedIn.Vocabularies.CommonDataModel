using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFirstContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFirstContainerAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSFirstContainerAttributeEntity";
            KeyPrefix = "commonDataModel.whsfirstcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFirstContainerAttributeEntity";

            AddGroup("Common Data Model WHSFirstContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }


    }
}