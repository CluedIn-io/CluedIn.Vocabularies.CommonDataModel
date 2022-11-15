using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetRegisterEntryLineEntityVocabulary : SimpleVocabulary
    {
        public BudgetRegisterEntryLineEntityVocabulary()
        {
            VocabularyName = "Budget Register Entry Line Entity";
            KeyPrefix = "commonDataModel.budgetregisterentrylineentity";
            KeySeparator = ".";
            Grouping = "/BudgetRegisterEntryLineEntity";

            AddGroup("BudgetRegisterEntryLineEntity Details", group =>
            {
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountType = group.Add(new VocabularyKey(nameof(AmountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetTransactionHeaderRecId = group.Add(new VocabularyKey(nameof(BudgetTransactionHeaderRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryDate = group.Add(new VocabularyKey(nameof(EntryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryNumber = group.Add(new VocabularyKey(nameof(EntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAccountStructure = group.Add(new VocabularyKey(nameof(DimensionAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeInCashFlowForecast = group.Add(new VocabularyKey(nameof(IncludeInCashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLedgerId = group.Add(new VocabularyKey(nameof(PrimaryLedgerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowStatus = group.Add(new VocabularyKey(nameof(WorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetCheckResult = group.Add(new VocabularyKey(nameof(BudgetCheckResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountingCurrencyAmount { get; private set; }
        public VocabularyKey AmountType { get; private set; }
        public VocabularyKey BudgetTransactionHeaderRecId { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey EntryDate { get; private set; }
        public VocabularyKey EntryNumber { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionAccountStructure { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey IncludeInCashFlowForecast { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PrimaryLedgerId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey WorkflowStatus { get; private set; }
        public VocabularyKey BudgetCheckResult { get; private set; }
    }
}