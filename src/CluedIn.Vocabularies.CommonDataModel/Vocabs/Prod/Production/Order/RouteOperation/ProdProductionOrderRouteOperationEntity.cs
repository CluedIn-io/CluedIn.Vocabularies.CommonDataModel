using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionOrderRouteOperationEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionOrderRouteOperationEntityVocabulary()
        {
            VocabularyName = "ProdProductionOrderRouteOperationEntity";
            KeyPrefix = "commonDataModel.prodproductionorderrouteoperationentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionOrderRouteOperationEntity";

            AddGroup("ProdProductionOrderRouteOperationEntity Details", group =>
            {
                AccumulatedScrapPercentage = group.Add(new VocabularyKey(nameof(AccumulatedScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingOperationResourceId = group.Add(new VocabularyKey(nameof(CostingOperationResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedProcessTime = group.Add(new VocabularyKey(nameof(EstimatedProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedOperationQuantity = group.Add(new VocabularyKey(nameof(EstimatedOperationQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedSetupTime = group.Add(new VocabularyKey(nameof(EstimatedSetupTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConstantConsumptionReleased = group.Add(new VocabularyKey(nameof(IsConstantConsumptionReleased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationCompleted = group.Add(new VocabularyKey(nameof(IsOperationCompleted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOperationStarted = group.Add(new VocabularyKey(nameof(IsOperationStarted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLinkType = group.Add(new VocabularyKey(nameof(NextOperationLinkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationNumber = group.Add(new VocabularyKey(nameof(NextOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationPriority = group.Add(new VocabularyKey(nameof(OperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsTimeToHourConversionFactor = group.Add(new VocabularyKey(nameof(OperationsTimeToHourConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverlapOperationQuantity = group.Add(new VocabularyKey(nameof(OverlapOperationQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessCostCategoryId = group.Add(new VocabularyKey(nameof(ProcessCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessQuantity = group.Add(new VocabularyKey(nameof(ProcessQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessTime = group.Add(new VocabularyKey(nameof(ProcessTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProductionOrderNumber = group.Add(new VocabularyKey(nameof(LineProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessProductionJobId = group.Add(new VocabularyKey(nameof(ProcessProductionJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessCompletionPercentage = group.Add(new VocabularyKey(nameof(ProcessCompletionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadPercentage = group.Add(new VocabularyKey(nameof(LoadPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityCostCategoryId = group.Add(new VocabularyKey(nameof(QuantityCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueTimeAfter = group.Add(new VocabularyKey(nameof(QueueTimeAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueueTimeBefore = group.Add(new VocabularyKey(nameof(QueueTimeBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceQuantity = group.Add(new VocabularyKey(nameof(ResourceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteGroupId = group.Add(new VocabularyKey(nameof(RouteGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationRateMethod = group.Add(new VocabularyKey(nameof(RouteOperationRateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationRemainderStatus = group.Add(new VocabularyKey(nameof(RouteOperationRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationSequence = group.Add(new VocabularyKey(nameof(RouteOperationSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteType = group.Add(new VocabularyKey(nameof(RouteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledFromDate = group.Add(new VocabularyKey(nameof(ScheduledFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledFromTime = group.Add(new VocabularyKey(nameof(ScheduledFromTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupProductionJobId = group.Add(new VocabularyKey(nameof(SetupProductionJobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapPercentage = group.Add(new VocabularyKey(nameof(ScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupCompletionPercentage = group.Add(new VocabularyKey(nameof(SetupCompletionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupCostCategoryId = group.Add(new VocabularyKey(nameof(SetupCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupTime = group.Add(new VocabularyKey(nameof(SetupTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferBatchQuantity = group.Add(new VocabularyKey(nameof(TransferBatchQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitTime = group.Add(new VocabularyKey(nameof(TransitTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WrkCtrActivityRequirementSetRecId = group.Add(new VocabularyKey(nameof(WrkCtrActivityRequirementSetRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityToCopyRecordId = group.Add(new VocabularyKey(nameof(ActivityToCopyRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccumulatedScrapPercentage { get; private set; }
        public VocabularyKey CostingOperationResourceId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey EstimatedProcessTime { get; private set; }
        public VocabularyKey EstimatedOperationQuantity { get; private set; }
        public VocabularyKey EstimatedSetupTime { get; private set; }
        public VocabularyKey IsConstantConsumptionReleased { get; private set; }
        public VocabularyKey IsOperationCompleted { get; private set; }
        public VocabularyKey IsOperationStarted { get; private set; }
        public VocabularyKey NextOperationLinkType { get; private set; }
        public VocabularyKey NextOperationNumber { get; private set; }
        public VocabularyKey OperationId { get; private set; }
        public VocabularyKey OperationNumber { get; private set; }
        public VocabularyKey OperationPriority { get; private set; }
        public VocabularyKey OperationsTimeToHourConversionFactor { get; private set; }
        public VocabularyKey OverlapOperationQuantity { get; private set; }
        public VocabularyKey ProcessCostCategoryId { get; private set; }
        public VocabularyKey ProcessQuantity { get; private set; }
        public VocabularyKey ProcessTime { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey LineProductionOrderNumber { get; private set; }
        public VocabularyKey ProcessProductionJobId { get; private set; }
        public VocabularyKey ProcessCompletionPercentage { get; private set; }
        public VocabularyKey LoadPercentage { get; private set; }
        public VocabularyKey QuantityCostCategoryId { get; private set; }
        public VocabularyKey QueueTimeAfter { get; private set; }
        public VocabularyKey QueueTimeBefore { get; private set; }
        public VocabularyKey ResourceQuantity { get; private set; }
        public VocabularyKey RouteGroupId { get; private set; }
        public VocabularyKey RouteOperationRateMethod { get; private set; }
        public VocabularyKey RouteOperationRemainderStatus { get; private set; }
        public VocabularyKey RouteOperationSequence { get; private set; }
        public VocabularyKey RouteType { get; private set; }
        public VocabularyKey ScheduledFromDate { get; private set; }
        public VocabularyKey ScheduledFromTime { get; private set; }
        public VocabularyKey SetupProductionJobId { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey ScheduledEndTime { get; private set; }
        public VocabularyKey ScrapPercentage { get; private set; }
        public VocabularyKey SetupCompletionPercentage { get; private set; }
        public VocabularyKey SetupCostCategoryId { get; private set; }
        public VocabularyKey SetupTime { get; private set; }
        public VocabularyKey TransferBatchQuantity { get; private set; }
        public VocabularyKey TransitTime { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey WrkCtrActivityRequirementSetRecId { get; private set; }
        public VocabularyKey ActivityToCopyRecordId { get; private set; }


    }
}