using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdBatchOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public ProdBatchOrderHeaderEntityVocabulary()
        {
            VocabularyName = "Prod Batch Order Header Entity";
            KeyPrefix = "commonDataModel.prodbatchorderheaderentity";
            KeySeparator = ".";
            Grouping = "/ProdBatchOrderHeaderEntity";

            AddGroup("ProdBatchOrderHeaderEntity Details", group =>
            {
                AreRouteJobsGenerated = group.Add(new VocabularyKey(nameof(AreRouteJobsGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoReservationMode = group.Add(new VocabularyKey(nameof(AutoReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderLedgerPostingRule = group.Add(new VocabularyKey(nameof(BatchOrderLedgerPostingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderLevel = group.Add(new VocabularyKey(nameof(BatchOrderLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderName = group.Add(new VocabularyKey(nameof(BatchOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderNumber = group.Add(new VocabularyKey(nameof(BatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderPriority = group.Add(new VocabularyKey(nameof(BatchOrderPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderProfitSettingMethod = group.Add(new VocabularyKey(nameof(BatchOrderProfitSettingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderStatus = group.Add(new VocabularyKey(nameof(BatchOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderRemainderStatus = group.Add(new VocabularyKey(nameof(BatchOrderRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchSizeCatchWeightQuantity = group.Add(new VocabularyKey(nameof(BatchSizeCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionDensityConversionFactor = group.Add(new VocabularyKey(nameof(ConsumptionDensityConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionDepthConversionFactor = group.Add(new VocabularyKey(nameof(ConsumptionDepthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionHeightConversionFactor = group.Add(new VocabularyKey(nameof(ConsumptionHeightConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionWidthConversionFactor = group.Add(new VocabularyKey(nameof(ConsumptionWidthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidatedBatchOrderNumber = group.Add(new VocabularyKey(nameof(ConsolidatedBatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTime = group.Add(new VocabularyKey(nameof(DeliveryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandBatchOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandBatchOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandBatchOrderLineNumber = group.Add(new VocabularyKey(nameof(DemandBatchOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandBatchOrderHeaderInventoryLotId = group.Add(new VocabularyKey(nameof(DemandBatchOrderHeaderInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandBatchOrderNumber = group.Add(new VocabularyKey(nameof(DemandBatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandInventoryJournalLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandInventoryJournalLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandInventoryJournalNumber = group.Add(new VocabularyKey(nameof(DemandInventoryJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandSalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandSalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandSalesOrderNumber = group.Add(new VocabularyKey(nameof(DemandSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandTransferOrderLineReceivingInventoryLotId = group.Add(new VocabularyKey(nameof(DemandTransferOrderLineReceivingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandTransferOrderNumber = group.Add(new VocabularyKey(nameof(DemandTransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndedDate = group.Add(new VocabularyKey(nameof(EndedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(EstimatedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedDate = group.Add(new VocabularyKey(nameof(EstimatedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedQuantity = group.Add(new VocabularyKey(nameof(EstimatedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GanttChartColorNumber = group.Add(new VocabularyKey(nameof(GanttChartColorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchOrderRouteOperationValid = group.Add(new VocabularyKey(nameof(IsBatchOrderRouteOperationValid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchOrderSchedulingLocked = group.Add(new VocabularyKey(nameof(IsBatchOrderSchedulingLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBulkOrder = group.Add(new VocabularyKey(nameof(IsBulkOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCoByProductVariationAllowed = group.Add(new VocabularyKey(nameof(IsCoByProductVariationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReworkBatchOrder = group.Add(new VocabularyKey(nameof(IsReworkBatchOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTotalCostAllocationEnabled = group.Add(new VocabularyKey(nameof(IsTotalCostAllocationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSchedulingDate = group.Add(new VocabularyKey(nameof(LastSchedulingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSchedulingDateDirection = group.Add(new VocabularyKey(nameof(LastSchedulingDateDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastSchedulingTime = group.Add(new VocabularyKey(nameof(LastSchedulingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentBatchOrderNumber = group.Add(new VocabularyKey(nameof(ParentBatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedReceiptWarehouseId = group.Add(new VocabularyKey(nameof(PlannedReceiptWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedReceiptWarehouseLocationId = group.Add(new VocabularyKey(nameof(PlannedReceiptWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionGroupId = group.Add(new VocabularyKey(nameof(ProductionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPoolId = group.Add(new VocabularyKey(nameof(ProductionPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleasedDate = group.Add(new VocabularyKey(nameof(ReleasedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingReportAsFinishedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingReportAsFinishedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingReportAsFinishedQuantity = group.Add(new VocabularyKey(nameof(RemainingReportAsFinishedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedAsFinishedDate = group.Add(new VocabularyKey(nameof(ReportedAsFinishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ScheduledCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledDate = group.Add(new VocabularyKey(nameof(ScheduledDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartTime = group.Add(new VocabularyKey(nameof(ScheduledStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledStartDate = group.Add(new VocabularyKey(nameof(ScheduledStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledQuantity = group.Add(new VocabularyKey(nameof(ScheduledQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchedulingMethod = group.Add(new VocabularyKey(nameof(SchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreateBatchOrderFormulaLines = group.Add(new VocabularyKey(nameof(SkipCreateBatchOrderFormulaLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreateBatchOrderRouteOperations = group.Add(new VocabularyKey(nameof(SkipCreateBatchOrderRouteOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceFormulaVersionValidityDate = group.Add(new VocabularyKey(nameof(SourceFormulaVersionValidityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceFormulaId = group.Add(new VocabularyKey(nameof(SourceFormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceMasterPlanId = group.Add(new VocabularyKey(nameof(SourceMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourcePlannedOrderNumber = group.Add(new VocabularyKey(nameof(SourcePlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRouteId = group.Add(new VocabularyKey(nameof(SourceRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(StartedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedDate = group.Add(new VocabularyKey(nameof(StartedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedQuantity = group.Add(new VocabularyKey(nameof(StartedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcontractingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcontractingPurchaseOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseReleaseReservationRequirementRule = group.Add(new VocabularyKey(nameof(WarehouseReleaseReservationRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YieldPercentage = group.Add(new VocabularyKey(nameof(YieldPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreRouteJobsGenerated { get; private set; }
        public VocabularyKey AutoReservationMode { get; private set; }
        public VocabularyKey BatchOrderLedgerPostingRule { get; private set; }
        public VocabularyKey BatchOrderLevel { get; private set; }
        public VocabularyKey BatchOrderName { get; private set; }
        public VocabularyKey BatchOrderNumber { get; private set; }
        public VocabularyKey BatchOrderPriority { get; private set; }
        public VocabularyKey BatchOrderProfitSettingMethod { get; private set; }
        public VocabularyKey BatchOrderStatus { get; private set; }
        public VocabularyKey BatchOrderRemainderStatus { get; private set; }
        public VocabularyKey BatchSizeCatchWeightQuantity { get; private set; }
        public VocabularyKey ConsumptionDensityConversionFactor { get; private set; }
        public VocabularyKey ConsumptionDepthConversionFactor { get; private set; }
        public VocabularyKey ConsumptionHeightConversionFactor { get; private set; }
        public VocabularyKey ConsumptionWidthConversionFactor { get; private set; }
        public VocabularyKey ConsolidatedBatchOrderNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DeliveryDate { get; private set; }
        public VocabularyKey DeliveryTime { get; private set; }
        public VocabularyKey DemandBatchOrderLineInventoryLotId { get; private set; }
        public VocabularyKey DemandBatchOrderLineNumber { get; private set; }
        public VocabularyKey DemandBatchOrderHeaderInventoryLotId { get; private set; }
        public VocabularyKey DemandBatchOrderNumber { get; private set; }
        public VocabularyKey DemandInventoryJournalLineInventoryLotId { get; private set; }
        public VocabularyKey DemandInventoryJournalNumber { get; private set; }
        public VocabularyKey DemandSalesOrderLineInventoryLotId { get; private set; }
        public VocabularyKey DemandSalesOrderNumber { get; private set; }
        public VocabularyKey DemandTransferOrderLineReceivingInventoryLotId { get; private set; }
        public VocabularyKey DemandTransferOrderNumber { get; private set; }
        public VocabularyKey EndedDate { get; private set; }
        public VocabularyKey EstimatedCatchWeightQuantity { get; private set; }
        public VocabularyKey EstimatedDate { get; private set; }
        public VocabularyKey EstimatedQuantity { get; private set; }
        public VocabularyKey GanttChartColorNumber { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey IsBatchOrderRouteOperationValid { get; private set; }
        public VocabularyKey IsBatchOrderSchedulingLocked { get; private set; }
        public VocabularyKey IsBulkOrder { get; private set; }
        public VocabularyKey IsCoByProductVariationAllowed { get; private set; }
        public VocabularyKey IsReworkBatchOrder { get; private set; }
        public VocabularyKey IsTotalCostAllocationEnabled { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey LastSchedulingDate { get; private set; }
        public VocabularyKey LastSchedulingDateDirection { get; private set; }
        public VocabularyKey LastSchedulingTime { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey ParentBatchOrderNumber { get; private set; }
        public VocabularyKey PlannedReceiptWarehouseId { get; private set; }
        public VocabularyKey PlannedReceiptWarehouseLocationId { get; private set; }
        public VocabularyKey ProductionGroupId { get; private set; }
        public VocabularyKey ProductionPoolId { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ReleasedDate { get; private set; }
        public VocabularyKey RemainingReportAsFinishedCatchWeightQuantity { get; private set; }
        public VocabularyKey RemainingReportAsFinishedQuantity { get; private set; }
        public VocabularyKey ReportedAsFinishedDate { get; private set; }
        public VocabularyKey ScheduledCatchWeightQuantity { get; private set; }
        public VocabularyKey ScheduledDate { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }
        public VocabularyKey ScheduledEndTime { get; private set; }
        public VocabularyKey ScheduledStartTime { get; private set; }
        public VocabularyKey ScheduledStartDate { get; private set; }
        public VocabularyKey ScheduledQuantity { get; private set; }
        public VocabularyKey SchedulingMethod { get; private set; }
        public VocabularyKey SkipCreateBatchOrderFormulaLines { get; private set; }
        public VocabularyKey SkipCreateBatchOrderRouteOperations { get; private set; }
        public VocabularyKey SourceFormulaVersionValidityDate { get; private set; }
        public VocabularyKey SourceFormulaId { get; private set; }
        public VocabularyKey SourceMasterPlanId { get; private set; }
        public VocabularyKey SourcePlannedOrderNumber { get; private set; }
        public VocabularyKey SourceRouteId { get; private set; }
        public VocabularyKey StartedCatchWeightQuantity { get; private set; }
        public VocabularyKey StartedDate { get; private set; }
        public VocabularyKey StartedQuantity { get; private set; }
        public VocabularyKey SubcontractingPurchaseOrderNumber { get; private set; }
        public VocabularyKey SubcontractingPurchaseOrderLineInventoryLotId { get; private set; }
        public VocabularyKey WarehouseReleaseReservationRequirementRule { get; private set; }
        public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
        public VocabularyKey YieldPercentage { get; private set; }
    }
}