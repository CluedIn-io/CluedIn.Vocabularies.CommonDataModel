using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryDimensionsParametersEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryDimensionsParametersEntityVocabulary()
        {
            VocabularyName = "Invent Inventory Dimensions Parameters Entity";
            KeyPrefix = "commonDataModel.inventinventorydimensionsparametersentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryDimensionsParametersEntity";

            AddGroup("InventInventoryDimensionsParametersEntity Details", group =>
            {
                InventoryDimensionName = group.Add(new VocabularyKey(nameof(InventoryDimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesOrderLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsSalesOrderLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesQuotationLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsSalesQuotationLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryMovementJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryMovementJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryAdjustmentJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryAdjustmentJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryTransferJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryTransferJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryCountingJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryCountingJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBillOfMaterialsLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsBillOfMaterialsLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryTransactionGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryTransactionGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferOrderLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsTransferOrderLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuarantineOrderGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsQuarantineOrderGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQualityOrderGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsQualityOrderGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNonConformanceGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsNonConformanceGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCertificateOfAnalysisGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsCertificateOfAnalysisGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryBlockingGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryBlockingGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemArrivalJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsItemArrivalJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionInputJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProductionInputJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehousePickingLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsWarehousePickingLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryFixedAssetTransferJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryFixedAssetTransferJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionOrderGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProductionOrderGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionOrderLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProductionOrderLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionPickingListJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProductionPickingListJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductionReportedAsFinishedJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProductionReportedAsFinishedJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsByProductJournalLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsByProductJournalLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryProjectConsumptionJournalGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryProjectConsumptionJournalGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProjectQuotationLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsProjectQuotationLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseOrderLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsPurchaseOrderLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimFieldId = group.Add(new VocabularyKey(nameof(DimFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsignmentReplenishmentOrderLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsConsignmentReplenishmentOrderLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryOwnershipChangeLineGridDisplayingDimensionByDefault = group.Add(new VocabularyKey(nameof(IsInventoryOwnershipChangeLineGridDisplayingDimensionByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InventoryDimensionName { get; private set; }
        public VocabularyKey IsSalesOrderLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsSalesQuotationLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryMovementJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryAdjustmentJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryTransferJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryCountingJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsBillOfMaterialsLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryTransactionGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsTransferOrderLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsQuarantineOrderGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsQualityOrderGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsNonConformanceGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsCertificateOfAnalysisGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryBlockingGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsItemArrivalJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProductionInputJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsWarehousePickingLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryFixedAssetTransferJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProductionOrderGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProductionOrderLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProductionPickingListJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProductionReportedAsFinishedJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsByProductJournalLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryProjectConsumptionJournalGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsProjectQuotationLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsPurchaseOrderLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey DimFieldId { get; private set; }
        public VocabularyKey IsConsignmentReplenishmentOrderLineGridDisplayingDimensionByDefault { get; private set; }
        public VocabularyKey IsInventoryOwnershipChangeLineGridDisplayingDimensionByDefault { get; private set; }
    }
}