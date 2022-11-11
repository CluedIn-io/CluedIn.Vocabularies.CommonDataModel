using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementMerchandisingEventEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingevententity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementMerchandisingEventEntity Details", group =>
            {
                EventDescription = group.Add(new VocabularyKey(nameof(EventDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventCostAmount = group.Add(new VocabularyKey(nameof(EventCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardMerchandisingEventCategoryType = group.Add(new VocabularyKey(nameof(StandardMerchandisingEventCategoryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventId = group.Add(new VocabularyKey(nameof(EventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MerchandisingEventCategoryName = group.Add(new VocabularyKey(nameof(MerchandisingEventCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EventDescription { get; private set; }
        public VocabularyKey EventCostAmount { get; private set; }
        public VocabularyKey StandardMerchandisingEventCategoryType { get; private set; }
        public VocabularyKey EventId { get; private set; }
        public VocabularyKey MerchandisingEventCategoryName { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}