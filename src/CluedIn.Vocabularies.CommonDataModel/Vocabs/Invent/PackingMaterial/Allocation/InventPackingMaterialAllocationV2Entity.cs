using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialAllocationV2EntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialAllocationV2EntityVocabulary()
        {
            VocabularyName = "InventPackingMaterialAllocationV2Entity";
            KeyPrefix = "commonDataModel.inventpackingmaterialallocationv2entity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialAllocationV2Entity";

            AddGroup("InventPackingMaterialAllocationV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingMaterialGroupId = group.Add(new VocabularyKey(nameof(PackingMaterialGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitConversionFactor = group.Add(new VocabularyKey(nameof(InventoryUnitConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingUnitSymbol = group.Add(new VocabularyKey(nameof(PackingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey PackingMaterialGroupId { get; private set; }
        public VocabularyKey InventoryUnitConversionFactor { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey PackingUnitSymbol { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }


    }
}