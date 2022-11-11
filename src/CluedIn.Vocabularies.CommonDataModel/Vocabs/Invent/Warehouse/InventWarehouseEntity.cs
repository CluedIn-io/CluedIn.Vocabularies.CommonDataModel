using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseEntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventWarehouseEntity";
            KeyPrefix = "commonDataModel.inventwarehouseentity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseEntity";

            AddGroup("Common Data Model InventWarehouseEntity Details", group =>
            {
                AreLaborStandardsAllowed = group.Add(new VocabularyKey(nameof(AreLaborStandardsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusChangeReservationRemovalLevel = group.Add(new VocabularyKey(nameof(InventoryStatusChangeReservationRemovalLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOrderReleasingConsolidateShipments = group.Add(new VocabularyKey(nameof(WillOrderReleasingConsolidateShipments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPalletMovementDuringCycleCountingAllowed = group.Add(new VocabularyKey(nameof(IsPalletMovementDuringCycleCountingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillShippingCancellationDecrementLoadQuanity = group.Add(new VocabularyKey(nameof(WillShippingCancellationDecrementLoadQuanity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseSpecificDefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(WarehouseSpecificDefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRetailStoreWarehouse = group.Add(new VocabularyKey(nameof(IsRetailStoreWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuarantineWarehouseId = group.Add(new VocabularyKey(nameof(QuarantineWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainRefillingWarehouseId = group.Add(new VocabularyKey(nameof(MainRefillingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitWarehouseId = group.Add(new VocabularyKey(nameof(TransitWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseType = group.Add(new VocabularyKey(nameof(WarehouseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreItemsCoveragePlannedManually = group.Add(new VocabularyKey(nameof(AreItemsCoveragePlannedManually), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseName = group.Add(new VocabularyKey(nameof(WarehouseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBillOfLadingPrintingBeforeShipmentConfirmationEnabled = group.Add(new VocabularyKey(nameof(IsBillOfLadingPrintingBeforeShipmentConfirmationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductionBOMsReserveWarehouseLevelOnly = group.Add(new VocabularyKey(nameof(WillProductionBOMsReserveWarehouseLevelOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInventoryStatusChangeRemoveBlocking = group.Add(new VocabularyKey(nameof(WillInventoryStatusChangeRemoveBlocking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterPlanningWorkCalendardId = group.Add(new VocabularyKey(nameof(MasterPlanningWorkCalendardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRefilledFromMainWarehouse = group.Add(new VocabularyKey(nameof(IsRefilledFromMainWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillManualLoadReleaseReserveInventory = group.Add(new VocabularyKey(nameof(WillManualLoadReleaseReserveInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinancialNegativeRetailStoreInventoryAllowed = group.Add(new VocabularyKey(nameof(IsFinancialNegativeRetailStoreInventoryAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalNegativeRetailStoreInventoryAllowed = group.Add(new VocabularyKey(nameof(IsPhysicalNegativeRetailStoreInventoryAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailStoreQuantityAllocationReplenismentRuleWeight = group.Add(new VocabularyKey(nameof(RetailStoreQuantityAllocationReplenismentRuleWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreWarehouseLocationCheckDigitsUnique = group.Add(new VocabularyKey(nameof(AreWarehouseLocationCheckDigitsUnique), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternallyLocatedWarehouseVendorAccountNumber = group.Add(new VocabularyKey(nameof(ExternallyLocatedWarehouseVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAdvancedWarehouseManagementProcessesEnabled = group.Add(new VocabularyKey(nameof(AreAdvancedWarehouseManagementProcessesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RawMaterialPickingInventoryIssueStatus = group.Add(new VocabularyKey(nameof(RawMaterialPickingInventoryIssueStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShouldWarehouseLocationIdIncludeAisleId = group.Add(new VocabularyKey(nameof(ShouldWarehouseLocationIdIncludeAisleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationIdShelfIdFormat = group.Add(new VocabularyKey(nameof(WarehouseLocationIdShelfIdFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWarehouseLocationIdIncludeShelfIdByDefault = group.Add(new VocabularyKey(nameof(WillWarehouseLocationIdIncludeShelfIdByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationIdBinIdFormat = group.Add(new VocabularyKey(nameof(WarehouseLocationIdBinIdFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWarehouseLocationIdIncludeBinIdByDefault = group.Add(new VocabularyKey(nameof(WillWarehouseLocationIdIncludeBinIdByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationIdRackIdFormat = group.Add(new VocabularyKey(nameof(WarehouseLocationIdRackIdFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillWarehouseLocationIdIncludeRackIdByDefault = group.Add(new VocabularyKey(nameof(WillWarehouseLocationIdIncludeRackIdByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticLoadReleaseReserveInventory = group.Add(new VocabularyKey(nameof(WillAutomaticLoadReleaseReserveInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPickingListLineQuantity = group.Add(new VocabularyKey(nameof(MaximumPickingListLineQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumBatchPickingListQuantity = group.Add(new VocabularyKey(nameof(MaximumBatchPickingListQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePickingListsDeliveryModeSpecific = group.Add(new VocabularyKey(nameof(ArePickingListsDeliveryModeSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePickingListsShipmentSpecificOnly = group.Add(new VocabularyKey(nameof(ArePickingListsShipmentSpecificOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickingWorkbenchWarehouseId = group.Add(new VocabularyKey(nameof(PickingWorkbenchWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFallbackWarehouse = group.Add(new VocabularyKey(nameof(IsFallbackWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackWarehouseId = group.Add(new VocabularyKey(nameof(FallbackWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackOperationalSiteId = group.Add(new VocabularyKey(nameof(FallbackOperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressValidFrom = group.Add(new VocabularyKey(nameof(PrimaryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressValidTo = group.Add(new VocabularyKey(nameof(PrimaryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedPrimaryAddress = group.Add(new VocabularyKey(nameof(FormattedPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCity = group.Add(new VocabularyKey(nameof(PrimaryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCityInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressCountyId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressDistrictName = group.Add(new VocabularyKey(nameof(PrimaryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLatitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLongitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStateId = group.Add(new VocabularyKey(nameof(PrimaryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreet = group.Add(new VocabularyKey(nameof(PrimaryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreetInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressStreetNumber = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressTimeZone = group.Add(new VocabularyKey(nameof(PrimaryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressZipCode = group.Add(new VocabularyKey(nameof(PrimaryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(PrimaryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressPostBox = group.Add(new VocabularyKey(nameof(PrimaryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLocationSalesTaxGroupCode = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationSalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryAddressAssigned = group.Add(new VocabularyKey(nameof(IsPrimaryAddressAssigned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryAddressLocationRoles = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternallyLocatedWarehouseCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ExternallyLocatedWarehouseCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationGroup = group.Add(new VocabularyKey(nameof(IdentificationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultContainerTypeId = group.Add(new VocabularyKey(nameof(DefaultContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryCountingReasonCodePolicyName = group.Add(new VocabularyKey(nameof(InventoryCountingReasonCodePolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventCountingReasonCodePolicyRecId = group.Add(new VocabularyKey(nameof(InventCountingReasonCodePolicyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseReleaseReservationRequirementRule = group.Add(new VocabularyKey(nameof(WarehouseReleaseReservationRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkProcessingPolicyName = group.Add(new VocabularyKey(nameof(WarehouseWorkProcessingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoUpdateShipmentRule = group.Add(new VocabularyKey(nameof(AutoUpdateShipmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AreLaborStandardsAllowed { get; private set; }
        public VocabularyKey InventoryStatusChangeReservationRemovalLevel { get; private set; }
        public VocabularyKey WillOrderReleasingConsolidateShipments { get; private set; }
        public VocabularyKey IsPalletMovementDuringCycleCountingAllowed { get; private set; }
        public VocabularyKey WillShippingCancellationDecrementLoadQuanity { get; private set; }
        public VocabularyKey WarehouseSpecificDefaultInventoryStatusId { get; private set; }
        public VocabularyKey IsRetailStoreWarehouse { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey QuarantineWarehouseId { get; private set; }
        public VocabularyKey MainRefillingWarehouseId { get; private set; }
        public VocabularyKey TransitWarehouseId { get; private set; }
        public VocabularyKey WarehouseType { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey AreItemsCoveragePlannedManually { get; private set; }
        public VocabularyKey WarehouseName { get; private set; }
        public VocabularyKey IsBillOfLadingPrintingBeforeShipmentConfirmationEnabled { get; private set; }
        public VocabularyKey WillProductionBOMsReserveWarehouseLevelOnly { get; private set; }
        public VocabularyKey WillInventoryStatusChangeRemoveBlocking { get; private set; }
        public VocabularyKey MasterPlanningWorkCalendardId { get; private set; }
        public VocabularyKey IsRefilledFromMainWarehouse { get; private set; }
        public VocabularyKey WillManualLoadReleaseReserveInventory { get; private set; }
        public VocabularyKey IsFinancialNegativeRetailStoreInventoryAllowed { get; private set; }
        public VocabularyKey IsPhysicalNegativeRetailStoreInventoryAllowed { get; private set; }
        public VocabularyKey RetailStoreQuantityAllocationReplenismentRuleWeight { get; private set; }
        public VocabularyKey AreWarehouseLocationCheckDigitsUnique { get; private set; }
        public VocabularyKey ExternallyLocatedWarehouseVendorAccountNumber { get; private set; }
        public VocabularyKey AreAdvancedWarehouseManagementProcessesEnabled { get; private set; }
        public VocabularyKey RawMaterialPickingInventoryIssueStatus { get; private set; }
        public VocabularyKey ShouldWarehouseLocationIdIncludeAisleId { get; private set; }
        public VocabularyKey WarehouseLocationIdShelfIdFormat { get; private set; }
        public VocabularyKey WillWarehouseLocationIdIncludeShelfIdByDefault { get; private set; }
        public VocabularyKey WarehouseLocationIdBinIdFormat { get; private set; }
        public VocabularyKey WillWarehouseLocationIdIncludeBinIdByDefault { get; private set; }
        public VocabularyKey WarehouseLocationIdRackIdFormat { get; private set; }
        public VocabularyKey WillWarehouseLocationIdIncludeRackIdByDefault { get; private set; }
        public VocabularyKey WillAutomaticLoadReleaseReserveInventory { get; private set; }
        public VocabularyKey MaximumPickingListLineQuantity { get; private set; }
        public VocabularyKey MaximumBatchPickingListQuantity { get; private set; }
        public VocabularyKey ArePickingListsDeliveryModeSpecific { get; private set; }
        public VocabularyKey ArePickingListsShipmentSpecificOnly { get; private set; }
        public VocabularyKey PickingWorkbenchWarehouseId { get; private set; }
        public VocabularyKey IsFallbackWarehouse { get; private set; }
        public VocabularyKey FallbackWarehouseId { get; private set; }
        public VocabularyKey FallbackOperationalSiteId { get; private set; }
        public VocabularyKey PrimaryAddressDescription { get; private set; }
        public VocabularyKey PrimaryAddressValidFrom { get; private set; }
        public VocabularyKey PrimaryAddressValidTo { get; private set; }
        public VocabularyKey FormattedPrimaryAddress { get; private set; }
        public VocabularyKey PrimaryAddressCity { get; private set; }
        public VocabularyKey PrimaryAddressCityInKana { get; private set; }
        public VocabularyKey PrimaryAddressCountryRegionId { get; private set; }
        public VocabularyKey PrimaryAddressCountyId { get; private set; }
        public VocabularyKey PrimaryAddressDistrictName { get; private set; }
        public VocabularyKey PrimaryAddressLatitude { get; private set; }
        public VocabularyKey PrimaryAddressLongitude { get; private set; }
        public VocabularyKey PrimaryAddressStateId { get; private set; }
        public VocabularyKey PrimaryAddressStreet { get; private set; }
        public VocabularyKey PrimaryAddressStreetInKana { get; private set; }
        public VocabularyKey PrimaryAddressStreetNumber { get; private set; }
        public VocabularyKey PrimaryAddressTimeZone { get; private set; }
        public VocabularyKey PrimaryAddressZipCode { get; private set; }
        public VocabularyKey PrimaryAddressBuildingCompliment { get; private set; }
        public VocabularyKey PrimaryAddressPostBox { get; private set; }
        public VocabularyKey PrimaryAddressLocationSalesTaxGroupCode { get; private set; }
        public VocabularyKey IsPrimaryAddressAssigned { get; private set; }
        public VocabularyKey PrimaryAddressLocationRoles { get; private set; }
        public VocabularyKey ExternallyLocatedWarehouseCustomerAccountNumber { get; private set; }
        public VocabularyKey IdentificationGroup { get; private set; }
        public VocabularyKey DefaultContainerTypeId { get; private set; }
        public VocabularyKey InventoryCountingReasonCodePolicyName { get; private set; }
        public VocabularyKey InventCountingReasonCodePolicyRecId { get; private set; }
        public VocabularyKey WarehouseReleaseReservationRequirementRule { get; private set; }
        public VocabularyKey WarehouseWorkProcessingPolicyName { get; private set; }
        public VocabularyKey AutoUpdateShipmentRule { get; private set; }


    }
}