using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmBudgetCostElementEntityVocabulary : SimpleVocabulary
    {
        public HcmBudgetCostElementEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmBudgetCostElementEntity";
            KeyPrefix = "commonDataModel.hcmbudgetcostelemententity";
            KeySeparator = ".";
            Grouping = "/HcmBudgetCostElementEntity";

            AddGroup("Common Data Model HcmBudgetCostElementEntity Details", group =>
            {
                BudgetCostType = group.Add(new VocabularyKey(nameof(BudgetCostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForecastPositionOverride = group.Add(new VocabularyKey(nameof(ForecastPositionOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnnualLimit = group.Add(new VocabularyKey(nameof(AnnualLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostElementDataAreaId = group.Add(new VocabularyKey(nameof(CostElementDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostElementLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(CostElementLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostElementLedgerDimension = group.Add(new VocabularyKey(nameof(CostElementLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostElementName = group.Add(new VocabularyKey(nameof(CostElementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetCostType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ForecastPositionOverride { get; private set; }
        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey AnnualLimit { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey CostElementDataAreaId { get; private set; }
        public VocabularyKey CostElementLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CostElementLedgerDimension { get; private set; }
        public VocabularyKey CostElementName { get; private set; }


    }
}