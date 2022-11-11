using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialAllocationLineV2EntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialAllocationLineV2EntityVocabulary()
        {
            VocabularyName = "InventPackingMaterialAllocationLineV2Entity";
            KeyPrefix = "commonDataModel.inventpackingmaterialallocationlinev2entity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialAllocationLineV2Entity";

            AddGroup("InventPackingMaterialAllocationLineV2Entity Details", group =>
            {
                PackingUnitRecID = group.Add(new VocabularyKey(nameof(PackingUnitRecID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingUnitWeight = group.Add(new VocabularyKey(nameof(PackingUnitWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingMaterialCode = group.Add(new VocabularyKey(nameof(PackingMaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingMaterialGroupId = group.Add(new VocabularyKey(nameof(PackingMaterialGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingUnitSymbol = group.Add(new VocabularyKey(nameof(PackingUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PackingUnitRecID { get; private set; }
        public VocabularyKey PackingUnitWeight { get; private set; }
        public VocabularyKey PackingMaterialCode { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey PackingMaterialGroupId { get; private set; }
        public VocabularyKey PackingUnitSymbol { get; private set; }


    }
}