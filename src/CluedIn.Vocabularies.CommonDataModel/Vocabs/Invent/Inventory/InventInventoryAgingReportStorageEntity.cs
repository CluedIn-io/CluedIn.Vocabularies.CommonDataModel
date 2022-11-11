using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryAgingReportStorageEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryAgingReportStorageEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryAgingReportStorageEntity";
            KeyPrefix = "commonDataModel.inventinventoryagingreportstorageentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryAgingReportStorageEntity";

            AddGroup("Common Data Model InventInventoryAgingReportStorageEntity Details", group =>
            {
                ExecutionTime = group.Add(new VocabularyKey(nameof(ExecutionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionName = group.Add(new VocabularyKey(nameof(ExecutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryGtdId = group.Add(new VocabularyKey(nameof(InventoryGtdId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandQuantity = group.Add(new VocabularyKey(nameof(OnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandAmount = group.Add(new VocabularyKey(nameof(OnHandAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryValueQuantity = group.Add(new VocabularyKey(nameof(InventoryValueQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryValueAmount = group.Add(new VocabularyKey(nameof(InventoryValueAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageUnitCost = group.Add(new VocabularyKey(nameof(AverageUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod1Quantity = group.Add(new VocabularyKey(nameof(AgingPeriod1Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod1Amount = group.Add(new VocabularyKey(nameof(AgingPeriod1Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod2Quantity = group.Add(new VocabularyKey(nameof(AgingPeriod2Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod2Amount = group.Add(new VocabularyKey(nameof(AgingPeriod2Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod3Quantity = group.Add(new VocabularyKey(nameof(AgingPeriod3Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod3Amount = group.Add(new VocabularyKey(nameof(AgingPeriod3Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod4Quantity = group.Add(new VocabularyKey(nameof(AgingPeriod4Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod4Amount = group.Add(new VocabularyKey(nameof(AgingPeriod4Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod5Quantity = group.Add(new VocabularyKey(nameof(AgingPeriod5Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingPeriod5Amount = group.Add(new VocabularyKey(nameof(AgingPeriod5Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExecutionTime { get; private set; }
        public VocabularyKey ExecutionName { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey InventoryGtdId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey OnHandQuantity { get; private set; }
        public VocabularyKey OnHandAmount { get; private set; }
        public VocabularyKey InventoryValueQuantity { get; private set; }
        public VocabularyKey InventoryValueAmount { get; private set; }
        public VocabularyKey AverageUnitCost { get; private set; }
        public VocabularyKey AgingPeriod1Quantity { get; private set; }
        public VocabularyKey AgingPeriod1Amount { get; private set; }
        public VocabularyKey AgingPeriod2Quantity { get; private set; }
        public VocabularyKey AgingPeriod2Amount { get; private set; }
        public VocabularyKey AgingPeriod3Quantity { get; private set; }
        public VocabularyKey AgingPeriod3Amount { get; private set; }
        public VocabularyKey AgingPeriod4Quantity { get; private set; }
        public VocabularyKey AgingPeriod4Amount { get; private set; }
        public VocabularyKey AgingPeriod5Quantity { get; private set; }
        public VocabularyKey AgingPeriod5Amount { get; private set; }


    }
}