using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseManagementParametersV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseManagementParametersV2EntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Management Parameters V2 Entity";
            KeyPrefix = "commonDataModel.whswarehousemanagementparametersv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseManagementParametersV2Entity";

            AddGroup("WHSWarehouseManagementParametersV2Entity Details", group =>
            {
                GS1CompanyPrefix = group.Add(new VocabularyKey(nameof(GS1CompanyPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultUserWarehouseLocationProfileId = group.Add(new VocabularyKey(nameof(DefaultUserWarehouseLocationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultStagingWarehouseLocationTypeId = group.Add(new VocabularyKey(nameof(DefaultStagingWarehouseLocationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFinalShippingWarehouseLocationTypeId = group.Add(new VocabularyKey(nameof(DefaultFinalShippingWarehouseLocationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MissingASNItemWorkExceptionCode = group.Add(new VocabularyKey(nameof(MissingASNItemWorkExceptionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBarcodeSetupId = group.Add(new VocabularyKey(nameof(DefaultBarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLicensePlateUnitSymbol = group.Add(new VocabularyKey(nameof(DefaultLicensePlateUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWaveProcessingBatchGroup = group.Add(new VocabularyKey(nameof(DefaultWaveProcessingBatchGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreWavesBatchProcessed = group.Add(new VocabularyKey(nameof(AreWavesBatchProcessed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWaveProgressLogCreated = group.Add(new VocabularyKey(nameof(IsWaveProgressLogCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWaveProcessingHistoryLogCreated = group.Add(new VocabularyKey(nameof(IsWaveProcessingHistoryLogCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContainerizationHistoryLogCreated = group.Add(new VocabularyKey(nameof(IsContainerizationHistoryLogCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveLockWaitValue = group.Add(new VocabularyKey(nameof(WaveLockWaitValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryAdjustmentTypeCode = group.Add(new VocabularyKey(nameof(DefaultInventoryAdjustmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemporaryWorkTableRetained = group.Add(new VocabularyKey(nameof(IsTemporaryWorkTableRetained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkCreationHistoryLogCreated = group.Add(new VocabularyKey(nameof(IsWorkCreationHistoryLogCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWarehouseWorkPriority = group.Add(new VocabularyKey(nameof(DefaultWarehouseWorkPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWorkCancellationUnregisteringRecept = group.Add(new VocabularyKey(nameof(IsWorkCancellationUnregisteringRecept), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowMixingBatchesDays = group.Add(new VocabularyKey(nameof(AllowMixingBatchesDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceNoteType = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceNoteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceScannedQuantityLimit = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceScannedQuantityLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreWarehouseMobileDeviceSessionsLogged = group.Add(new VocabularyKey(nameof(AreWarehouseMobileDeviceSessionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumStoredWarehouseMobileDeviceErrors = group.Add(new VocabularyKey(nameof(MaximumStoredWarehouseMobileDeviceErrors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryTransferJournalNameId = group.Add(new VocabularyKey(nameof(DefaultInventoryTransferJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultItemArrivalOrderJournalId = group.Add(new VocabularyKey(nameof(DefaultItemArrivalOrderJournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryStatusDefaultedForOutboundOrders = group.Add(new VocabularyKey(nameof(IsInventoryStatusDefaultedForOutboundOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesOrderEntryAutomaticallyCreatingLoad = group.Add(new VocabularyKey(nameof(IsSalesOrderEntryAutomaticallyCreatingLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferOrderEntryAutomaticallyCreatingLoad = group.Add(new VocabularyKey(nameof(IsTransferOrderEntryAutomaticallyCreatingLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseOrderEntryAutomaticallyCreatingLoad = group.Add(new VocabularyKey(nameof(IsPurchaseOrderEntryAutomaticallyCreatingLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOrderDeleteAutomaticallyDeletingLoad = group.Add(new VocabularyKey(nameof(IsOrderDeleteAutomaticallyDeletingLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWaveProcessingConsolidatingLoads = group.Add(new VocabularyKey(nameof(IsWaveProcessingConsolidatingLoads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadSynchronizationPolicy = group.Add(new VocabularyKey(nameof(LoadSynchronizationPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreWarehouseProcessesCreatingLoadHistoryLog = group.Add(new VocabularyKey(nameof(AreWarehouseProcessesCreatingLoadHistoryLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreOrderProcessesCreatingLoadHistoryLog = group.Add(new VocabularyKey(nameof(AreOrderProcessesCreatingLoadHistoryLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCycleCountingAdjustmentTypeCode = group.Add(new VocabularyKey(nameof(DefaultCycleCountingAdjustmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCycleCountWorkClassId = group.Add(new VocabularyKey(nameof(DefaultCycleCountWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCycleCountWorkPriority = group.Add(new VocabularyKey(nameof(DefaultCycleCountWorkPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCustomerFiltersEnabled = group.Add(new VocabularyKey(nameof(AreCustomerFiltersEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerFilterCode = group.Add(new VocabularyKey(nameof(DefaultCustomerFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreVendorFiltersEnabled = group.Add(new VocabularyKey(nameof(AreVendorFiltersEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVendorFilterCode = group.Add(new VocabularyKey(nameof(DefaultVendorFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryFilterWildcard = group.Add(new VocabularyKey(nameof(DefaultInventoryFilterWildcard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingNoteType = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingNoteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultingFreightCountingParty = group.Add(new VocabularyKey(nameof(DefaultingFreightCountingParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerLoadingParty = group.Add(new VocabularyKey(nameof(TrailerLoadingParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShipmentPickingListNoteType = group.Add(new VocabularyKey(nameof(DefaultShipmentPickingListNoteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLoadReportNoteType = group.Add(new VocabularyKey(nameof(DefaultLoadReportNoteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingWarehouseLocationProfileId = group.Add(new VocabularyKey(nameof(PackingWarehouseLocationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingWarehouseLocationType = group.Add(new VocabularyKey(nameof(PackingWarehouseLocationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEarlyToteReuseEnabled = group.Add(new VocabularyKey(nameof(IsEarlyToteReuseEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPackingScreenNoteType = group.Add(new VocabularyKey(nameof(DefaultPackingScreenNoteType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWarehouseReleaseDisplayCreditLimitCheckDialog = group.Add(new VocabularyKey(nameof(WillWarehouseReleaseDisplayCreditLimitCheckDialog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultContainerTypeId = group.Add(new VocabularyKey(nameof(DefaultContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPendingAllocationLogCreated = group.Add(new VocabularyKey(nameof(IsPendingAllocationLogCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderFulfillmentPolicyName = group.Add(new VocabularyKey(nameof(SalesOrderFulfillmentPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderFulfillmentPolicy = group.Add(new VocabularyKey(nameof(SalesOrderFulfillmentPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderFulfillmentPolicy = group.Add(new VocabularyKey(nameof(TransferOrderFulfillmentPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderFulfillmentPolicyName = group.Add(new VocabularyKey(nameof(TransferOrderFulfillmentPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferOrderReceivingProcess = group.Add(new VocabularyKey(nameof(TransferOrderReceivingProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MissingASNItemWorkExceptionType = group.Add(new VocabularyKey(nameof(MissingASNItemWorkExceptionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralWorkProcessingPolicyName = group.Add(new VocabularyKey(nameof(GeneralWorkProcessingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWaveLabelBuildingGenerateBillOfLadingNumber = group.Add(new VocabularyKey(nameof(WillWaveLabelBuildingGenerateBillOfLadingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutboundSortingLocationTypeId = group.Add(new VocabularyKey(nameof(OutboundSortingLocationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseOrderRegistrationInExternalReviewEnabled = group.Add(new VocabularyKey(nameof(IsPurchaseOrderRegistrationInExternalReviewEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitWarehouseLicensePlatePolicy = group.Add(new VocabularyKey(nameof(TransitWarehouseLicensePlatePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GS1CompanyPrefix { get; private set; }
        public VocabularyKey DefaultUserWarehouseLocationProfileId { get; private set; }
        public VocabularyKey DefaultStagingWarehouseLocationTypeId { get; private set; }
        public VocabularyKey DefaultFinalShippingWarehouseLocationTypeId { get; private set; }
        public VocabularyKey MissingASNItemWorkExceptionCode { get; private set; }
        public VocabularyKey DefaultBarcodeSetupId { get; private set; }
        public VocabularyKey DefaultLicensePlateUnitSymbol { get; private set; }
        public VocabularyKey DefaultWaveProcessingBatchGroup { get; private set; }
        public VocabularyKey AreWavesBatchProcessed { get; private set; }
        public VocabularyKey IsWaveProgressLogCreated { get; private set; }
        public VocabularyKey IsWaveProcessingHistoryLogCreated { get; private set; }
        public VocabularyKey IsContainerizationHistoryLogCreated { get; private set; }
        public VocabularyKey WaveLockWaitValue { get; private set; }
        public VocabularyKey DefaultInventoryAdjustmentTypeCode { get; private set; }
        public VocabularyKey IsTemporaryWorkTableRetained { get; private set; }
        public VocabularyKey IsWorkCreationHistoryLogCreated { get; private set; }
        public VocabularyKey DefaultWarehouseWorkPriority { get; private set; }
        public VocabularyKey IsWorkCancellationUnregisteringRecept { get; private set; }
        public VocabularyKey AllowMixingBatchesDays { get; private set; }
        public VocabularyKey WarehouseMobileDeviceNoteType { get; private set; }
        public VocabularyKey WarehouseMobileDeviceScannedQuantityLimit { get; private set; }
        public VocabularyKey AreWarehouseMobileDeviceSessionsLogged { get; private set; }
        public VocabularyKey MaximumStoredWarehouseMobileDeviceErrors { get; private set; }
        public VocabularyKey DefaultInventoryTransferJournalNameId { get; private set; }
        public VocabularyKey DefaultItemArrivalOrderJournalId { get; private set; }
        public VocabularyKey DefaultInventoryStatusId { get; private set; }
        public VocabularyKey IsInventoryStatusDefaultedForOutboundOrders { get; private set; }
        public VocabularyKey IsSalesOrderEntryAutomaticallyCreatingLoad { get; private set; }
        public VocabularyKey IsTransferOrderEntryAutomaticallyCreatingLoad { get; private set; }
        public VocabularyKey IsPurchaseOrderEntryAutomaticallyCreatingLoad { get; private set; }
        public VocabularyKey IsOrderDeleteAutomaticallyDeletingLoad { get; private set; }
        public VocabularyKey IsWaveProcessingConsolidatingLoads { get; private set; }
        public VocabularyKey LoadSynchronizationPolicy { get; private set; }
        public VocabularyKey AreWarehouseProcessesCreatingLoadHistoryLog { get; private set; }
        public VocabularyKey AreOrderProcessesCreatingLoadHistoryLog { get; private set; }
        public VocabularyKey DefaultCycleCountingAdjustmentTypeCode { get; private set; }
        public VocabularyKey DefaultCycleCountWorkClassId { get; private set; }
        public VocabularyKey DefaultCycleCountWorkPriority { get; private set; }
        public VocabularyKey AreCustomerFiltersEnabled { get; private set; }
        public VocabularyKey DefaultCustomerFilterCode { get; private set; }
        public VocabularyKey AreVendorFiltersEnabled { get; private set; }
        public VocabularyKey DefaultVendorFilterCode { get; private set; }
        public VocabularyKey DefaultInventoryFilterWildcard { get; private set; }
        public VocabularyKey DefaultBillOfLadingNoteType { get; private set; }
        public VocabularyKey DefaultingFreightCountingParty { get; private set; }
        public VocabularyKey TrailerLoadingParty { get; private set; }
        public VocabularyKey DefaultShipmentPickingListNoteType { get; private set; }
        public VocabularyKey DefaultLoadReportNoteType { get; private set; }
        public VocabularyKey PackingWarehouseLocationProfileId { get; private set; }
        public VocabularyKey PackingWarehouseLocationType { get; private set; }
        public VocabularyKey IsEarlyToteReuseEnabled { get; private set; }
        public VocabularyKey DefaultPackingScreenNoteType { get; private set; }
        public VocabularyKey WillWarehouseReleaseDisplayCreditLimitCheckDialog { get; private set; }
        public VocabularyKey DefaultContainerTypeId { get; private set; }
        public VocabularyKey IsPendingAllocationLogCreated { get; private set; }
        public VocabularyKey SalesOrderFulfillmentPolicyName { get; private set; }
        public VocabularyKey SalesOrderFulfillmentPolicy { get; private set; }
        public VocabularyKey TransferOrderFulfillmentPolicy { get; private set; }
        public VocabularyKey TransferOrderFulfillmentPolicyName { get; private set; }
        public VocabularyKey TransferOrderReceivingProcess { get; private set; }
        public VocabularyKey MissingASNItemWorkExceptionType { get; private set; }
        public VocabularyKey GeneralWorkProcessingPolicyName { get; private set; }
        public VocabularyKey WillWaveLabelBuildingGenerateBillOfLadingNumber { get; private set; }
        public VocabularyKey OutboundSortingLocationTypeId { get; private set; }
        public VocabularyKey IsPurchaseOrderRegistrationInExternalReviewEnabled { get; private set; }
        public VocabularyKey TransitWarehouseLicensePlatePolicy { get; private set; }
    }
}