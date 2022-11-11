using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCovLiquidityTransactionCurrencyEntityVocabulary : SimpleVocabulary
    {
        public LedgerCovLiquidityTransactionCurrencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerCovLiquidityTransactionCurrencyEntity";
            KeyPrefix = "commonDataModel.ledgercovliquiditytransactioncurrencyentity";
            KeySeparator = ".";
            Grouping = "/LedgerCovLiquidityTransactionCurrencyEntity";

            AddGroup("Common Data Model LedgerCovLiquidityTransactionCurrencyEntity Details", group =>
            {
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceAmount = group.Add(new VocabularyKey(nameof(BalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey BalanceAmount { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey BankAccount { get; private set; }


    }
}