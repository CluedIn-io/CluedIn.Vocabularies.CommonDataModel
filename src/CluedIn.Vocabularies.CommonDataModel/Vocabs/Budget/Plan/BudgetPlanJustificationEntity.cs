using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetPlanJustificationEntityVocabulary : SimpleVocabulary
    {
        public BudgetPlanJustificationEntityVocabulary()
        {
            VocabularyName = "Budget Plan Justification Entity";
            KeyPrefix = "commonDataModel.budgetplanjustificationentity";
            KeySeparator = ".";
            Grouping = "/BudgetPlanJustificationEntity";

            AddGroup("BudgetPlanJustificationEntity Details", group =>
            {
                AccountingCurrencyExpenseAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyExpenseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyRevenueAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyRevenueAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScenarioName = group.Add(new VocabularyKey(nameof(ScenarioName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyExpenseAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyExpenseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyRevenueAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyRevenueAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanName = group.Add(new VocabularyKey(nameof(BudgetPlanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibilityCenter = group.Add(new VocabularyKey(nameof(ResponsibilityCenter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetPlanPreparer = group.Add(new VocabularyKey(nameof(BudgetPlanPreparer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountingCurrencyExpenseAmount { get; private set; }
        public VocabularyKey AccountingCurrencyRevenueAmount { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ScenarioName { get; private set; }
        public VocabularyKey TransactionCurrencyExpenseAmount { get; private set; }
        public VocabularyKey TransactionCurrencyRevenueAmount { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey BudgetPlanName { get; private set; }
        public VocabularyKey ResponsibilityCenter { get; private set; }
        public VocabularyKey BudgetPlanPreparer { get; private set; }
        public VocabularyKey Comment { get; private set; }
    }
}