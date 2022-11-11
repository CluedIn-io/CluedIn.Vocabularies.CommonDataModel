using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseSlottingDemandV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseSlottingDemandV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseSlottingDemandV2Entity";
            KeyPrefix = "commonDataModel.whswarehouseslottingdemandv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseSlottingDemandV2Entity";

            AddGroup("Common Data Model WHSWarehouseSlottingDemandV2Entity Details", group =>
            {
                SlotTemplate = group.Add(new VocabularyKey(nameof(SlotTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandUnitSymbol = group.Add(new VocabularyKey(nameof(DemandUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandQuantity = group.Add(new VocabularyKey(nameof(DemandQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseSlottingTemplateId = group.Add(new VocabularyKey(nameof(WarehouseSlottingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchNumber = group.Add(new VocabularyKey(nameof(ItemBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSerialNumber = group.Add(new VocabularyKey(nameof(ItemSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandSiteId = group.Add(new VocabularyKey(nameof(DemandSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryStatus = group.Add(new VocabularyKey(nameof(InventoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SlotTemplate { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey DemandUnitSymbol { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey DemandQuantity { get; private set; }
        public VocabularyKey WarehouseSlottingTemplateId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemBatchNumber { get; private set; }
        public VocabularyKey ItemSerialNumber { get; private set; }
        public VocabularyKey DemandSiteId { get; private set; }
        public VocabularyKey InventoryStatus { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }


    }
}