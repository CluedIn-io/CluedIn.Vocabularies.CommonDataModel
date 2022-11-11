using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingCodeCustomFieldEntityVocabulary : SimpleVocabulary
    {
        public CustBillingCodeCustomFieldEntityVocabulary()
        {
            VocabularyName = "CustBillingCodeCustomFieldEntity";
            KeyPrefix = "commonDataModel.custbillingcodecustomfieldentity";
            KeySeparator = ".";
            Grouping = "/CustBillingCodeCustomFieldEntity";

            AddGroup("CustBillingCodeCustomFieldEntity Details", group =>
            {
                CustBillingCodeVersion = group.Add(new VocabularyKey(nameof(CustBillingCodeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustCustomField = group.Add(new VocabularyKey(nameof(CustCustomField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCode = group.Add(new VocabularyKey(nameof(CustBillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomField = group.Add(new VocabularyKey(nameof(CustomField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustBillingCodeVersion { get; private set; }
        public VocabularyKey CustCustomField { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey CustBillingCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey BillingCode { get; private set; }
        public VocabularyKey CustomField { get; private set; }


    }
}