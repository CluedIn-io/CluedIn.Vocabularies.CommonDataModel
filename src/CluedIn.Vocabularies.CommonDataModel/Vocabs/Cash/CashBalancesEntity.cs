using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashBalancesEntityVocabulary : SimpleVocabulary
    {
        public CashBalancesEntityVocabulary()
        {
            VocabularyName = "Common Data Model CashBalancesEntity";
            KeyPrefix = "commonDataModel.cashbalancesentity";
            KeySeparator = ".";
            Grouping = "/CashBalancesEntity";

            AddGroup("Common Data Model CashBalancesEntity Details", group =>
            {
                Cash = group.Add(new VocabularyKey(nameof(Cash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateAdjustmentAmount = group.Add(new VocabularyKey(nameof(ExchangeRateAdjustmentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Cash { get; private set; }
        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey ExchangeRateAdjustmentAmount { get; private set; }


    }
}