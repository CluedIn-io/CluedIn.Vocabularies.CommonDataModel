using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFixedProductWarehouseLocationV2EntityVocabulary : SimpleVocabulary
    {
        public WHSFixedProductWarehouseLocationV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSFixedProductWarehouseLocationV2Entity";
            KeyPrefix = "commonDataModel.whsfixedproductwarehouselocationv2entity";
            KeySeparator = ".";
            Grouping = "/WHSFixedProductWarehouseLocationV2Entity";

            AddGroup("Common Data Model WHSFixedProductWarehouseLocationV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalConfigurationId = group.Add(new VocabularyKey(nameof(InternalConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalSizeId = group.Add(new VocabularyKey(nameof(InternalSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalColorId = group.Add(new VocabularyKey(nameof(InternalColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalStyleId = group.Add(new VocabularyKey(nameof(InternalStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalVersionId = group.Add(new VocabularyKey(nameof(InternalVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationId = group.Add(new VocabularyKey(nameof(WarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey InternalConfigurationId { get; private set; }
        public VocabularyKey InternalSizeId { get; private set; }
        public VocabularyKey InternalColorId { get; private set; }
        public VocabularyKey InternalStyleId { get; private set; }
        public VocabularyKey InternalVersionId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey WarehouseLocationId { get; private set; }


    }
}