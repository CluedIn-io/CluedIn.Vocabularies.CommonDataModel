using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFirstContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFirstContainerAttributeEntityVocabulary()
        {
            VocabularyName = "WHS First Container Attribute Entity";
            KeyPrefix = "commonDataModel.whsfirstcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFirstContainerAttributeEntity";

            AddGroup("WHSFirstContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}