using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdProductionOrderBillOfMaterialsLineEntityVocabulary : SimpleVocabulary
    {
        public ProdProductionOrderBillOfMaterialsLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdProductionOrderBillOfMaterialsLineEntity";
            KeyPrefix = "commonDataModel.prodproductionorderbillofmaterialslineentity";
            KeySeparator = ".";
            Grouping = "/ProdProductionOrderBillOfMaterialsLineEntity";

            AddGroup("Common Data Model ProdProductionOrderBillOfMaterialsLineEntity Details", group =>
            {
                AutoReservationMode = group.Add(new VocabularyKey(nameof(AutoReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMLineQuantity = group.Add(new VocabularyKey(nameof(BOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMLineQuantityDenominator = group.Add(new VocabularyKey(nameof(BOMLineQuantityDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMLineUnitSymbol = group.Add(new VocabularyKey(nameof(BOMLineUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstantScrapBOMLineQuantity = group.Add(new VocabularyKey(nameof(ConstantScrapBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedBOMLineQuantity = group.Add(new VocabularyKey(nameof(ReleasedBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationConstant = group.Add(new VocabularyKey(nameof(ConsumptionCalculationConstant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationMethod = group.Add(new VocabularyKey(nameof(ConsumptionCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionSiteId = group.Add(new VocabularyKey(nameof(ConsumptionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionType = group.Add(new VocabularyKey(nameof(ConsumptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionWarehouseId = group.Add(new VocabularyKey(nameof(ConsumptionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
FlushingPrinciple = group.Add(new VocabularyKey(nameof(FlushingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedInventoryQuantity = group.Add(new VocabularyKey(nameof(EstimatedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedBOMLineQuantity = group.Add(new VocabularyKey(nameof(EstimatedBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsConstantConsumptionReleased = group.Add(new VocabularyKey(nameof(IsConstantConsumptionReleased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsConsumedAtOperationComplete = group.Add(new VocabularyKey(nameof(IsConsumedAtOperationComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFullyConsumed = group.Add(new VocabularyKey(nameof(IsFullyConsumed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsResourceConsumptionUsed = group.Add(new VocabularyKey(nameof(IsResourceConsumptionUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineProductionOrderNumber = group.Add(new VocabularyKey(nameof(LineProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineRemainderStatus = group.Add(new VocabularyKey(nameof(LineRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductDensity = group.Add(new VocabularyKey(nameof(PhysicalProductDensity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductDepth = group.Add(new VocabularyKey(nameof(PhysicalProductDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductHeight = group.Add(new VocabularyKey(nameof(PhysicalProductHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductWidth = group.Add(new VocabularyKey(nameof(PhysicalProductWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionNumber = group.Add(new VocabularyKey(nameof(PositionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RawMaterialScheduledConsumptionDate = group.Add(new VocabularyKey(nameof(RawMaterialScheduledConsumptionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RawMaterialScheduledConsumptionTime = group.Add(new VocabularyKey(nameof(RawMaterialScheduledConsumptionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingBOMLineQuantity = group.Add(new VocabularyKey(nameof(RemainingBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingInventoryQuantity = group.Add(new VocabularyKey(nameof(RemainingInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingUpMethod = group.Add(new VocabularyKey(nameof(RoundingUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingUpMultiplesBOMLineQuantity = group.Add(new VocabularyKey(nameof(RoundingUpMultiplesBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceBOMId = group.Add(new VocabularyKey(nameof(SourceBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceMasterPlanId = group.Add(new VocabularyKey(nameof(SourceMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourcePlannedOrderNumber = group.Add(new VocabularyKey(nameof(SourcePlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedInventoryQuantity = group.Add(new VocabularyKey(nameof(StartedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedBOMLineQuantity = group.Add(new VocabularyKey(nameof(StartedBOMLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubBOMId = group.Add(new VocabularyKey(nameof(SubBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingVendorAccountNumber = group.Add(new VocabularyKey(nameof(SubcontractingVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubRouteOperationId = group.Add(new VocabularyKey(nameof(SubRouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VariableScrapPercentage = group.Add(new VocabularyKey(nameof(VariableScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCostCalculationIncludeLine = group.Add(new VocabularyKey(nameof(WillCostCalculationIncludeLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AutoReservationMode { get; private set; }
public VocabularyKey BOMLineQuantity { get; private set; }
public VocabularyKey BOMLineQuantityDenominator { get; private set; }
public VocabularyKey BOMLineUnitSymbol { get; private set; }
public VocabularyKey ConstantScrapBOMLineQuantity { get; private set; }
public VocabularyKey ReleasedBOMLineQuantity { get; private set; }
public VocabularyKey ConsumptionCalculationConstant { get; private set; }
public VocabularyKey ConsumptionCalculationMethod { get; private set; }
public VocabularyKey ConsumptionSiteId { get; private set; }
public VocabularyKey ConsumptionType { get; private set; }
public VocabularyKey ConsumptionWarehouseId { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
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
public VocabularyKey FlushingPrinciple { get; private set; }
public VocabularyKey EstimatedInventoryQuantity { get; private set; }
public VocabularyKey EstimatedBOMLineQuantity { get; private set; }
public VocabularyKey InventoryLotId { get; private set; }
public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey IsConstantConsumptionReleased { get; private set; }
public VocabularyKey IsConsumedAtOperationComplete { get; private set; }
public VocabularyKey IsFullyConsumed { get; private set; }
public VocabularyKey IsResourceConsumptionUsed { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey LineProductionOrderNumber { get; private set; }
public VocabularyKey LineRemainderStatus { get; private set; }
public VocabularyKey LineType { get; private set; }
public VocabularyKey PhysicalProductDensity { get; private set; }
public VocabularyKey PhysicalProductDepth { get; private set; }
public VocabularyKey PhysicalProductHeight { get; private set; }
public VocabularyKey PhysicalProductWidth { get; private set; }
public VocabularyKey PositionNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ProductionOrderNumber { get; private set; }
public VocabularyKey RawMaterialScheduledConsumptionDate { get; private set; }
public VocabularyKey RawMaterialScheduledConsumptionTime { get; private set; }
public VocabularyKey RemainingBOMLineQuantity { get; private set; }
public VocabularyKey RemainingInventoryQuantity { get; private set; }
public VocabularyKey RouteOperationNumber { get; private set; }
public VocabularyKey RoundingUpMethod { get; private set; }
public VocabularyKey RoundingUpMultiplesBOMLineQuantity { get; private set; }
public VocabularyKey SourceBOMId { get; private set; }
public VocabularyKey SourceMasterPlanId { get; private set; }
public VocabularyKey SourcePlannedOrderNumber { get; private set; }
public VocabularyKey StartedInventoryQuantity { get; private set; }
public VocabularyKey StartedBOMLineQuantity { get; private set; }
public VocabularyKey SubBOMId { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderNumber { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderLineInventoryLotId { get; private set; }
public VocabularyKey SubcontractingVendorAccountNumber { get; private set; }
public VocabularyKey SubRouteOperationId { get; private set; }
public VocabularyKey VariableScrapPercentage { get; private set; }
public VocabularyKey WillCostCalculationIncludeLine { get; private set; }


    }
}