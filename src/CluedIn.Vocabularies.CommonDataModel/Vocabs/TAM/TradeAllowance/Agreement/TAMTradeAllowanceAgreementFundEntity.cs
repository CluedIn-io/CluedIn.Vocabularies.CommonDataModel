using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementFundEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementFundEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementFundEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementfundentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementFundEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementFundEntity Details", group =>
            {
                PromotionFundId = group.Add(new VocabularyKey(nameof(PromotionFundId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAllocationPercentage = group.Add(new VocabularyKey(nameof(CostAllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PromotionFundId { get; private set; }
        public VocabularyKey CostAllocationPercentage { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}