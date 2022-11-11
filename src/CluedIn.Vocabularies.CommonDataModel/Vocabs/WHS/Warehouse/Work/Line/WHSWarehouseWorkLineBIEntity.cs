using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkLineBIEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkLineBIEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkLineBIEntity";
            KeyPrefix = "commonDataModel.whswarehouseworklinebientity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkLineBIEntity";

            AddGroup("Common Data Model WHSWarehouseWorkLineBIEntity Details", group =>
            {
                ActualWorkLineProcessingTime = group.Add(new VocabularyKey(nameof(ActualWorkLineProcessingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualWorkProcessingTime = group.Add(new VocabularyKey(nameof(ActualWorkProcessingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerId = group.Add(new VocabularyKey(nameof(ContainerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedWorkLineProcessingTime = group.Add(new VocabularyKey(nameof(EstimatedWorkLineProcessingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedWorkProcessingTime = group.Add(new VocabularyKey(nameof(EstimatedWorkProcessingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryGTDNumber = group.Add(new VocabularyKey(nameof(InventoryGTDNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkFrozen = group.Add(new VocabularyKey(nameof(IsWorkFrozen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkStepMandatory = group.Add(new VocabularyKey(nameof(IsWorkStepMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkStepSkipped = group.Add(new VocabularyKey(nameof(IsWorkStepSkipped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkStepStopped = group.Add(new VocabularyKey(nameof(IsWorkStepStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalAvailableInventoryQuantity = group.Add(new VocabularyKey(nameof(PhysicalAvailableInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPickOrderNumber = group.Add(new VocabularyKey(nameof(ProductionPickOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionPutOrderNumber = group.Add(new VocabularyKey(nameof(ProductionPutOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingInventoryQuantity = group.Add(new VocabularyKey(nameof(RemainingInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingWorkQuantity = group.Add(new VocabularyKey(nameof(RemainingWorkQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortOrderCode = group.Add(new VocabularyKey(nameof(SortOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetLicensePlateId = group.Add(new VocabularyKey(nameof(TargetLicensePlateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferIssueOrderNumber = group.Add(new VocabularyKey(nameof(TransferIssueOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferReceiptOrderNumber = group.Add(new VocabularyKey(nameof(TransferReceiptOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkBuildId = group.Add(new VocabularyKey(nameof(WarehouseWorkBuildId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkClassId = group.Add(new VocabularyKey(nameof(WarehouseWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkPoolId = group.Add(new VocabularyKey(nameof(WarehouseWorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWaveId = group.Add(new VocabularyKey(nameof(WarehouseWaveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkId = group.Add(new VocabularyKey(nameof(WarehouseWorkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseZoneId = group.Add(new VocabularyKey(nameof(WarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkClosedDateTime = group.Add(new VocabularyKey(nameof(WorkClosedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCreatedDateTime = group.Add(new VocabularyKey(nameof(WorkCreatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkInventoryQuantity = group.Add(new VocabularyKey(nameof(WorkInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkLineClosedDateTime = group.Add(new VocabularyKey(nameof(WorkLineClosedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkLineInventoryTransactionId = group.Add(new VocabularyKey(nameof(WorkLineInventoryTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkLineStartedDateTime = group.Add(new VocabularyKey(nameof(WorkLineStartedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkLineNumber = group.Add(new VocabularyKey(nameof(WorkLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkLineStatus = group.Add(new VocabularyKey(nameof(WorkLineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPriority = group.Add(new VocabularyKey(nameof(WorkPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkProcessingUserId = group.Add(new VocabularyKey(nameof(WorkProcessingUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkStartedDateTime = group.Add(new VocabularyKey(nameof(WorkStartedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkQuantity = group.Add(new VocabularyKey(nameof(WorkQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkStatus = group.Add(new VocabularyKey(nameof(WorkStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTransactionType = group.Add(new VocabularyKey(nameof(WorkTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkType = group.Add(new VocabularyKey(nameof(WorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActualWorkLineProcessingTime { get; private set; }
        public VocabularyKey ActualWorkProcessingTime { get; private set; }
        public VocabularyKey ContainerId { get; private set; }
        public VocabularyKey EstimatedWorkLineProcessingTime { get; private set; }
        public VocabularyKey EstimatedWorkProcessingTime { get; private set; }
        public VocabularyKey InventoryGTDNumber { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey IsWorkFrozen { get; private set; }
        public VocabularyKey IsWorkStepMandatory { get; private set; }
        public VocabularyKey IsWorkStepSkipped { get; private set; }
        public VocabularyKey IsWorkStepStopped { get; private set; }
        public VocabularyKey LoadId { get; private set; }
        public VocabularyKey PhysicalAvailableInventoryQuantity { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductionPickOrderNumber { get; private set; }
        public VocabularyKey ProductionPutOrderNumber { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey RemainingInventoryQuantity { get; private set; }
        public VocabularyKey RemainingWorkQuantity { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey ShipmentId { get; private set; }
        public VocabularyKey SortOrderCode { get; private set; }
        public VocabularyKey TargetLicensePlateId { get; private set; }
        public VocabularyKey TransferIssueOrderNumber { get; private set; }
        public VocabularyKey TransferReceiptOrderNumber { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey WarehouseMobileDeviceUserId { get; private set; }
        public VocabularyKey WarehouseWorkBuildId { get; private set; }
        public VocabularyKey WarehouseWorkClassId { get; private set; }
        public VocabularyKey WarehouseWorkPoolId { get; private set; }
        public VocabularyKey WarehouseWorkTemplateId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey WarehouseWaveId { get; private set; }
        public VocabularyKey WarehouseWorkId { get; private set; }
        public VocabularyKey WarehouseZoneId { get; private set; }
        public VocabularyKey WorkClosedDateTime { get; private set; }
        public VocabularyKey WorkCreatedDateTime { get; private set; }
        public VocabularyKey WorkInventoryQuantity { get; private set; }
        public VocabularyKey WorkLineClosedDateTime { get; private set; }
        public VocabularyKey WorkLineInventoryTransactionId { get; private set; }
        public VocabularyKey WorkLineStartedDateTime { get; private set; }
        public VocabularyKey WorkLineNumber { get; private set; }
        public VocabularyKey WorkLineStatus { get; private set; }
        public VocabularyKey WorkPriority { get; private set; }
        public VocabularyKey WorkProcessingUserId { get; private set; }
        public VocabularyKey WorkStartedDateTime { get; private set; }
        public VocabularyKey WorkQuantity { get; private set; }
        public VocabularyKey WorkStatus { get; private set; }
        public VocabularyKey WorkTransactionType { get; private set; }
        public VocabularyKey WorkType { get; private set; }


    }
}