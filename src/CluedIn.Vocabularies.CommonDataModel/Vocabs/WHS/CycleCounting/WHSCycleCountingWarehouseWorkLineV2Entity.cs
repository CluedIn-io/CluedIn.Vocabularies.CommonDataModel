using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCycleCountingWarehouseWorkLineV2EntityVocabulary : SimpleVocabulary
    {
        public WHSCycleCountingWarehouseWorkLineV2EntityVocabulary()
        {
            VocabularyName = "WHSCycleCountingWarehouseWorkLineV2Entity";
            KeyPrefix = "commonDataModel.whscyclecountingwarehouseworklinev2entity";
            KeySeparator = ".";
            Grouping = "/WHSCycleCountingWarehouseWorkLineV2Entity";

            AddGroup("WHSCycleCountingWarehouseWorkLineV2Entity Details", group =>
            {
                AdjustmentWarehouseWorkId = group.Add(new VocabularyKey(nameof(AdjustmentWarehouseWorkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountedQuantity = group.Add(new VocabularyKey(nameof(CountedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedQuantity = group.Add(new VocabularyKey(nameof(ExpectedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDiscrepancyRegistered = group.Add(new VocabularyKey(nameof(IsDiscrepancyRegistered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegistered = group.Add(new VocabularyKey(nameof(IsRegistered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReviewResult = group.Add(new VocabularyKey(nameof(ReviewResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkId = group.Add(new VocabularyKey(nameof(WarehouseWorkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkClosedDateTime = group.Add(new VocabularyKey(nameof(WorkClosedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCreatedDateTime = group.Add(new VocabularyKey(nameof(WorkCreatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkStatus = group.Add(new VocabularyKey(nameof(WorkStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdjustmentWarehouseWorkId { get; private set; }
        public VocabularyKey CountedQuantity { get; private set; }
        public VocabularyKey ExpectedQuantity { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey IsDiscrepancyRegistered { get; private set; }
        public VocabularyKey IsRegistered { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ReviewResult { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey WarehouseMobileDeviceUserId { get; private set; }
        public VocabularyKey WarehouseWorkId { get; private set; }
        public VocabularyKey WorkClosedDateTime { get; private set; }
        public VocabularyKey WorkCreatedDateTime { get; private set; }
        public VocabularyKey WorkStatus { get; private set; }


    }
}