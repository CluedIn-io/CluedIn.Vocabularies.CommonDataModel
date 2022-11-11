using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingCodeRateEntityVocabulary : SimpleVocabulary
    {
        public CustBillingCodeRateEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustBillingCodeRateEntity";
            KeyPrefix = "commonDataModel.custbillingcoderateentity";
            KeySeparator = ".";
            Grouping = "/CustBillingCodeRateEntity";

            AddGroup("Common Data Model CustBillingCodeRateEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCodeVersion = group.Add(new VocabularyKey(nameof(CustBillingCodeVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCode = group.Add(new VocabularyKey(nameof(CustBillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CustBillingCodeVersion { get; private set; }
        public VocabularyKey CustBillingCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey BillingCode { get; private set; }


    }
}