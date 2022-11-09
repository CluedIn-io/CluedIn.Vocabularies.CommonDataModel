using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkLineEntity";
            KeyPrefix = "commonDataModel.whswarehouseworklineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkLineEntity";

            AddGroup("Common Data Model WHSWarehouseWorkLineEntity Details", group =>
            {
                ActualProcessingTimeSeconds = group.Add(new VocabularyKey(nameof(ActualProcessingTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerId = group.Add(new VocabularyKey(nameof(ContainerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedProcessingTimeSeconds = group.Add(new VocabularyKey(nameof(EstimatedProcessingTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FEFOItemBatchNumber = group.Add(new VocabularyKey(nameof(FEFOItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingHandlingQuantity = group.Add(new VocabularyKey(nameof(RemainingHandlingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HandlingQuantity = group.Add(new VocabularyKey(nameof(HandlingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkLineNumber = group.Add(new VocabularyKey(nameof(WorkLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkLineMandatory = group.Add(new VocabularyKey(nameof(IsWorkLineMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceOrderNumber = group.Add(new VocabularyKey(nameof(SourceOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemainingWorkQuantity = group.Add(new VocabularyKey(nameof(RemainingWorkQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkQuantity = group.Add(new VocabularyKey(nameof(WorkQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReplenishmentNeeded = group.Add(new VocabularyKey(nameof(IsReplenishmentNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortOrderCode = group.Add(new VocabularyKey(nameof(SortOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(WorkQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessingWarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(ProcessingWarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkProcessingStartDateTime = group.Add(new VocabularyKey(nameof(WarehouseWorkProcessingStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkStatus = group.Add(new VocabularyKey(nameof(WarehouseWorkStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkExecutionStopped = group.Add(new VocabularyKey(nameof(IsWorkExecutionStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkType = group.Add(new VocabularyKey(nameof(WarehouseWorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseZoneId = group.Add(new VocabularyKey(nameof(WarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExtraHandlingQuantity = group.Add(new VocabularyKey(nameof(ExtraHandlingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CapturedWeight = group.Add(new VocabularyKey(nameof(CapturedWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkId = group.Add(new VocabularyKey(nameof(WarehouseWorkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkClosedDateTime = group.Add(new VocabularyKey(nameof(WarehouseWorkClosedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceLoadLineId = group.Add(new VocabularyKey(nameof(ReferenceLoadLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActualProcessingTimeSeconds { get; private set; }
public VocabularyKey ContainerId { get; private set; }
public VocabularyKey EstimatedProcessingTimeSeconds { get; private set; }
public VocabularyKey FEFOItemBatchNumber { get; private set; }
public VocabularyKey InventDimId { get; private set; }
public VocabularyKey RemainingHandlingQuantity { get; private set; }
public VocabularyKey HandlingQuantity { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey WorkLineNumber { get; private set; }
public VocabularyKey LoadId { get; private set; }
public VocabularyKey IsWorkLineMandatory { get; private set; }
public VocabularyKey SourceOrderNumber { get; private set; }
public VocabularyKey RemainingWorkQuantity { get; private set; }
public VocabularyKey WorkQuantity { get; private set; }
public VocabularyKey IsReplenishmentNeeded { get; private set; }
public VocabularyKey ShipmentId { get; private set; }
public VocabularyKey SortOrderCode { get; private set; }
public VocabularyKey WorkQuantityUnitSymbol { get; private set; }
public VocabularyKey ProcessingWarehouseMobileDeviceUserId { get; private set; }
public VocabularyKey WarehouseLocationId { get; private set; }
public VocabularyKey WarehouseWorkProcessingStartDateTime { get; private set; }
public VocabularyKey WarehouseWorkStatus { get; private set; }
public VocabularyKey IsWorkExecutionStopped { get; private set; }
public VocabularyKey WarehouseWorkType { get; private set; }
public VocabularyKey WarehouseZoneId { get; private set; }
public VocabularyKey ExtraHandlingQuantity { get; private set; }
public VocabularyKey CapturedWeight { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ItemBatchNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey ItemSerialNumber { get; private set; }
public VocabularyKey InventorySiteId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey InventoryStatusId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey LicensePlateNumber { get; private set; }
public VocabularyKey WarehouseWorkId { get; private set; }
public VocabularyKey WarehouseWorkClosedDateTime { get; private set; }
public VocabularyKey ReferenceLoadLineId { get; private set; }


    }
}