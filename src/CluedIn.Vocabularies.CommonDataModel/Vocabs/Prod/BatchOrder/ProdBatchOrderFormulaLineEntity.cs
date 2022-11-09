using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdBatchOrderFormulaLineEntityVocabulary : SimpleVocabulary
    {
        public ProdBatchOrderFormulaLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdBatchOrderFormulaLineEntity";
            KeyPrefix = "commonDataModel.prodbatchorderformulalineentity";
            KeySeparator = ".";
            Grouping = "/ProdBatchOrderFormulaLineEntity";

            AddGroup("Common Data Model ProdBatchOrderFormulaLineEntity Details", group =>
            {
                WillCostCalculationIncludeLine = group.Add(new VocabularyKey(nameof(WillCostCalculationIncludeLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationConstant = group.Add(new VocabularyKey(nameof(ConsumptionCalculationConstant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsConstantConsumptionReleased = group.Add(new VocabularyKey(nameof(IsConstantConsumptionReleased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductDensity = group.Add(new VocabularyKey(nameof(PhysicalProductDensity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductDepth = group.Add(new VocabularyKey(nameof(PhysicalProductDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFullyConsumed = group.Add(new VocabularyKey(nameof(IsFullyConsumed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsConsumedAtOperationComplete = group.Add(new VocabularyKey(nameof(IsConsumedAtOperationComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionCalculationMethod = group.Add(new VocabularyKey(nameof(ConsumptionCalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductHeight = group.Add(new VocabularyKey(nameof(PhysicalProductHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubFormulaId = group.Add(new VocabularyKey(nameof(SubFormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubRouteOperationId = group.Add(new VocabularyKey(nameof(SubRouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RouteOperationNumber = group.Add(new VocabularyKey(nameof(RouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(EstimatedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(StartedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReleasedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IngredientType = group.Add(new VocabularyKey(nameof(IngredientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCoProductInheritBatchAttributes = group.Add(new VocabularyKey(nameof(WillCoProductInheritBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCoProductInheritShelfLifeDates = group.Add(new VocabularyKey(nameof(WillCoProductInheritShelfLifeDates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillManufacturedItemInheritBatchAttributes = group.Add(new VocabularyKey(nameof(WillManufacturedItemInheritBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillManufacturedItemInheritShelfLifeDates = group.Add(new VocabularyKey(nameof(WillManufacturedItemInheritShelfLifeDates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormulaQuantityPercentage = group.Add(new VocabularyKey(nameof(FormulaQuantityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFormulaLineQuantityPercentageControlled = group.Add(new VocabularyKey(nameof(IsFormulaLineQuantityPercentageControlled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuantityWithoutYield = group.Add(new VocabularyKey(nameof(QuantityWithoutYield), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFormulaLineQuantityScalable = group.Add(new VocabularyKey(nameof(IsFormulaLineQuantityScalable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionNumber = group.Add(new VocabularyKey(nameof(PositionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FlushingPrinciple = group.Add(new VocabularyKey(nameof(FlushingPrinciple), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineBatchOrderNumber = group.Add(new VocabularyKey(nameof(LineBatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedFormulaLineQuantity = group.Add(new VocabularyKey(nameof(EstimatedFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedFormulaLineQuantity = group.Add(new VocabularyKey(nameof(StartedFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedInventoryQuantity = group.Add(new VocabularyKey(nameof(EstimatedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartedInventoryQuantity = group.Add(new VocabularyKey(nameof(StartedInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RawMaterialScheduledConsumptionDate = group.Add(new VocabularyKey(nameof(RawMaterialScheduledConsumptionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RawMaterialScheduledConsumptionTime = group.Add(new VocabularyKey(nameof(RawMaterialScheduledConsumptionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReleasedFormulaLineQuantity = group.Add(new VocabularyKey(nameof(ReleasedFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingFormulaLineQuantity = group.Add(new VocabularyKey(nameof(RemainingFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingInventoryQuantity = group.Add(new VocabularyKey(nameof(RemainingInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceMasterPlanId = group.Add(new VocabularyKey(nameof(SourceMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourcePlannedOrderNumber = group.Add(new VocabularyKey(nameof(SourcePlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoReservationMode = group.Add(new VocabularyKey(nameof(AutoReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingUpMethod = group.Add(new VocabularyKey(nameof(RoundingUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingUpMultiplesFormulaLineQuantity = group.Add(new VocabularyKey(nameof(RoundingUpMultiplesFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConstantScrapFormulaLineQuantity = group.Add(new VocabularyKey(nameof(ConstantScrapFormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VariableScrapPercentage = group.Add(new VocabularyKey(nameof(VariableScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormulaLineUnitSymbol = group.Add(new VocabularyKey(nameof(FormulaLineUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingVendorAccountNumber = group.Add(new VocabularyKey(nameof(SubcontractingVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PhysicalProductWidth = group.Add(new VocabularyKey(nameof(PhysicalProductWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsResourceConsumptionUsed = group.Add(new VocabularyKey(nameof(IsResourceConsumptionUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchOrderNumber = group.Add(new VocabularyKey(nameof(BatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionSiteId = group.Add(new VocabularyKey(nameof(ConsumptionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionWarehouseId = group.Add(new VocabularyKey(nameof(ConsumptionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandTransferOrderNumber = group.Add(new VocabularyKey(nameof(DemandTransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandInventoryJournalLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandInventoryJournalLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandInventoryJournalNumber = group.Add(new VocabularyKey(nameof(DemandInventoryJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandProductionOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderLineNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderHeaderInventoryLotId = group.Add(new VocabularyKey(nameof(DemandProductionOrderHeaderInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandProductionOrderNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandSalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandSalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandSalesOrderNumber = group.Add(new VocabularyKey(nameof(DemandSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandTransferOrderLineReceivingInventoryLotId = group.Add(new VocabularyKey(nameof(DemandTransferOrderLineReceivingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcontractingPurchaseOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineRemainderStatus = group.Add(new VocabularyKey(nameof(LineRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormulaLineQuantity = group.Add(new VocabularyKey(nameof(FormulaLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionType = group.Add(new VocabularyKey(nameof(ConsumptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceFormulaId = group.Add(new VocabularyKey(nameof(SourceFormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormulaLineQuantityDenominator = group.Add(new VocabularyKey(nameof(FormulaLineQuantityDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillCostCalculationIncludeLine { get; private set; }
public VocabularyKey ConsumptionCalculationConstant { get; private set; }
public VocabularyKey IsConstantConsumptionReleased { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey PhysicalProductDensity { get; private set; }
public VocabularyKey PhysicalProductDepth { get; private set; }
public VocabularyKey IsFullyConsumed { get; private set; }
public VocabularyKey IsConsumedAtOperationComplete { get; private set; }
public VocabularyKey ConsumptionCalculationMethod { get; private set; }
public VocabularyKey PhysicalProductHeight { get; private set; }
public VocabularyKey InventoryLotId { get; private set; }
public VocabularyKey SubFormulaId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey SubRouteOperationId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey RouteOperationNumber { get; private set; }
public VocabularyKey EstimatedCatchWeightQuantity { get; private set; }
public VocabularyKey StartedCatchWeightQuantity { get; private set; }
public VocabularyKey CatchWeightQuantity { get; private set; }
public VocabularyKey ReleasedCatchWeightQuantity { get; private set; }
public VocabularyKey RemainingCatchWeightQuantity { get; private set; }
public VocabularyKey IngredientType { get; private set; }
public VocabularyKey WillCoProductInheritBatchAttributes { get; private set; }
public VocabularyKey WillCoProductInheritShelfLifeDates { get; private set; }
public VocabularyKey WillManufacturedItemInheritBatchAttributes { get; private set; }
public VocabularyKey WillManufacturedItemInheritShelfLifeDates { get; private set; }
public VocabularyKey FormulaQuantityPercentage { get; private set; }
public VocabularyKey IsFormulaLineQuantityPercentageControlled { get; private set; }
public VocabularyKey QuantityWithoutYield { get; private set; }
public VocabularyKey IsFormulaLineQuantityScalable { get; private set; }
public VocabularyKey PositionNumber { get; private set; }
public VocabularyKey FlushingPrinciple { get; private set; }
public VocabularyKey LineBatchOrderNumber { get; private set; }
public VocabularyKey LineType { get; private set; }
public VocabularyKey EstimatedFormulaLineQuantity { get; private set; }
public VocabularyKey StartedFormulaLineQuantity { get; private set; }
public VocabularyKey EstimatedInventoryQuantity { get; private set; }
public VocabularyKey StartedInventoryQuantity { get; private set; }
public VocabularyKey RawMaterialScheduledConsumptionDate { get; private set; }
public VocabularyKey RawMaterialScheduledConsumptionTime { get; private set; }
public VocabularyKey ReleasedFormulaLineQuantity { get; private set; }
public VocabularyKey RemainingFormulaLineQuantity { get; private set; }
public VocabularyKey RemainingInventoryQuantity { get; private set; }
public VocabularyKey SourceMasterPlanId { get; private set; }
public VocabularyKey SourcePlannedOrderNumber { get; private set; }
public VocabularyKey AutoReservationMode { get; private set; }
public VocabularyKey RoundingUpMethod { get; private set; }
public VocabularyKey RoundingUpMultiplesFormulaLineQuantity { get; private set; }
public VocabularyKey ConstantScrapFormulaLineQuantity { get; private set; }
public VocabularyKey VariableScrapPercentage { get; private set; }
public VocabularyKey FormulaLineUnitSymbol { get; private set; }
public VocabularyKey SubcontractingVendorAccountNumber { get; private set; }
public VocabularyKey PhysicalProductWidth { get; private set; }
public VocabularyKey IsResourceConsumptionUsed { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey BatchOrderNumber { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey ConsumptionSiteId { get; private set; }
public VocabularyKey ConsumptionWarehouseId { get; private set; }
public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey DemandTransferOrderNumber { get; private set; }
public VocabularyKey DemandInventoryJournalLineInventoryLotId { get; private set; }
public VocabularyKey DemandInventoryJournalNumber { get; private set; }
public VocabularyKey DemandProductionOrderLineInventoryLotId { get; private set; }
public VocabularyKey DemandProductionOrderLineNumber { get; private set; }
public VocabularyKey DemandProductionOrderHeaderInventoryLotId { get; private set; }
public VocabularyKey DemandProductionOrderNumber { get; private set; }
public VocabularyKey DemandSalesOrderLineInventoryLotId { get; private set; }
public VocabularyKey DemandSalesOrderNumber { get; private set; }
public VocabularyKey DemandTransferOrderLineReceivingInventoryLotId { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderNumber { get; private set; }
public VocabularyKey SubcontractingPurchaseOrderLineInventoryLotId { get; private set; }
public VocabularyKey LineRemainderStatus { get; private set; }
public VocabularyKey FormulaLineQuantity { get; private set; }
public VocabularyKey ConsumptionType { get; private set; }
public VocabularyKey SourceFormulaId { get; private set; }
public VocabularyKey FormulaLineQuantityDenominator { get; private set; }
public VocabularyKey InventDimId { get; private set; }


    }
}