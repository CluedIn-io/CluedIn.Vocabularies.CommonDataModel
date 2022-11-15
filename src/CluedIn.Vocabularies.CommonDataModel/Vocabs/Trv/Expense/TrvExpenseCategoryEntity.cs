using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseCategoryEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseCategoryEntityVocabulary()
        {
            VocabularyName = "Trv Expense Category Entity";
            KeyPrefix = "commonDataModel.trvexpensecategoryentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseCategoryEntity";

            AddGroup("TrvExpenseCategoryEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseType = group.Add(new VocabularyKey(nameof(ExpenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCommon = group.Add(new VocabularyKey(nameof(IsCommon), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsImportOnly = group.Add(new VocabularyKey(nameof(IsImportOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInactive = group.Add(new VocabularyKey(nameof(IsInactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemizationMandatory = group.Add(new VocabularyKey(nameof(IsItemizationMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPaymentMethod = group.Add(new VocabularyKey(nameof(DefaultPaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroupIfBilledToEmployee = group.Add(new VocabularyKey(nameof(TaxItemGroupIfBilledToEmployee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsGroup = group.Add(new VocabularyKey(nameof(StatisticsGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpenseCategory { get; private set; }
        public VocabularyKey ExpenseType { get; private set; }
        public VocabularyKey IsCommon { get; private set; }
        public VocabularyKey IsImportOnly { get; private set; }
        public VocabularyKey IsInactive { get; private set; }
        public VocabularyKey IsItemizationMandatory { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey DefaultPaymentMethod { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey TaxItemGroupIfBilledToEmployee { get; private set; }
        public VocabularyKey StatisticsGroup { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
    }
}