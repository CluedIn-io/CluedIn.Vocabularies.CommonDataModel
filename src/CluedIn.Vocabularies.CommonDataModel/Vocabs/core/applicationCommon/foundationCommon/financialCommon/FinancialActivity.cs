using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FinancialCommon
{
    public class FinancialActivityVocabulary : SimpleVocabulary
    {
        public FinancialActivityVocabulary()
        {
            VocabularyName = "Financial Activity";
            KeyPrefix = "commonDataModel.financialactivity.financialcommon";
            KeySeparator = ".";
            Grouping = "/FinancialActivity";

            AddGroup("FinancialActivity Details for FinancialCommon", group =>
            {
			    FinancialActivityId = group.Add(new VocabularyKey(nameof(FinancialActivityId), "Financial Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), "Ledger Dimension Display Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), "Transaction Currency Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), "AccountingCurrencyAmount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), "AccountingDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FinancialActivityId { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
    }
}