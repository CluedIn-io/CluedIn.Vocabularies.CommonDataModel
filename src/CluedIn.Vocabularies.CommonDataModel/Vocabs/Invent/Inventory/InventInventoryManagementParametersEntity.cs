using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryManagementParametersEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryManagementParametersEntityVocabulary()
        {
            VocabularyName = "Invent Inventory Management Parameters Entity";
            KeyPrefix = "commonDataModel.inventinventorymanagementparametersentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryManagementParametersEntity";

            AddGroup("InventInventoryManagementParametersEntity Details", group =>
            {
                WillOrderPickingAutomaticallyEndInventoryOutputOrders = group.Add(new VocabularyKey(nameof(WillOrderPickingAutomaticallyEndInventoryOutputOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintedPickingListPickingRouteIdBarcodeSetupId = group.Add(new VocabularyKey(nameof(PrintedPickingListPickingRouteIdBarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOrderedInventoryQuantityReservationAllowed = group.Add(new VocabularyKey(nameof(IsOrderedInventoryQuantityReservationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryCountingLockItems = group.Add(new VocabularyKey(nameof(WillInventoryCountingLockItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryUnitSymbol = group.Add(new VocabularyKey(nameof(DefaultInventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePackingMaterialFeesCalculated = group.Add(new VocabularyKey(nameof(ArePackingMaterialFeesCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackWarehouseId = group.Add(new VocabularyKey(nameof(FallbackWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemSalesTaxGroupMandatory = group.Add(new VocabularyKey(nameof(IsItemSalesTaxGroupMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPickingWorkbenchApplyBoxingLogic = group.Add(new VocabularyKey(nameof(WillPickingWorkbenchApplyBoxingLogic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryMovementJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryMovementJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryAdjustmentJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryAdjustmentJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryTransferJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryTransferJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryCountingJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryCountingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBOMJournalNameId = group.Add(new VocabularyKey(nameof(DefaultBOMJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryTagCountingJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryTagCountingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCatchWeightJournalNameId = group.Add(new VocabularyKey(nameof(DefaultCatchWeightJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOwnershipChangeJournalNameId = group.Add(new VocabularyKey(nameof(DefaultOwnershipChangeJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBatchMergeBOMJournalNameId = group.Add(new VocabularyKey(nameof(DefaultBatchMergeBOMJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceActivationItemBundleSize = group.Add(new VocabularyKey(nameof(PriceActivationItemBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostPhysicalSalesTax = group.Add(new VocabularyKey(nameof(PostPhysicalSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryUpdateAutomaticallyAggregateTransactions = group.Add(new VocabularyKey(nameof(WillInventoryUpdateAutomaticallyAggregateTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAllowedUnitCost = group.Add(new VocabularyKey(nameof(MaximumAllowedUnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaveLastPriceHistory = group.Add(new VocabularyKey(nameof(SaveLastPriceHistory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryClosingExtraBatchHelperAmount = group.Add(new VocabularyKey(nameof(InventoryClosingExtraBatchHelperAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryClosingHelperBatchGroupId = group.Add(new VocabularyKey(nameof(InventoryClosingHelperBatchGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryClosingItemBundleSize = group.Add(new VocabularyKey(nameof(InventoryClosingItemBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostBreakdownType = group.Add(new VocabularyKey(nameof(CostBreakdownType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionVarianceCalculationModel = group.Add(new VocabularyKey(nameof(ProductionVarianceCalculationModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransferOrderEntryAutomaticallyReserveItems = group.Add(new VocabularyKey(nameof(WillTransferOrderEntryAutomaticallyReserveItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideFEFODateControlForTransferOrders = group.Add(new VocabularyKey(nameof(OverrideFEFODateControlForTransferOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransferOrderProcessesAcceptOverdelivery = group.Add(new VocabularyKey(nameof(WillTransferOrderProcessesAcceptOverdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransferOrderProcessesAcceptUnderdelivery = group.Add(new VocabularyKey(nameof(WillTransferOrderProcessesAcceptUnderdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderPickingRouteStatusOnUpdate = group.Add(new VocabularyKey(nameof(TransferOrderPickingRouteStatusOnUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillQualityTestResultsUpdateBatchAttributes = group.Add(new VocabularyKey(nameof(WillQualityTestResultsUpdateBatchAttributes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreQualityManagementProcessesEnabled = group.Add(new VocabularyKey(nameof(AreQualityManagementProcessesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestHourlyRate = group.Add(new VocabularyKey(nameof(QualityTestHourlyRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSiteSpecificMainAccountsEnabled = group.Add(new VocabularyKey(nameof(AreSiteSpecificMainAccountsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MassDefinedUnitSymbol = group.Add(new VocabularyKey(nameof(MassDefinedUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeDefinedUnitSymbol = group.Add(new VocabularyKey(nameof(VolumeDefinedUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LengthDefinedUnitSymbol = group.Add(new VocabularyKey(nameof(LengthDefinedUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillOrderPickingAutomaticallyEndInventoryOutputOrders { get; private set; }
        public VocabularyKey PrintedPickingListPickingRouteIdBarcodeSetupId { get; private set; }
        public VocabularyKey IsOrderedInventoryQuantityReservationAllowed { get; private set; }
        public VocabularyKey WillInventoryCountingLockItems { get; private set; }
        public VocabularyKey DefaultInventoryUnitSymbol { get; private set; }
        public VocabularyKey ArePackingMaterialFeesCalculated { get; private set; }
        public VocabularyKey FallbackWarehouseId { get; private set; }
        public VocabularyKey IsItemSalesTaxGroupMandatory { get; private set; }
        public VocabularyKey WillPickingWorkbenchApplyBoxingLogic { get; private set; }
        public VocabularyKey DefaultInventoryMovementJournalNameId { get; private set; }
        public VocabularyKey DefaultInventoryAdjustmentJournalNameId { get; private set; }
        public VocabularyKey DefaultInventoryTransferJournalNameId { get; private set; }
        public VocabularyKey DefaultInventoryCountingJournalNameId { get; private set; }
        public VocabularyKey DefaultBOMJournalNameId { get; private set; }
        public VocabularyKey DefaultInventoryTagCountingJournalNameId { get; private set; }
        public VocabularyKey DefaultCatchWeightJournalNameId { get; private set; }
        public VocabularyKey DefaultOwnershipChangeJournalNameId { get; private set; }
        public VocabularyKey DefaultBatchMergeBOMJournalNameId { get; private set; }
        public VocabularyKey PriceActivationItemBundleSize { get; private set; }
        public VocabularyKey PostPhysicalSalesTax { get; private set; }
        public VocabularyKey WillInventoryUpdateAutomaticallyAggregateTransactions { get; private set; }
        public VocabularyKey MaximumAllowedUnitCost { get; private set; }
        public VocabularyKey SaveLastPriceHistory { get; private set; }
        public VocabularyKey InventoryClosingExtraBatchHelperAmount { get; private set; }
        public VocabularyKey InventoryClosingHelperBatchGroupId { get; private set; }
        public VocabularyKey InventoryClosingItemBundleSize { get; private set; }
        public VocabularyKey CostBreakdownType { get; private set; }
        public VocabularyKey ProductionVarianceCalculationModel { get; private set; }
        public VocabularyKey WillTransferOrderEntryAutomaticallyReserveItems { get; private set; }
        public VocabularyKey OverrideFEFODateControlForTransferOrders { get; private set; }
        public VocabularyKey WillTransferOrderProcessesAcceptOverdelivery { get; private set; }
        public VocabularyKey WillTransferOrderProcessesAcceptUnderdelivery { get; private set; }
        public VocabularyKey TransferOrderPickingRouteStatusOnUpdate { get; private set; }
        public VocabularyKey WillQualityTestResultsUpdateBatchAttributes { get; private set; }
        public VocabularyKey AreQualityManagementProcessesEnabled { get; private set; }
        public VocabularyKey QualityTestHourlyRate { get; private set; }
        public VocabularyKey AreSiteSpecificMainAccountsEnabled { get; private set; }
        public VocabularyKey MassDefinedUnitSymbol { get; private set; }
        public VocabularyKey VolumeDefinedUnitSymbol { get; private set; }
        public VocabularyKey LengthDefinedUnitSymbol { get; private set; }
    }
}