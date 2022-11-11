using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryTransferJournalEntryCDSEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryTransferJournalEntryCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryTransferJournalEntryCDSEntity";
            KeyPrefix = "commonDataModel.inventinventorytransferjournalentrycdsentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryTransferJournalEntryCDSEntity";

            AddGroup("Common Data Model InventInventoryTransferJournalEntryCDSEntity Details", group =>
            {
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryQuantity = group.Add(new VocabularyKey(nameof(InventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceInventorySiteId = group.Add(new VocabularyKey(nameof(SourceInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceWarehouseId = group.Add(new VocabularyKey(nameof(SourceWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProductSizeId = group.Add(new VocabularyKey(nameof(SourceProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProductStyleId = group.Add(new VocabularyKey(nameof(SourceProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProductVersionId = group.Add(new VocabularyKey(nameof(SourceProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProductColorId = group.Add(new VocabularyKey(nameof(SourceProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProductConfigurationId = group.Add(new VocabularyKey(nameof(SourceProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationWarehouseId = group.Add(new VocabularyKey(nameof(DestinationWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationInventorySiteId = group.Add(new VocabularyKey(nameof(DestinationInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationProductStyleId = group.Add(new VocabularyKey(nameof(DestinationProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationProductVersionId = group.Add(new VocabularyKey(nameof(DestinationProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationProductSizeId = group.Add(new VocabularyKey(nameof(DestinationProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationProductColorId = group.Add(new VocabularyKey(nameof(DestinationProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationProductConfigurationId = group.Add(new VocabularyKey(nameof(DestinationProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey InventoryQuantity { get; private set; }
        public VocabularyKey SourceInventorySiteId { get; private set; }
        public VocabularyKey SourceWarehouseId { get; private set; }
        public VocabularyKey SourceProductSizeId { get; private set; }
        public VocabularyKey SourceProductStyleId { get; private set; }
        public VocabularyKey SourceProductVersionId { get; private set; }
        public VocabularyKey SourceProductColorId { get; private set; }
        public VocabularyKey SourceProductConfigurationId { get; private set; }
        public VocabularyKey DestinationWarehouseId { get; private set; }
        public VocabularyKey DestinationInventorySiteId { get; private set; }
        public VocabularyKey DestinationProductStyleId { get; private set; }
        public VocabularyKey DestinationProductVersionId { get; private set; }
        public VocabularyKey DestinationProductSizeId { get; private set; }
        public VocabularyKey DestinationProductColorId { get; private set; }
        public VocabularyKey DestinationProductConfigurationId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }


    }
}