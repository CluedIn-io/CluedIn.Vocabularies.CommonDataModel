using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerCovForecastActualEntityVocabulary : SimpleVocabulary
    {
        public LedgerCovForecastActualEntityVocabulary()
        {
            VocabularyName = "LedgerCovForecastActualEntity";
            KeyPrefix = "commonDataModel.ledgercovforecastactualentity";
            KeySeparator = ".";
            Grouping = "/LedgerCovForecastActualEntity";

            AddGroup("LedgerCovForecastActualEntity Details", group =>
            {
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountCurrencyCode = group.Add(new VocabularyKey(nameof(BankAccountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountAndBankAccountCurrencyCode = group.Add(new VocabularyKey(nameof(BankAccountAndBankAccountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualBankAccountCurrencyAmount = group.Add(new VocabularyKey(nameof(ActualBankAccountCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastBankAccountCurrencyAmount = group.Add(new VocabularyKey(nameof(ForecastBankAccountCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastEnterpriseCurrencyAmount = group.Add(new VocabularyKey(nameof(ForecastEnterpriseCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEnterpriseCurrencyAmount = group.Add(new VocabularyKey(nameof(ActualEnterpriseCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastAccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(ForecastAccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualAccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(ActualAccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey BankAccountCurrencyCode { get; private set; }
        public VocabularyKey BankAccountAndBankAccountCurrencyCode { get; private set; }
        public VocabularyKey ActualBankAccountCurrencyAmount { get; private set; }
        public VocabularyKey ForecastBankAccountCurrencyAmount { get; private set; }
        public VocabularyKey ForecastEnterpriseCurrencyAmount { get; private set; }
        public VocabularyKey ActualEnterpriseCurrencyAmount { get; private set; }
        public VocabularyKey ForecastAccountingCurrencyAmount { get; private set; }
        public VocabularyKey ActualAccountingCurrencyAmount { get; private set; }


    }
}