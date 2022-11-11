using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceEntityVocabulary()
        {
            VocabularyName = "OpResOperationsResourceEntity";
            KeyPrefix = "commonDataModel.opresoperationsresourceentity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceEntity";

            AddGroup("OpResOperationsResourceEntity Details", group =>
            {
                BatchCapacity = group.Add(new VocabularyKey(nameof(BatchCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchTransferQuantity = group.Add(new VocabularyKey(nameof(BatchTransferQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capacity = group.Add(new VocabularyKey(nameof(Capacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapacityUnit = group.Add(new VocabularyKey(nameof(CapacityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationQueueTimeAfter = group.Add(new VocabularyKey(nameof(DefaultOperationQueueTimeAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationQueueTimeBefore = group.Add(new VocabularyKey(nameof(DefaultOperationQueueTimeBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationRunTime = group.Add(new VocabularyKey(nameof(DefaultOperationRunTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationSetupTime = group.Add(new VocabularyKey(nameof(DefaultOperationSetupTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationTimeToHoursConversionFactor = group.Add(new VocabularyKey(nameof(DefaultOperationTimeToHoursConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOperationTransitTime = group.Add(new VocabularyKey(nameof(DefaultOperationTransitTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProcessQuantity = group.Add(new VocabularyKey(nameof(DefaultProcessQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EfficiencyPercentage = group.Add(new VocabularyKey(nameof(EfficiencyPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasFiniteSchedulingCapacity = group.Add(new VocabularyKey(nameof(HasFiniteSchedulingCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBottleneckResource = group.Add(new VocabularyKey(nameof(IsBottleneckResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExclusiveResource = group.Add(new VocabularyKey(nameof(IsExclusiveResource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationSchedulingPercentage = group.Add(new VocabularyKey(nameof(OperationSchedulingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityCostCategoryId = group.Add(new VocabularyKey(nameof(QuantityCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceType = group.Add(new VocabularyKey(nameof(OperationsResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuntimeCostCategoryId = group.Add(new VocabularyKey(nameof(RuntimeCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapPercentage = group.Add(new VocabularyKey(nameof(ScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupCostCategoryId = group.Add(new VocabularyKey(nameof(SetupCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsScheduledUsingFiniteProperty = group.Add(new VocabularyKey(nameof(IsScheduledUsingFiniteProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ResourceWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                RouteGroupId = group.Add(new VocabularyKey(nameof(RouteGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchCapacity { get; private set; }
        public VocabularyKey BatchTransferQuantity { get; private set; }
        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey CapacityUnit { get; private set; }
        public VocabularyKey DefaultOperationQueueTimeAfter { get; private set; }
        public VocabularyKey DefaultOperationQueueTimeBefore { get; private set; }
        public VocabularyKey DefaultOperationRunTime { get; private set; }
        public VocabularyKey DefaultOperationSetupTime { get; private set; }
        public VocabularyKey DefaultOperationTimeToHoursConversionFactor { get; private set; }
        public VocabularyKey DefaultOperationTransitTime { get; private set; }
        public VocabularyKey DefaultProcessQuantity { get; private set; }
        public VocabularyKey EfficiencyPercentage { get; private set; }
        public VocabularyKey HasFiniteSchedulingCapacity { get; private set; }
        public VocabularyKey IsBottleneckResource { get; private set; }
        public VocabularyKey IsExclusiveResource { get; private set; }
        public VocabularyKey OperationSchedulingPercentage { get; private set; }
        public VocabularyKey QuantityCostCategoryId { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceName { get; private set; }
        public VocabularyKey OperationsResourceType { get; private set; }
        public VocabularyKey RuntimeCostCategoryId { get; private set; }
        public VocabularyKey ScrapPercentage { get; private set; }
        public VocabularyKey SetupCostCategoryId { get; private set; }
        public VocabularyKey IsScheduledUsingFiniteProperty { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey ResourceWorkerPersonnelNumber { get; private set; }
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
        public VocabularyKey RouteGroupId { get; private set; }


    }
}