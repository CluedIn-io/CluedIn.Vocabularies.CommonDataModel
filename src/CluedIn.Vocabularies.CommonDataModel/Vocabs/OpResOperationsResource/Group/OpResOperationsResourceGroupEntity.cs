using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceGroupEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceGroupEntityVocabulary()
        {
            VocabularyName = "Op Res Operations Resource Group Entity";
            KeyPrefix = "commonDataModel.opresoperationsresourcegroupentity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceGroupEntity";

            AddGroup("OpResOperationsResourceGroupEntity Details", group =>
            {
                BatchCapacity = group.Add(new VocabularyKey(nameof(BatchCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capacity = group.Add(new VocabularyKey(nameof(Capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacityUnit = group.Add(new VocabularyKey(nameof(CapacityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasFiniteSchedulingCapacity = group.Add(new VocabularyKey(nameof(HasFiniteSchedulingCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputWarehouseId = group.Add(new VocabularyKey(nameof(InputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputWarehouseLocationId = group.Add(new VocabularyKey(nameof(InputWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBottleneckResourceGroup = group.Add(new VocabularyKey(nameof(IsBottleneckResourceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationSchedulingPercentage = group.Add(new VocabularyKey(nameof(OperationSchedulingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutputWarehouseId = group.Add(new VocabularyKey(nameof(OutputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutputWarehouseLocationId = group.Add(new VocabularyKey(nameof(OutputWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkCell = group.Add(new VocabularyKey(nameof(IsWorkCell), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionUnitId = group.Add(new VocabularyKey(nameof(ProductionUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityCostCategoryId = group.Add(new VocabularyKey(nameof(QuantityCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuntimeCostCategoryId = group.Add(new VocabularyKey(nameof(RuntimeCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapPercentage = group.Add(new VocabularyKey(nameof(ScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupCostCategoryId = group.Add(new VocabularyKey(nameof(SetupCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceIssueLedgerDimension = group.Add(new VocabularyKey(nameof(ResourceIssueLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceIssueOffsetLedgerDimension = group.Add(new VocabularyKey(nameof(ResourceIssueOffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPIssueLedgerDimension = group.Add(new VocabularyKey(nameof(WIPIssueLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPValuationLedgerDimension = group.Add(new VocabularyKey(nameof(WIPValuationLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceIssueLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ResourceIssueLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceIssueOffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ResourceIssueOffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPIssueLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(WIPIssueLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPValuationLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(WIPValuationLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BatchCapacity { get; private set; }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey CapacityUnit { get; private set; }
        public VocabularyKey HasFiniteSchedulingCapacity { get; private set; }
        public VocabularyKey InputWarehouseId { get; private set; }
        public VocabularyKey InputWarehouseLocationId { get; private set; }
        public VocabularyKey IsBottleneckResourceGroup { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey OperationSchedulingPercentage { get; private set; }
        public VocabularyKey OutputWarehouseId { get; private set; }
        public VocabularyKey OutputWarehouseLocationId { get; private set; }
        public VocabularyKey IsWorkCell { get; private set; }
        public VocabularyKey ProductionUnitId { get; private set; }
        public VocabularyKey QuantityCostCategoryId { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey RuntimeCostCategoryId { get; private set; }
        public VocabularyKey ScrapPercentage { get; private set; }
        public VocabularyKey SetupCostCategoryId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ResourceIssueLedgerDimension { get; private set; }
        public VocabularyKey ResourceIssueOffsetLedgerDimension { get; private set; }
        public VocabularyKey WIPIssueLedgerDimension { get; private set; }
        public VocabularyKey WIPValuationLedgerDimension { get; private set; }
        public VocabularyKey ResourceIssueLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ResourceIssueOffsetLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey WIPIssueLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey WIPValuationLedgerDimensionDisplayValue { get; private set; }
    }
}