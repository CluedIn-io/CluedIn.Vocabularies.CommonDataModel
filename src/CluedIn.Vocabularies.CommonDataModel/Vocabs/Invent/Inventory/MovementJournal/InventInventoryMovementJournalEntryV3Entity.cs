using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryMovementJournalEntryV3EntityVocabulary : SimpleVocabulary
    {
        public InventInventoryMovementJournalEntryV3EntityVocabulary()
        {
            VocabularyName = "Invent Inventory Movement Journal Entry V3 Entity";
            KeyPrefix = "commonDataModel.inventinventorymovementjournalentryv3entity";
            KeySeparator = ".";
            Grouping = "/InventInventoryMovementJournalEntryV3Entity";

            AddGroup("InventInventoryMovementJournalEntryV3Entity Details", group =>
            {
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedCostCharges = group.Add(new VocabularyKey(nameof(FixedCostCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetMainAccountId = group.Add(new VocabularyKey(nameof(OffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightQuantity = group.Add(new VocabularyKey(nameof(CatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCostQuantity = group.Add(new VocabularyKey(nameof(UnitCostQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryQuantity = group.Add(new VocabularyKey(nameof(InventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(OffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalHeaderVoucherDraw = group.Add(new VocabularyKey(nameof(JournalHeaderVoucherDraw), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalHeaderOffsetMainAccountId = group.Add(new VocabularyKey(nameof(JournalHeaderOffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalHeaderJournalType = group.Add(new VocabularyKey(nameof(JournalHeaderJournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalHeaderWorker = group.Add(new VocabularyKey(nameof(JournalHeaderWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryGtdId = group.Add(new VocabularyKey(nameof(InventoryGtdId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey FixedCostCharges { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey OffsetMainAccountId { get; private set; }
        public VocabularyKey CatchWeightQuantity { get; private set; }
        public VocabularyKey UnitCostQuantity { get; private set; }
        public VocabularyKey InventoryQuantity { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey OffsetMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey InventoryWarehouseId { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey JournalHeaderVoucherDraw { get; private set; }
        public VocabularyKey JournalHeaderOffsetMainAccountId { get; private set; }
        public VocabularyKey JournalHeaderJournalType { get; private set; }
        public VocabularyKey JournalHeaderWorker { get; private set; }
        public VocabularyKey InventoryGtdId { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey InventoryProfileId { get; private set; }
    }
}