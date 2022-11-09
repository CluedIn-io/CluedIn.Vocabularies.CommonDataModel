using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionOrderHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdProductionOrderHeaderEntity";
            KeyPrefix = "commonDataModel.prodproductionorderheaderentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionOrderHeaderEntity";

            AddGroup("Common Data Model ProdProductionOrderHeaderEntity Details", group =>
            {
                AreRouteJobsGenerated = group.Add(new VocabularyKey(nameof(AreRouteJobsGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoReservationMode = group.Add(new VocabularyKey(nameof(AutoReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTime = group.Add(new VocabularyKey(nameof(DeliveryTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandInventoryJournalLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandInventoryJournalLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandInventoryJournalNumber = group.Add(new VocabularyKey(nameof(DemandInventoryJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandProductionOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderLineNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderHeaderInventoryLotId = group.Add(new VocabularyKey(nameof(DemandProductionOrderHeaderInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandSalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandSalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandSalesOrderNumber = group.Add(new VocabularyKey(nameof(DemandSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandTransferOrderLineReceivingInventoryLotId = group.Add(new VocabularyKey(nameof(DemandTransferOrderLineReceivingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandTransferOrderNumber = group.Add(new VocabularyKey(nameof(DemandTransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndedDate = group.Add(new VocabularyKey(nameof(EndedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedDate = group.Add(new VocabularyKey(nameof(EstimatedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedQuantity = group.Add(new VocabularyKey(nameof(EstimatedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GanttChartColorNumber = group.Add(new VocabularyKey(nameof(GanttChartColorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductionOrderSchedulingLocked = group.Add(new VocabularyKey(nameof(IsProductionOrderSchedulingLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductionRouteOperationValid = group.Add(new VocabularyKey(nameof(IsProductionRouteOperationValid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastSchedulingDate = group.Add(new VocabularyKey(nameof(LastSchedulingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastSchedulingDateDirection = group.Add(new VocabularyKey(nameof(LastSchedulingDateDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastSchedulingTime = group.Add(new VocabularyKey(nameof(LastSchedulingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentProductionOrderNumber = group.Add(new VocabularyKey(nameof(ParentProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionConsumptionDensityConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionDensityConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionConsumptionDepthConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionDepthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionConsumptionHeightConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionHeightConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionConsumptionWidthConversionFactor = group.Add(new VocabularyKey(nameof(ProductionConsumptionWidthConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionLevel = group.Add(new VocabularyKey(nameof(ProductionLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionGroupId = group.Add(new VocabularyKey(nameof(ProductionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderLedgerPostingRule = group.Add(new VocabularyKey(nameof(ProductionOrderLedgerPostingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderName = group.Add(new VocabularyKey(nameof(ProductionOrderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionPoolId = group.Add(new VocabularyKey(nameof(ProductionPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderPriority = group.Add(new VocabularyKey(nameof(ProductionOrderPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderProfitSettingMethod = group.Add(new VocabularyKey(nameof(ProductionOrderProfitSettingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderRemainderStatus = group.Add(new VocabularyKey(nameof(ProductionOrderRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderStatus = group.Add(new VocabularyKey(nameof(ProductionOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionWarehouseId = group.Add(new VocabularyKey(nameof(ProductionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionWarehouseLocationId = group.Add(new VocabularyKey(nameof(ProductionWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSerialNumber = group.Add(new VocabularyKey(nameof(ProductSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedDate = group.Add(new VocabularyKey(nameof(ReleasedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingReportAsFinishedQuantity = group.Add(new VocabularyKey(nameof(RemainingReportAsFinishedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportedAsFinishedDate = group.Add(new VocabularyKey(nameof(ReportedAsFinishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledDate = group.Add(new VocabularyKey(nameof(ScheduledDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledEndTime = group.Add(new VocabularyKey(nameof(ScheduledEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledStartTime = group.Add(new VocabularyKey(nameof(ScheduledStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledStartDate = group.Add(new VocabularyKey(nameof(ScheduledStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScheduledQuantity = group.Add(new VocabularyKey(nameof(ScheduledQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SchedulingMethod = group.Add(new VocabularyKey(nameof(SchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SkipCreateProductionBOMLines = group.Add(new VocabularyKey(nameof(SkipCreateProductionBOMLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SkipCreateProductionRouteOperations = group.Add(new VocabularyKey(nameof(SkipCreateProductionRouteOperations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceBOMVersionValidityDate = group.Add(new VocabularyKey(nameof(SourceBOMVersionValidityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceBOMId = group.Add(new VocabularyKey(nameof(SourceBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceMasterPlanId = group.Add(new VocabularyKey(nameof(SourceMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourcePlannedOrderNumber = group.Add(new VocabularyKey(nameof(SourcePlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceRouteId = group.Add(new VocabularyKey(nameof(SourceRouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedDate = group.Add(new VocabularyKey(nameof(StartedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedQuantity = group.Add(new VocabularyKey(nameof(StartedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseReleaseReservationRequirementRule = group.Add(new VocabularyKey(nameof(WarehouseReleaseReservationRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AreRouteJobsGenerated { get; private set; }
public VocabularyKey AutoReservationMode { get; private set; }
public VocabularyKey DefaultLedgerDimension { get; private set; }
public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey DeliveryDate { get; private set; }
public VocabularyKey DeliveryTime { get; private set; }
public VocabularyKey DemandInventoryJournalLineInventoryLotId { get; private set; }
public VocabularyKey DemandInventoryJournalNumber { get; private set; }
public VocabularyKey DemandProductionOrderLineInventoryLotId { get; private set; }
public VocabularyKey DemandProductionOrderLineNumber { get; private set; }
public VocabularyKey DemandProductionOrderHeaderInventoryLotId { get; private set; }
public VocabularyKey DemandProductionOrderNumber { get; private set; }
public VocabularyKey DemandSalesOrderLineInventoryLotId { get; private set; }
public VocabularyKey DemandSalesOrderNumber { get; private set; }
public VocabularyKey DemandTransferOrderLineReceivingInventoryLotId { get; private set; }
public VocabularyKey DemandTransferOrderNumber { get; private set; }
public VocabularyKey EndedDate { get; private set; }
public VocabularyKey EstimatedDate { get; private set; }
public VocabularyKey EstimatedQuantity { get; private set; }
public VocabularyKey GanttChartColorNumber { get; private set; }
public VocabularyKey InventoryLotId { get; private set; }
public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey IsProductionOrderSchedulingLocked { get; private set; }
public VocabularyKey IsProductionRouteOperationValid { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey LastSchedulingDate { get; private set; }
public VocabularyKey LastSchedulingDateDirection { get; private set; }
public VocabularyKey LastSchedulingTime { get; private set; }
public VocabularyKey LicensePlateNumber { get; private set; }
public VocabularyKey ParentProductionOrderNumber { get; private set; }
public VocabularyKey ProductionConsumptionDensityConversionFactor { get; private set; }
public VocabularyKey ProductionConsumptionDepthConversionFactor { get; private set; }
public VocabularyKey ProductionConsumptionHeightConversionFactor { get; private set; }
public VocabularyKey ProductionConsumptionWidthConversionFactor { get; private set; }
public VocabularyKey ProductionLevel { get; private set; }
public VocabularyKey ProductionGroupId { get; private set; }
public VocabularyKey ProductionOrderLedgerPostingRule { get; private set; }
public VocabularyKey ProductionOrderName { get; private set; }
public VocabularyKey ProductionOrderNumber { get; private set; }
public VocabularyKey ProductionPoolId { get; private set; }
public VocabularyKey ProductionOrderPriority { get; private set; }
public VocabularyKey ProductionOrderProfitSettingMethod { get; private set; }
public VocabularyKey ProductionOrderRemainderStatus { get; private set; }
public VocabularyKey ProductionOrderStatus { get; private set; }
public VocabularyKey ProductionSiteId { get; private set; }
public VocabularyKey ProductionWarehouseId { get; private set; }
public VocabularyKey ProductionWarehouseLocationId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSerialNumber { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ReleasedDate { get; private set; }
public VocabularyKey RemainingReportAsFinishedQuantity { get; private set; }
public VocabularyKey ReportedAsFinishedDate { get; private set; }
public VocabularyKey ScheduledDate { get; private set; }
public VocabularyKey ScheduledEndDate { get; private set; }
public VocabularyKey ScheduledEndTime { get; private set; }
public VocabularyKey ScheduledStartTime { get; private set; }
public VocabularyKey ScheduledStartDate { get; private set; }
public VocabularyKey ScheduledQuantity { get; private set; }
public VocabularyKey SchedulingMethod { get; private set; }
public VocabularyKey SkipCreateProductionBOMLines { get; private set; }
public VocabularyKey SkipCreateProductionRouteOperations { get; private set; }
public VocabularyKey SourceBOMVersionValidityDate { get; private set; }
public VocabularyKey SourceBOMId { get; private set; }
public VocabularyKey SourceMasterPlanId { get; private set; }
public VocabularyKey SourcePlannedOrderNumber { get; private set; }
public VocabularyKey SourceRouteId { get; private set; }
public VocabularyKey StartedDate { get; private set; }
public VocabularyKey StartedQuantity { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderNumber { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderLineInventoryLotId { get; private set; }
public VocabularyKey WarehouseReleaseReservationRequirementRule { get; private set; }
public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }


    }
}