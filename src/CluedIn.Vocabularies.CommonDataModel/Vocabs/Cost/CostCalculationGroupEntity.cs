using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostCalculationGroupEntityVocabulary : SimpleVocabulary
    {
        public CostCalculationGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CostCalculationGroupEntity";
            KeyPrefix = "commonDataModel.costcalculationgroupentity";
            KeySeparator = ".";
            Grouping = "/CostCalculationGroupEntity";

            AddGroup("Common Data Model CostCalculationGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCostCalculationMethod = group.Add(new VocabularyKey(nameof(UnitCostCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeUnitCostCalculationMethod = group.Add(new VocabularyKey(nameof(AlternativeUnitCostCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceCalculationMethod = group.Add(new VocabularyKey(nameof(SalesPriceCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StopExplosionAtItem = group.Add(new VocabularyKey(nameof(StopExplosionAtItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalculationIssueNoActiveAssignedBOMWarning = group.Add(new VocabularyKey(nameof(WillCostCalculationIssueNoActiveAssignedBOMWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalculationIssueNoActiveAssignedRouteWarning = group.Add(new VocabularyKey(nameof(WillCostCalculationIssueNoActiveAssignedRouteWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalculationIssueZeroConsumptionWarning = group.Add(new VocabularyKey(nameof(WillCostCalculationIssueZeroConsumptionWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalulationIssueOperationsResourceRequirementNotMetWarning = group.Add(new VocabularyKey(nameof(WillCostCalulationIssueOperationsResourceRequirementNotMetWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCostCalulationIssueZeroCostPriceWarning = group.Add(new VocabularyKey(nameof(WillCostCalulationIssueZeroCostPriceWarning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowWarningIfCostPriceCalculationOlderThanDays = group.Add(new VocabularyKey(nameof(ShowWarningIfCostPriceCalculationOlderThanDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowWarningIfContributionMarginPercentageLowerThan = group.Add(new VocabularyKey(nameof(ShowWarningIfContributionMarginPercentageLowerThan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey UnitCostCalculationMethod { get; private set; }
        public VocabularyKey AlternativeUnitCostCalculationMethod { get; private set; }
        public VocabularyKey SalesPriceCalculationMethod { get; private set; }
        public VocabularyKey StopExplosionAtItem { get; private set; }
        public VocabularyKey WillCostCalculationIssueNoActiveAssignedBOMWarning { get; private set; }
        public VocabularyKey WillCostCalculationIssueNoActiveAssignedRouteWarning { get; private set; }
        public VocabularyKey WillCostCalculationIssueZeroConsumptionWarning { get; private set; }
        public VocabularyKey WillCostCalulationIssueOperationsResourceRequirementNotMetWarning { get; private set; }
        public VocabularyKey WillCostCalulationIssueZeroCostPriceWarning { get; private set; }
        public VocabularyKey ShowWarningIfCostPriceCalculationOlderThanDays { get; private set; }
        public VocabularyKey ShowWarningIfContributionMarginPercentageLowerThan { get; private set; }


    }
}