using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public InventQualityOrderHeaderEntityVocabulary()
        {
            VocabularyName = "InventQualityOrderHeaderEntity";
            KeyPrefix = "commonDataModel.inventqualityorderheaderentity";
            KeySeparator = ".";
            Grouping = "/InventQualityOrderHeaderEntity";

            AddGroup("InventQualityOrderHeaderEntity Details", group =>
            {
                AcceptableQualityLevelPercentage = group.Add(new VocabularyKey(nameof(AcceptableQualityLevelPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailedOrderInventoryStatusId = group.Add(new VocabularyKey(nameof(FailedOrderInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandInventoryLotId = group.Add(new VocabularyKey(nameof(DemandInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceInventoryLotId = group.Add(new VocabularyKey(nameof(ReferenceInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSamplingId = group.Add(new VocabularyKey(nameof(ItemSamplingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderRouteOperationNumber = group.Add(new VocabularyKey(nameof(ProductionOrderRouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderStatus = group.Add(new VocabularyKey(nameof(QualityOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassedInventoryStatusId = group.Add(new VocabularyKey(nameof(PassedInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailedBatchDispositionCode = group.Add(new VocabularyKey(nameof(FailedBatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassedBatchDispositionCode = group.Add(new VocabularyKey(nameof(PassedBatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchDispositionStatusDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchDispositionStatusDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchAttributeValueDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchAttributeValueDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryQuantity = group.Add(new VocabularyKey(nameof(InventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderNumber = group.Add(new VocabularyKey(nameof(QualityOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderFailureCreatingQuantineOrder = group.Add(new VocabularyKey(nameof(IsQualityOrderFailureCreatingQuantineOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderPolicyType = group.Add(new VocabularyKey(nameof(QualityOrderPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteOperationId = group.Add(new VocabularyKey(nameof(RouteOperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDestructiveTest = group.Add(new VocabularyKey(nameof(IsDestructiveTest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestGroupId = group.Add(new VocabularyKey(nameof(QualityTestGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryStatusDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsInventoryStatusDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatedByWorkerRecId = group.Add(new VocabularyKey(nameof(ValidatedByWorkerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatedDateTime = group.Add(new VocabularyKey(nameof(ValidatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatingPersonnelNumber = group.Add(new VocabularyKey(nameof(ValidatingPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcceptableQualityLevelPercentage { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey FailedOrderInventoryStatusId { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey DemandInventoryLotId { get; private set; }
        public VocabularyKey ReferenceInventoryLotId { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ItemSamplingId { get; private set; }
        public VocabularyKey ProductionOrderRouteOperationNumber { get; private set; }
        public VocabularyKey QualityOrderStatus { get; private set; }
        public VocabularyKey PassedInventoryStatusId { get; private set; }
        public VocabularyKey CatchWeightQuantity { get; private set; }
        public VocabularyKey FailedBatchDispositionCode { get; private set; }
        public VocabularyKey PassedBatchDispositionCode { get; private set; }
        public VocabularyKey IsBatchDispositionStatusDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey IsBatchAttributeValueDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey InventoryQuantity { get; private set; }
        public VocabularyKey QualityOrderNumber { get; private set; }
        public VocabularyKey IsQualityOrderFailureCreatingQuantineOrder { get; private set; }
        public VocabularyKey QualityOrderPolicyType { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey RouteOperationId { get; private set; }
        public VocabularyKey IsDestructiveTest { get; private set; }
        public VocabularyKey QualityTestGroupId { get; private set; }
        public VocabularyKey IsInventoryStatusDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey ValidatedByWorkerRecId { get; private set; }
        public VocabularyKey ValidatedDateTime { get; private set; }
        public VocabularyKey OperationsResourceId { get; private set; }
        public VocabularyKey ValidatingPersonnelNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey ProductionOrderNumber { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }


    }
}