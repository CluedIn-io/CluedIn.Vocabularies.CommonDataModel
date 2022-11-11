using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventLumpSumEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventLumpSumEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementMerchandisingEventLumpSumEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingeventlumpsumentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventLumpSumEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementMerchandisingEventLumpSumEntity Details", group =>
            {
                SuggestedLumpSumAmount = group.Add(new VocabularyKey(nameof(SuggestedLumpSumAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumDetails = group.Add(new VocabularyKey(nameof(LumpSumDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimPaymentMethod = group.Add(new VocabularyKey(nameof(ClaimPaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumId = group.Add(new VocabularyKey(nameof(LumpSumId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedLumpSumAmount = group.Add(new VocabularyKey(nameof(ApprovedLumpSumAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumApprovalStatus = group.Add(new VocabularyKey(nameof(LumpSumApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccountNum = group.Add(new VocabularyKey(nameof(CustAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAccountNum = group.Add(new VocabularyKey(nameof(VendAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimPaymentRecipientCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ClaimPaymentRecipientCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClaimPaymentRecipientVendorAccountNumber = group.Add(new VocabularyKey(nameof(ClaimPaymentRecipientVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SuggestedLumpSumAmount { get; private set; }
        public VocabularyKey LumpSumDetails { get; private set; }
        public VocabularyKey ClaimPaymentMethod { get; private set; }
        public VocabularyKey LumpSumId { get; private set; }
        public VocabularyKey ApprovedLumpSumAmount { get; private set; }
        public VocabularyKey LumpSumApprovalStatus { get; private set; }
        public VocabularyKey CustAccountNum { get; private set; }
        public VocabularyKey VendAccountNum { get; private set; }
        public VocabularyKey ClaimPaymentRecipientCustomerAccountNumber { get; private set; }
        public VocabularyKey ClaimPaymentRecipientVendorAccountNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }
        public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }


    }
}