using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFourthContainerAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFourthContainerAttributeEntityVocabulary()
        {
            VocabularyName = "WHS Fourth Container Attribute Entity";
            KeyPrefix = "commonDataModel.whsfourthcontainerattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFourthContainerAttributeEntity";

            AddGroup("WHSFourthContainerAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}