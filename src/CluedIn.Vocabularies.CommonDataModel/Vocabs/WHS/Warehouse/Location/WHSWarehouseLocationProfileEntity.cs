using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationProfileEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationProfileEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Location Profile Entity";
            KeyPrefix = "commonDataModel.whswarehouselocationprofileentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationProfileEntity";

            AddGroup("WHSWarehouseLocationProfileEntity Details", group =>
            {
                IsLocationAllowingMixedItemBatches = group.Add(new VocabularyKey(nameof(IsLocationAllowingMixedItemBatches), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationAllowingMixedItems = group.Add(new VocabularyKey(nameof(IsLocationAllowingMixedItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationAllowingMixedItemStatuses = group.Add(new VocabularyKey(nameof(IsLocationAllowingMixedItemStatuses), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationAllowingNegativeInventory = group.Add(new VocabularyKey(nameof(IsLocationAllowingNegativeInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationAllowingCycleCounting = group.Add(new VocabularyKey(nameof(IsLocationAllowingCycleCounting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualLocationDepth = group.Add(new VocabularyKey(nameof(ActualLocationDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationVolumetricMethod = group.Add(new VocabularyKey(nameof(WarehouseLocationVolumetricMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DockManagementProfileId = group.Add(new VocabularyKey(nameof(DockManagementProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeUtilizationPercentage = group.Add(new VocabularyKey(nameof(VolumeUtilizationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerateCheckDigit = group.Add(new VocabularyKey(nameof(GenerateCheckDigit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualLocationHeight = group.Add(new VocabularyKey(nameof(ActualLocationHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideRulesForBatchDays = group.Add(new VocabularyKey(nameof(OverrideRulesForBatchDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationFormatId = group.Add(new VocabularyKey(nameof(WarehouseLocationFormatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileName = group.Add(new VocabularyKey(nameof(ProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationTypeId = group.Add(new VocabularyKey(nameof(WarehouseLocationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseLicensePlateTracking = group.Add(new VocabularyKey(nameof(UseLicensePlateTracking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLocationWeight = group.Add(new VocabularyKey(nameof(MaximumLocationWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageUnitSymbol = group.Add(new VocabularyKey(nameof(StorageUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualLocationVolume = group.Add(new VocabularyKey(nameof(ActualLocationVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableLocationDepth = group.Add(new VocabularyKey(nameof(UsableLocationDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableLocationHeight = group.Add(new VocabularyKey(nameof(UsableLocationHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableLocationVolume = group.Add(new VocabularyKey(nameof(UsableLocationVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableLocationWidth = group.Add(new VocabularyKey(nameof(UsableLocationWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualLocationWidth = group.Add(new VocabularyKey(nameof(ActualLocationWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedContainerTypeGroupId = group.Add(new VocabularyKey(nameof(AllowedContainerTypeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedContainerTypeGroupName = group.Add(new VocabularyKey(nameof(AllowedContainerTypeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemInLocationUpdateEnabled = group.Add(new VocabularyKey(nameof(IsItemInLocationUpdateEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationActivityDateTimeUpdateEnabled = group.Add(new VocabularyKey(nameof(IsLocationActivityDateTimeUpdateEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationStatusUpdateEnabled = group.Add(new VocabularyKey(nameof(IsLocationStatusUpdateEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanReplenishmentExceedLocationCapacity = group.Add(new VocabularyKey(nameof(CanReplenishmentExceedLocationCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentOverflowCapacityPercentage = group.Add(new VocabularyKey(nameof(ReplenishmentOverflowCapacityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentOverflowCapacityQuantity = group.Add(new VocabularyKey(nameof(ReplenishmentOverflowCapacityQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentOverflowCapacityUnitSymbol = group.Add(new VocabularyKey(nameof(ReplenishmentOverflowCapacityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkAvailabilityThresholdType = group.Add(new VocabularyKey(nameof(WorkAvailabilityThresholdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationAllowingMixingProductStyles = group.Add(new VocabularyKey(nameof(IsWarehouseLocationAllowingMixingProductStyles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationAllowingMixingProductVersions = group.Add(new VocabularyKey(nameof(IsWarehouseLocationAllowingMixingProductVersions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationAllowingMixingProductSizes = group.Add(new VocabularyKey(nameof(IsWarehouseLocationAllowingMixingProductSizes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationAllowingMixingProductConfigurations = group.Add(new VocabularyKey(nameof(IsWarehouseLocationAllowingMixingProductConfigurations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationAllowingMixingProductColors = group.Add(new VocabularyKey(nameof(IsWarehouseLocationAllowingMixingProductColors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimFixed = group.Add(new VocabularyKey(nameof(ProductDimFixed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationEnablingMixingProductDimensions = group.Add(new VocabularyKey(nameof(IsWarehouseLocationEnablingMixingProductDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationLicensePlatePositioningEnabled = group.Add(new VocabularyKey(nameof(IsLocationLicensePlatePositioningEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillMobileDeviceDisplayLicensePlatePosition = group.Add(new VocabularyKey(nameof(WillMobileDeviceDisplayLicensePlatePosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsLocationAllowingMixedItemBatches { get; private set; }
        public VocabularyKey IsLocationAllowingMixedItems { get; private set; }
        public VocabularyKey IsLocationAllowingMixedItemStatuses { get; private set; }
        public VocabularyKey IsLocationAllowingNegativeInventory { get; private set; }
        public VocabularyKey IsLocationAllowingCycleCounting { get; private set; }
        public VocabularyKey ActualLocationDepth { get; private set; }
        public VocabularyKey WarehouseLocationVolumetricMethod { get; private set; }
        public VocabularyKey DockManagementProfileId { get; private set; }
        public VocabularyKey VolumeUtilizationPercentage { get; private set; }
        public VocabularyKey GenerateCheckDigit { get; private set; }
        public VocabularyKey ActualLocationHeight { get; private set; }
        public VocabularyKey OverrideRulesForBatchDays { get; private set; }
        public VocabularyKey WarehouseLocationFormatId { get; private set; }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey ProfileName { get; private set; }
        public VocabularyKey WarehouseLocationTypeId { get; private set; }
        public VocabularyKey UseLicensePlateTracking { get; private set; }
        public VocabularyKey MaximumLocationWeight { get; private set; }
        public VocabularyKey StorageUnitSymbol { get; private set; }
        public VocabularyKey ActualLocationVolume { get; private set; }
        public VocabularyKey UsableLocationDepth { get; private set; }
        public VocabularyKey UsableLocationHeight { get; private set; }
        public VocabularyKey UsableLocationVolume { get; private set; }
        public VocabularyKey UsableLocationWidth { get; private set; }
        public VocabularyKey ActualLocationWidth { get; private set; }
        public VocabularyKey AllowedContainerTypeGroupId { get; private set; }
        public VocabularyKey AllowedContainerTypeGroupName { get; private set; }
        public VocabularyKey IsItemInLocationUpdateEnabled { get; private set; }
        public VocabularyKey IsLocationActivityDateTimeUpdateEnabled { get; private set; }
        public VocabularyKey IsLocationStatusUpdateEnabled { get; private set; }
        public VocabularyKey CanReplenishmentExceedLocationCapacity { get; private set; }
        public VocabularyKey ReplenishmentOverflowCapacityPercentage { get; private set; }
        public VocabularyKey ReplenishmentOverflowCapacityQuantity { get; private set; }
        public VocabularyKey ReplenishmentOverflowCapacityUnitSymbol { get; private set; }
        public VocabularyKey WorkAvailabilityThresholdType { get; private set; }
        public VocabularyKey IsWarehouseLocationAllowingMixingProductStyles { get; private set; }
        public VocabularyKey IsWarehouseLocationAllowingMixingProductVersions { get; private set; }
        public VocabularyKey IsWarehouseLocationAllowingMixingProductSizes { get; private set; }
        public VocabularyKey IsWarehouseLocationAllowingMixingProductConfigurations { get; private set; }
        public VocabularyKey IsWarehouseLocationAllowingMixingProductColors { get; private set; }
        public VocabularyKey ProductDimFixed { get; private set; }
        public VocabularyKey IsWarehouseLocationEnablingMixingProductDimensions { get; private set; }
        public VocabularyKey IsLocationLicensePlatePositioningEnabled { get; private set; }
        public VocabularyKey WillMobileDeviceDisplayLicensePlatePosition { get; private set; }
    }
}