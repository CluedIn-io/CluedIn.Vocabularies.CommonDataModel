using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryValueReportStorageEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryValueReportStorageEntityVocabulary()
        {
            VocabularyName = "Invent Inventory Value Report Storage Entity";
            KeyPrefix = "commonDataModel.inventinventoryvaluereportstorageentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryValueReportStorageEntity";

            AddGroup("InventInventoryValueReportStorageEntity Details", group =>
            {
                COGSFinancialAmount = group.Add(new VocabularyKey(nameof(COGSFinancialAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                COGSFinancialQuantity = group.Add(new VocabularyKey(nameof(COGSFinancialQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSPhysicalNonPostedAmount = group.Add(new VocabularyKey(nameof(DeferredCOGSPhysicalNonPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSPhysicalNonPostedQuantity = group.Add(new VocabularyKey(nameof(DeferredCOGSPhysicalNonPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSPhysicalPostedAmount = group.Add(new VocabularyKey(nameof(DeferredCOGSPhysicalPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSPhysicalPostedQuantity = group.Add(new VocabularyKey(nameof(DeferredCOGSPhysicalPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSAmount = group.Add(new VocabularyKey(nameof(DeferredCOGSAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeferredCOGSQuantity = group.Add(new VocabularyKey(nameof(DeferredCOGSQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryFinancialAmount = group.Add(new VocabularyKey(nameof(InventoryFinancialAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryFinancialQuantity = group.Add(new VocabularyKey(nameof(InventoryFinancialQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPhysicalNonPostedAmount = group.Add(new VocabularyKey(nameof(InventoryPhysicalNonPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPhysicalNonPostedQuantity = group.Add(new VocabularyKey(nameof(InventoryPhysicalNonPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPhysicalPostedAmount = group.Add(new VocabularyKey(nameof(InventoryPhysicalPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryPhysicalPostedQuantity = group.Add(new VocabularyKey(nameof(InventoryPhysicalPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAmount = group.Add(new VocabularyKey(nameof(InventoryAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryQuantity = group.Add(new VocabularyKey(nameof(InventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLFinancialAmount = group.Add(new VocabularyKey(nameof(PLFinancialAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PLFinancialQuantity = group.Add(new VocabularyKey(nameof(PLFinancialQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineReferenceNumber = group.Add(new VocabularyKey(nameof(LineReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineReferenceType = group.Add(new VocabularyKey(nameof(LineReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostResourceGroupId = group.Add(new VocabularyKey(nameof(CostResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostResourceNumber = group.Add(new VocabularyKey(nameof(CostResourceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostResourceType = group.Add(new VocabularyKey(nameof(CostResourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTime = group.Add(new VocabularyKey(nameof(TransactionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumber = group.Add(new VocabularyKey(nameof(VoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPPhysicalNonPostedAmount = group.Add(new VocabularyKey(nameof(WIPPhysicalNonPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPPhysicalNonPostedQuantity = group.Add(new VocabularyKey(nameof(WIPPhysicalNonPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPPhysicalPostedAmount = group.Add(new VocabularyKey(nameof(WIPPhysicalPostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPPhysicalPostedQuantity = group.Add(new VocabularyKey(nameof(WIPPhysicalPostedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPAmount = group.Add(new VocabularyKey(nameof(WIPAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPQuantity = group.Add(new VocabularyKey(nameof(WIPQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageUnitCost = group.Add(new VocabularyKey(nameof(AverageUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionName = group.Add(new VocabularyKey(nameof(ExecutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionTime = group.Add(new VocabularyKey(nameof(ExecutionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey COGSFinancialAmount { get; private set; }
        public VocabularyKey COGSFinancialQuantity { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey DeferredCOGSPhysicalNonPostedAmount { get; private set; }
        public VocabularyKey DeferredCOGSPhysicalNonPostedQuantity { get; private set; }
        public VocabularyKey DeferredCOGSPhysicalPostedAmount { get; private set; }
        public VocabularyKey DeferredCOGSPhysicalPostedQuantity { get; private set; }
        public VocabularyKey DeferredCOGSAmount { get; private set; }
        public VocabularyKey DeferredCOGSQuantity { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventoryFinancialAmount { get; private set; }
        public VocabularyKey InventoryFinancialQuantity { get; private set; }
        public VocabularyKey InventoryPhysicalNonPostedAmount { get; private set; }
        public VocabularyKey InventoryPhysicalNonPostedQuantity { get; private set; }
        public VocabularyKey InventoryPhysicalPostedAmount { get; private set; }
        public VocabularyKey InventoryPhysicalPostedQuantity { get; private set; }
        public VocabularyKey InventoryAmount { get; private set; }
        public VocabularyKey InventoryQuantity { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey PLFinancialAmount { get; private set; }
        public VocabularyKey PLFinancialQuantity { get; private set; }
        public VocabularyKey LineReferenceNumber { get; private set; }
        public VocabularyKey LineReferenceType { get; private set; }
        public VocabularyKey CostResourceGroupId { get; private set; }
        public VocabularyKey CostResourceNumber { get; private set; }
        public VocabularyKey CostResourceType { get; private set; }
        public VocabularyKey TransactionTime { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey VoucherNumber { get; private set; }
        public VocabularyKey WIPPhysicalNonPostedAmount { get; private set; }
        public VocabularyKey WIPPhysicalNonPostedQuantity { get; private set; }
        public VocabularyKey WIPPhysicalPostedAmount { get; private set; }
        public VocabularyKey WIPPhysicalPostedQuantity { get; private set; }
        public VocabularyKey WIPAmount { get; private set; }
        public VocabularyKey WIPQuantity { get; private set; }
        public VocabularyKey AverageUnitCost { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey ExecutionName { get; private set; }
        public VocabularyKey ExecutionTime { get; private set; }
    }
}