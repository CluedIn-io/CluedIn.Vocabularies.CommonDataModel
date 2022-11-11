using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventFundEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventFundEntityVocabulary()
        {
            VocabularyName = "TAMTradeAllowanceAgreementMerchandisingEventFundEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingeventfundentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventFundEntity";

            AddGroup("TAMTradeAllowanceAgreementMerchandisingEventFundEntity Details", group =>
            {
                PromotionFundId = group.Add(new VocabularyKey(nameof(PromotionFundId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAllocationPercentage = group.Add(new VocabularyKey(nameof(CostAllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PromotionFundId { get; private set; }
        public VocabularyKey CostAllocationPercentage { get; private set; }
        public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }


    }
}