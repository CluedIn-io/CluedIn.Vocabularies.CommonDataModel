using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedProductVariantV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedProductVariantV2EntityVocabulary()
        {
            VocabularyName = "Eco Res Released Product Variant V2 Entity";
            KeyPrefix = "commonDataModel.ecoresreleasedproductvariantv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedProductVariantV2Entity";

            AddGroup("EcoResReleasedProductVariantV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantNumber = group.Add(new VocabularyKey(nameof(ProductVariantNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductLifecycleStateId = group.Add(new VocabularyKey(nameof(ProductLifecycleStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductVariantNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductLifecycleStateId { get; private set; }
    }
}