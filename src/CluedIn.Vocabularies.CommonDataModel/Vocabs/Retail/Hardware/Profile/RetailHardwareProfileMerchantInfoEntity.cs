using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailHardwareProfileMerchantInfoEntityVocabulary : SimpleVocabulary
    {
        public RetailHardwareProfileMerchantInfoEntityVocabulary()
        {
            VocabularyName = "Retail Hardware Profile Merchant Info Entity";
            KeyPrefix = "commonDataModel.retailhardwareprofilemerchantinfoentity";
            KeySeparator = ".";
            Grouping = "/RetailHardwareProfileMerchantInfoEntity";

            AddGroup("RetailHardwareProfileMerchantInfoEntity Details", group =>
            {
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecureMerchantProperties = group.Add(new VocabularyKey(nameof(SecureMerchantProperties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MerchantProperties = group.Add(new VocabularyKey(nameof(MerchantProperties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EFT = group.Add(new VocabularyKey(nameof(EFT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey SecureMerchantProperties { get; private set; }
        public VocabularyKey MerchantProperties { get; private set; }
        public VocabularyKey EFT { get; private set; }
    }
}