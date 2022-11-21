using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSWarehouseLocationEntityVocabulary : SimpleVocabulary
    {
        public WMSWarehouseLocationEntityVocabulary()
        {
            VocabularyName = "WMS Warehouse Location Entity";
            KeyPrefix = "commonDataModel.wmswarehouselocationentity";
            KeySeparator = ".";
            Grouping = "/WMSWarehouseLocationEntity";

            AddGroup("WMSWarehouseLocationEntity Details", group =>
            {
                BinId = group.Add(new VocabularyKey(nameof(BinId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckDigits = group.Add(new VocabularyKey(nameof(CheckDigits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationWarehouseLocationId = group.Add(new VocabularyKey(nameof(DestinationWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerateCheckDigits = group.Add(new VocabularyKey(nameof(GenerateCheckDigits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSortOrderCodeManual = group.Add(new VocabularyKey(nameof(IsSortOrderCodeManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationIdManual = group.Add(new VocabularyKey(nameof(IsWarehouseLocationIdManual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastCountedUTCDateTime = group.Add(new VocabularyKey(nameof(LastCountedUTCDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalDepth = group.Add(new VocabularyKey(nameof(PhysicalDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalHeight = group.Add(new VocabularyKey(nameof(PhysicalHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalHeightAboveGround = group.Add(new VocabularyKey(nameof(PhysicalHeightAboveGround), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalMaximumStorageVolume = group.Add(new VocabularyKey(nameof(PhysicalMaximumStorageVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalMaximumStorageWeight = group.Add(new VocabularyKey(nameof(PhysicalMaximumStorageWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalWidth = group.Add(new VocabularyKey(nameof(PhysicalWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RackId = group.Add(new VocabularyKey(nameof(RackId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShelfId = group.Add(new VocabularyKey(nameof(ShelfId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortOrderCode = group.Add(new VocabularyKey(nameof(SortOrderCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseAisleId = group.Add(new VocabularyKey(nameof(WarehouseAisleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationProfileId = group.Add(new VocabularyKey(nameof(WarehouseLocationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationType = group.Add(new VocabularyKey(nameof(WarehouseLocationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseZoneId = group.Add(new VocabularyKey(nameof(WarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputWarehouseLocationBlockingCauseId = group.Add(new VocabularyKey(nameof(InputWarehouseLocationBlockingCauseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutputWarehouseLocationBlockingCauseId = group.Add(new VocabularyKey(nameof(OutputWarehouseLocationBlockingCauseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultCreditOnlyReturnWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultCreditOnlyReturnWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultIssueWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultIssueWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultKanbanFinishedGoodsWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultKanbanFinishedGoodsWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultProductionFinishedGoodsWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultProductionFinishedGoodsWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultProductionInputWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultProductionInputWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultReceiptWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultReceiptWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultRetailStoreReturnWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultRetailStoreReturnWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultRetailStoreWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultRetailStoreWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultShipmentMaintenanceWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultShipmentMaintenanceWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstAdditionalWarehouseZoneId = group.Add(new VocabularyKey(nameof(FirstAdditionalWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondAdditionalWarehouseZoneId = group.Add(new VocabularyKey(nameof(SecondAdditionalWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdAdditionalWarehouseZoneId = group.Add(new VocabularyKey(nameof(ThirdAdditionalWarehouseZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingDate = group.Add(new VocabularyKey(nameof(AgingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumberInLocation = group.Add(new VocabularyKey(nameof(ItemNumberInLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastActivityDateTime = group.Add(new VocabularyKey(nameof(LastActivityDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationStatus = group.Add(new VocabularyKey(nameof(LocationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemInLocationMaintained = group.Add(new VocabularyKey(nameof(IsItemInLocationMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationActivityDateTimeMaintained = group.Add(new VocabularyKey(nameof(IsLocationActivityDateTimeMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationStatusMaintained = group.Add(new VocabularyKey(nameof(IsLocationStatusMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultQualityMaintenanceWarehouseLocation = group.Add(new VocabularyKey(nameof(IsDefaultQualityMaintenanceWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BinId { get; private set; }
        public VocabularyKey CheckDigits { get; private set; }
        public VocabularyKey DestinationWarehouseLocationId { get; private set; }
        public VocabularyKey GenerateCheckDigits { get; private set; }
        public VocabularyKey IsSortOrderCodeManual { get; private set; }
        public VocabularyKey IsWarehouseLocationIdManual { get; private set; }
        public VocabularyKey LastCountedUTCDateTime { get; private set; }
        public VocabularyKey PhysicalDepth { get; private set; }
        public VocabularyKey PhysicalHeight { get; private set; }
        public VocabularyKey PhysicalHeightAboveGround { get; private set; }
        public VocabularyKey PhysicalMaximumStorageVolume { get; private set; }
        public VocabularyKey PhysicalMaximumStorageWeight { get; private set; }
        public VocabularyKey PhysicalWidth { get; private set; }
        public VocabularyKey RackId { get; private set; }
        public VocabularyKey ShelfId { get; private set; }
        public VocabularyKey SortOrderCode { get; private set; }
        public VocabularyKey WarehouseAisleId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey WarehouseLocationProfileId { get; private set; }
        public VocabularyKey WarehouseLocationType { get; private set; }
        public VocabularyKey WarehouseZoneId { get; private set; }
        public VocabularyKey InputWarehouseLocationBlockingCauseId { get; private set; }
        public VocabularyKey OutputWarehouseLocationBlockingCauseId { get; private set; }
        public VocabularyKey IsDefaultCreditOnlyReturnWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultIssueWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultKanbanFinishedGoodsWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultProductionFinishedGoodsWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultProductionInputWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultReceiptWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultRetailStoreReturnWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultRetailStoreWarehouseLocation { get; private set; }
        public VocabularyKey IsDefaultShipmentMaintenanceWarehouseLocation { get; private set; }
        public VocabularyKey FirstAdditionalWarehouseZoneId { get; private set; }
        public VocabularyKey SecondAdditionalWarehouseZoneId { get; private set; }
        public VocabularyKey ThirdAdditionalWarehouseZoneId { get; private set; }
        public VocabularyKey AgingDate { get; private set; }
        public VocabularyKey ItemNumberInLocation { get; private set; }
        public VocabularyKey LastActivityDateTime { get; private set; }
        public VocabularyKey LocationStatus { get; private set; }
        public VocabularyKey IsItemInLocationMaintained { get; private set; }
        public VocabularyKey IsLocationActivityDateTimeMaintained { get; private set; }
        public VocabularyKey IsLocationStatusMaintained { get; private set; }
        public VocabularyKey IsDefaultQualityMaintenanceWarehouseLocation { get; private set; }
    }
}