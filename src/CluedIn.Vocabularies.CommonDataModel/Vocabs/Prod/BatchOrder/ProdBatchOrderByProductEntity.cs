using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdBatchOrderByProductEntityVocabulary : SimpleVocabulary
    {
        public ProdBatchOrderByProductEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProdBatchOrderByProductEntity";
            KeyPrefix = "commonDataModel.prodbatchorderbyproductentity";
            KeySeparator = ".";
            Grouping = "/ProdBatchOrderByProductEntity";

            AddGroup("Common Data Model ProdBatchOrderByProductEntity Details", group =>
            {
                BatchOrderRemainderStatus = group.Add(new VocabularyKey(nameof(BatchOrderRemainderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BurdenAllocationMethod = group.Add(new VocabularyKey(nameof(BurdenAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedDate = group.Add(new VocabularyKey(nameof(EstimatedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ByProductQuantity = group.Add(new VocabularyKey(nameof(ByProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ByProductQuantityDenominator = group.Add(new VocabularyKey(nameof(ByProductQuantityDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFullyConsumed = group.Add(new VocabularyKey(nameof(IsFullyConsumed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedAsFinishedDate = group.Add(new VocabularyKey(nameof(ReportedAsFinishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceInventoryLotId = group.Add(new VocabularyKey(nameof(ReferenceInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceType = group.Add(new VocabularyKey(nameof(ReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLotId = group.Add(new VocabularyKey(nameof(InventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BurdenAllocationAmount = group.Add(new VocabularyKey(nameof(BurdenAllocationAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(EstimatedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(StartedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ByProductBatchOrderNumber = group.Add(new VocabularyKey(nameof(ByProductBatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionType = group.Add(new VocabularyKey(nameof(ProductionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedByProductQuantity = group.Add(new VocabularyKey(nameof(EstimatedByProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedByProductQuantity = group.Add(new VocabularyKey(nameof(StartedByProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndedDate = group.Add(new VocabularyKey(nameof(EndedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingByProductQuantity = group.Add(new VocabularyKey(nameof(RemainingByProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceMasterPlanId = group.Add(new VocabularyKey(nameof(SourceMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourcePlannedOrderNumber = group.Add(new VocabularyKey(nameof(SourcePlannedOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingUpMethod = group.Add(new VocabularyKey(nameof(RoundingUpMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingUpMultiplesByProductQuantity = group.Add(new VocabularyKey(nameof(RoundingUpMultiplesByProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartedDate = group.Add(new VocabularyKey(nameof(StartedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandInventoryJournalLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandInventoryJournalLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandInventoryJournalNumber = group.Add(new VocabularyKey(nameof(DemandInventoryJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandProductionOrderLineNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandProductionOrderHeaderInventoryLotId = group.Add(new VocabularyKey(nameof(DemandProductionOrderHeaderInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandProductionOrderNumber = group.Add(new VocabularyKey(nameof(DemandProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandSalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(DemandSalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandSalesOrderNumber = group.Add(new VocabularyKey(nameof(DemandSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandTransferOrderLineReceivingInventoryLotId = group.Add(new VocabularyKey(nameof(DemandTransferOrderLineReceivingInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandTransferOrderNumber = group.Add(new VocabularyKey(nameof(DemandTransferOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcontractingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcontractingPurchaseOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SubcontractingPurchaseOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchOrderNumber = group.Add(new VocabularyKey(nameof(BatchOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionSiteId = group.Add(new VocabularyKey(nameof(ConsumptionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsumptionWarehouseId = group.Add(new VocabularyKey(nameof(ConsumptionWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchOrderRemainderStatus { get; private set; }
        public VocabularyKey BurdenAllocationMethod { get; private set; }
        public VocabularyKey EstimatedDate { get; private set; }
        public VocabularyKey ByProductQuantity { get; private set; }
        public VocabularyKey ByProductQuantityDenominator { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey IsFullyConsumed { get; private set; }
        public VocabularyKey ReportedAsFinishedDate { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
        public VocabularyKey ReferenceInventoryLotId { get; private set; }
        public VocabularyKey ReferenceType { get; private set; }
        public VocabularyKey InventoryLotId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey BurdenAllocationAmount { get; private set; }
        public VocabularyKey EstimatedCatchWeightQuantity { get; private set; }
        public VocabularyKey StartedCatchWeightQuantity { get; private set; }
        public VocabularyKey CatchWeightQuantity { get; private set; }
        public VocabularyKey RemainingCatchWeightQuantity { get; private set; }
        public VocabularyKey ByProductBatchOrderNumber { get; private set; }
        public VocabularyKey ProductionType { get; private set; }
        public VocabularyKey EstimatedByProductQuantity { get; private set; }
        public VocabularyKey StartedByProductQuantity { get; private set; }
        public VocabularyKey EndedDate { get; private set; }
        public VocabularyKey RemainingByProductQuantity { get; private set; }
        public VocabularyKey SourceMasterPlanId { get; private set; }
        public VocabularyKey SourcePlannedOrderNumber { get; private set; }
        public VocabularyKey RoundingUpMethod { get; private set; }
        public VocabularyKey RoundingUpMultiplesByProductQuantity { get; private set; }
        public VocabularyKey StartedDate { get; private set; }
        public VocabularyKey DemandInventoryJournalLineInventoryLotId { get; private set; }
        public VocabularyKey DemandInventoryJournalNumber { get; private set; }
        public VocabularyKey DemandProductionOrderLineNumber { get; private set; }
        public VocabularyKey DemandProductionOrderHeaderInventoryLotId { get; private set; }
        public VocabularyKey DemandProductionOrderNumber { get; private set; }
        public VocabularyKey DemandSalesOrderLineInventoryLotId { get; private set; }
        public VocabularyKey DemandSalesOrderNumber { get; private set; }
        public VocabularyKey DemandTransferOrderLineReceivingInventoryLotId { get; private set; }
        public VocabularyKey DemandTransferOrderNumber { get; private set; }
        public VocabularyKey SubcontractingPurchaseOrderNumber { get; private set; }
        public VocabularyKey SubcontractingPurchaseOrderLineInventoryLotId { get; private set; }
        public VocabularyKey BatchOrderNumber { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ConsumptionSiteId { get; private set; }
        public VocabularyKey ConsumptionWarehouseId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }


    }
}