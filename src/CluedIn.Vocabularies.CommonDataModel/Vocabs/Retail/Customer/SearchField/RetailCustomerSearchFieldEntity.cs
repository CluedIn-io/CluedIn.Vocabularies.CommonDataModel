using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCustomerSearchFieldEntityVocabulary : SimpleVocabulary
    {
        public RetailCustomerSearchFieldEntityVocabulary()
        {
            VocabularyName = "RetailCustomerSearchFieldEntity";
            KeyPrefix = "commonDataModel.retailcustomersearchfieldentity";
            KeySeparator = ".";
            Grouping = "/RetailCustomerSearchFieldEntity";

            AddGroup("RetailCustomerSearchFieldEntity Details", group =>
            {
                RetailCustomerSearchFieldEnumValue = group.Add(new VocabularyKey(nameof(RetailCustomerSearchFieldEnumValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShortcut = group.Add(new VocabularyKey(nameof(IsShortcut), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailCustomerSearchFieldEnumLabel = group.Add(new VocabularyKey(nameof(RetailCustomerSearchFieldEnumLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanBeRefined = group.Add(new VocabularyKey(nameof(CanBeRefined), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RetailCustomerSearchFieldEnumValue { get; private set; }
        public VocabularyKey IsShortcut { get; private set; }
        public VocabularyKey RetailCustomerSearchFieldEnumLabel { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey CanBeRefined { get; private set; }


    }
}