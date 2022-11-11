using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingJournalLineEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryCountingJournalLineEntity";
            KeyPrefix = "commonDataModel.inventinventorycountingjournallineentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingJournalLineEntity";

            AddGroup("Common Data Model InventInventoryCountingJournalLineEntity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingDate = group.Add(new VocabularyKey(nameof(CountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatusId = group.Add(new VocabularyKey(nameof(InventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicensePlateNumber = group.Add(new VocabularyKey(nameof(LicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(CountedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountedQuantity = group.Add(new VocabularyKey(nameof(CountedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandCatchWeightQuantity = group.Add(new VocabularyKey(nameof(OnHandCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandQuantity = group.Add(new VocabularyKey(nameof(OnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentCatchWeightQuantity = group.Add(new VocabularyKey(nameof(AdjustmentCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentQuantity = group.Add(new VocabularyKey(nameof(AdjustmentQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightUnitSymbol = group.Add(new VocabularyKey(nameof(CatchWeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountedQuantityZero = group.Add(new VocabularyKey(nameof(IsCountedQuantityZero), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingReasonCode = group.Add(new VocabularyKey(nameof(CountingReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CountingDate { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey InventoryStatusId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey LicensePlateNumber { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey CountedCatchWeightQuantity { get; private set; }
        public VocabularyKey CountedQuantity { get; private set; }
        public VocabularyKey OnHandCatchWeightQuantity { get; private set; }
        public VocabularyKey OnHandQuantity { get; private set; }
        public VocabularyKey AdjustmentCatchWeightQuantity { get; private set; }
        public VocabularyKey AdjustmentQuantity { get; private set; }
        public VocabularyKey CatchWeightUnitSymbol { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey IsCountedQuantityZero { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey CountingReasonCode { get; private set; }


    }
}