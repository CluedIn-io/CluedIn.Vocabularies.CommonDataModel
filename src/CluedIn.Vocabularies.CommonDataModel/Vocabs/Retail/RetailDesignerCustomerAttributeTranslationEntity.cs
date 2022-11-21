using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDesignerCustomerAttributeTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailDesignerCustomerAttributeTranslationEntityVocabulary()
        {
            VocabularyName = "Retail Designer Customer Attribute Translation Entity";
            KeyPrefix = "commonDataModel.retaildesignercustomerattributetranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailDesignerCustomerAttributeTranslationEntity";

            AddGroup("RetailDesignerCustomerAttributeTranslationEntity Details", group =>
            {
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedAttributeFriendlyName = group.Add(new VocabularyKey(nameof(TranslatedAttributeFriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAttributeFriendlyName = group.Add(new VocabularyKey(nameof(DefaultAttributeFriendlyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedAttributeFriendlyName { get; private set; }
        public VocabularyKey DefaultAttributeFriendlyName { get; private set; }
    }
}