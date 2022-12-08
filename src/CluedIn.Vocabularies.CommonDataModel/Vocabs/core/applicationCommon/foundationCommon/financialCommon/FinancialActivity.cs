using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FinancialCommon
{
    public class FinancialActivityVocabulary : SimpleVocabulary
    {
        public FinancialActivityVocabulary()
        {
            VocabularyName = "Financial Activity";
            KeyPrefix = "commonDataModel.financialactivity.financialcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FinancialActivity;

            AddGroup("FinancialActivity Details for FinancialCommon", group =>
            {
			    FinancialActivityId = group.Add(new VocabularyKey(nameof(FinancialActivityId), "Financial Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), "Ledger Dimension Display Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyCode = group.Add(new VocabularyKey(nameof(TransactionCurrencyCode), "Transaction Currency Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), "AccountingCurrencyAmount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), "AccountingDate", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="MainAccountCategoryKey"/> to Vocab 'MainAccountCategory.cdm.json/MainAccountCategory' with Property 'MainAccountCategoryId'
            ///Property <see cref="MainAccountKey"/> to Vocab 'MainAccount.cdm.json/MainAccount' with Property 'MainAccountId'
            ///Property <see cref="CompanyKey"/> to Vocab '/core/applicationCommon/foundationCommon/Company.cdm.json/Company' with Property 'CompanyId'
            ///Property <see cref="TransactionCurrencyKey"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="FiscalCalendarPeriodKey"/> to Vocab 'FiscalCalendarPeriod.cdm.json/FiscalCalendarPeriod' with Property 'FiscalCalendarPeriodId'
            ///Property <see cref="LedgerId"/> to Vocab 'Ledger.cdm.json/Ledger' with Property 'LedgerId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey FinancialActivityId { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TransactionCurrencyCode { get; private set; }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
    }
}