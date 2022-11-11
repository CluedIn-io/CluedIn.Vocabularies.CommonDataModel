using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLocatedWarehouseSlottingDemandV2EntityVocabulary : SimpleVocabulary
    {
        public WHSLocatedWarehouseSlottingDemandV2EntityVocabulary()
        {
            VocabularyName = "WHSLocatedWarehouseSlottingDemandV2Entity";
            KeyPrefix = "commonDataModel.whslocatedwarehouseslottingdemandv2entity";
            KeySeparator = ".";
            Grouping = "/WHSLocatedWarehouseSlottingDemandV2Entity";

            AddGroup("WHSLocatedWarehouseSlottingDemandV2Entity Details", group =>
            {
                WillDemandCreateLetUpWork = group.Add(new VocabularyKey(nameof(WillDemandCreateLetUpWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDemandUseOverflowLocation = group.Add(new VocabularyKey(nameof(WillDemandUseOverflowLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotTemplateLine = group.Add(new VocabularyKey(nameof(SlotTemplateLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotTemplate = group.Add(new VocabularyKey(nameof(SlotTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocatedUnitSymbol = group.Add(new VocabularyKey(nameof(LocatedUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocatedQuantity = group.Add(new VocabularyKey(nameof(LocatedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseSlottingTemplateDetailsSequenceNumber = group.Add(new VocabularyKey(nameof(WarehouseSlottingTemplateDetailsSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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

            });
        }

        public VocabularyKey WillDemandCreateLetUpWork { get; private set; }
        public VocabularyKey WillDemandUseOverflowLocation { get; private set; }
        public VocabularyKey SlotTemplateLine { get; private set; }
        public VocabularyKey SlotTemplate { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LocatedUnitSymbol { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }
        public VocabularyKey LocatedQuantity { get; private set; }
        public VocabularyKey WarehouseSlottingTemplateDetailsSequenceNumber { get; private set; }
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


    }
}