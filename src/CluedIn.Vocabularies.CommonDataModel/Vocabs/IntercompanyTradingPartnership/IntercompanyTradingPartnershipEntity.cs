using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntercompanyTradingPartnershipEntityVocabulary : SimpleVocabulary
    {
        public IntercompanyTradingPartnershipEntityVocabulary()
        {
            VocabularyName = "Intercompany Trading Partnership Entity";
            KeyPrefix = "commonDataModel.intercompanytradingpartnershipentity";
            KeySeparator = ".";
            Grouping = "/IntercompanyTradingPartnershipEntity";

            AddGroup("IntercompanyTradingPartnershipEntity Details", group =>
            {
                CustomerLegalEntityId = group.Add(new VocabularyKey(nameof(CustomerLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTradingPartnershipActive = group.Add(new VocabularyKey(nameof(IsTradingPartnershipActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTradingPartner_CustomerDataAreaId = group.Add(new VocabularyKey(nameof(CustomerTradingPartner_CustomerDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTradingPartner_TradingPartnerType = group.Add(new VocabularyKey(nameof(CustomerTradingPartner_TradingPartnerType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorTradingPartner_VendorDataAreaId = group.Add(new VocabularyKey(nameof(VendorTradingPartner_VendorDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorTradingPartner_TradingPartnerType = group.Add(new VocabularyKey(nameof(VendorTradingPartner_TradingPartnerType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerLegalEntityId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey VendorLegalEntityId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey IsTradingPartnershipActive { get; private set; }
        public VocabularyKey CustomerTradingPartner_CustomerDataAreaId { get; private set; }
        public VocabularyKey CustomerTradingPartner_TradingPartnerType { get; private set; }
        public VocabularyKey VendorTradingPartner_VendorDataAreaId { get; private set; }
        public VocabularyKey VendorTradingPartner_TradingPartnerType { get; private set; }
    }
}