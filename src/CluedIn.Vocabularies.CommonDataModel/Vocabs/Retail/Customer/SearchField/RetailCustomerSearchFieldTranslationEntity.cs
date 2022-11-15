using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCustomerSearchFieldTranslationEntityVocabulary : SimpleVocabulary
    {
        public RetailCustomerSearchFieldTranslationEntityVocabulary()
        {
            VocabularyName = "Retail Customer Search Field Translation Entity";
            KeyPrefix = "commonDataModel.retailcustomersearchfieldtranslationentity";
            KeySeparator = ".";
            Grouping = "/RetailCustomerSearchFieldTranslationEntity";

            AddGroup("RetailCustomerSearchFieldTranslationEntity Details", group =>
            {
                RetailCustomerSearchField = group.Add(new VocabularyKey(nameof(RetailCustomerSearchField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCustomerSearchFieldEnumLabel = group.Add(new VocabularyKey(nameof(RetailCustomerSearchFieldEnumLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RetailCustomerSearchField { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey RetailCustomerSearchFieldEnumLabel { get; private set; }
    }
}