using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSItemArrivalJournalLineV2EntityVocabulary : SimpleVocabulary
    {
        public WMSItemArrivalJournalLineV2EntityVocabulary()
        {
            VocabularyName = "WMSItemArrivalJournalLineV2Entity";
            KeyPrefix = "commonDataModel.wmsitemarrivaljournallinev2entity";
            KeySeparator = ".";
            Grouping = "/WMSItemArrivalJournalLineV2Entity";

            AddGroup("WMSItemArrivalJournalLineV2Entity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingInventorySiteId = group.Add(new VocabularyKey(nameof(ReceivingInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingInventoryStatusId = group.Add(new VocabularyKey(nameof(ReceivingInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingWarehouseLocationId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingLicensePlateNumber = group.Add(new VocabularyKey(nameof(ReceivingLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemMovedToDefaultItemPickingWarehouseLocation = group.Add(new VocabularyKey(nameof(IsItemMovedToDefaultItemPickingWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuarantineOrderCreatedForReceivedItem = group.Add(new VocabularyKey(nameof(IsQuarantineOrderCreatedForReceivedItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionReferenceType = group.Add(new VocabularyKey(nameof(TransactionReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionReferenceNumber = group.Add(new VocabularyKey(nameof(TransactionReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceInventoryLotId = group.Add(new VocabularyKey(nameof(ReferenceInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnOrder = group.Add(new VocabularyKey(nameof(IsReturnOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ItemCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemQuantity = group.Add(new VocabularyKey(nameof(ItemQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDispositionCodeId = group.Add(new VocabularyKey(nameof(ReturnDispositionCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnItemNumber = group.Add(new VocabularyKey(nameof(ReturnItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ReceivingInventorySiteId { get; private set; }
        public VocabularyKey ReceivingWarehouseId { get; private set; }
        public VocabularyKey ReceivingInventoryStatusId { get; private set; }
        public VocabularyKey ReceivingWarehouseLocationId { get; private set; }
        public VocabularyKey ReceivingLicensePlateNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey IsItemMovedToDefaultItemPickingWarehouseLocation { get; private set; }
        public VocabularyKey IsQuarantineOrderCreatedForReceivedItem { get; private set; }
        public VocabularyKey TransactionReferenceType { get; private set; }
        public VocabularyKey TransactionReferenceNumber { get; private set; }
        public VocabularyKey ReferenceInventoryLotId { get; private set; }
        public VocabularyKey IsReturnOrder { get; private set; }
        public VocabularyKey ItemCatchWeightQuantity { get; private set; }
        public VocabularyKey ItemQuantity { get; private set; }
        public VocabularyKey ReturnDispositionCodeId { get; private set; }
        public VocabularyKey ReturnItemNumber { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }


    }
}