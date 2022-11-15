using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseOnHandCDSEntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseOnHandCDSEntityVocabulary()
        {
            VocabularyName = "Invent Warehouse On Hand CDS Entity";
            KeyPrefix = "commonDataModel.inventwarehouseonhandcdsentity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseOnHandCDSEntity";

            AddGroup("InventWarehouseOnHandCDSEntity Details", group =>
            {
                InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryWarehouseId = group.Add(new VocabularyKey(nameof(InventoryWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHandQuantity = group.Add(new VocabularyKey(nameof(OnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnOrderQuantity = group.Add(new VocabularyKey(nameof(OnOrderQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedQuantity = group.Add(new VocabularyKey(nameof(OrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreWarehouseManagementProcessesUsed = group.Add(new VocabularyKey(nameof(AreWarehouseManagementProcessesUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvailableOnHandQuantity = group.Add(new VocabularyKey(nameof(AvailableOnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvailableOrderedQuantity = group.Add(new VocabularyKey(nameof(AvailableOrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAvailableQuantity = group.Add(new VocabularyKey(nameof(TotalAvailableQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservedOrderedQuantity = group.Add(new VocabularyKey(nameof(ReservedOrderedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservedOnHandQuantity = group.Add(new VocabularyKey(nameof(ReservedOnHandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InventorySiteId { get; private set; }
        public VocabularyKey InventoryWarehouseId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey OnHandQuantity { get; private set; }
        public VocabularyKey OnOrderQuantity { get; private set; }
        public VocabularyKey OrderedQuantity { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey AreWarehouseManagementProcessesUsed { get; private set; }
        public VocabularyKey AvailableOnHandQuantity { get; private set; }
        public VocabularyKey AvailableOrderedQuantity { get; private set; }
        public VocabularyKey TotalAvailableQuantity { get; private set; }
        public VocabularyKey ReservedOrderedQuantity { get; private set; }
        public VocabularyKey ReservedOnHandQuantity { get; private set; }
    }
}