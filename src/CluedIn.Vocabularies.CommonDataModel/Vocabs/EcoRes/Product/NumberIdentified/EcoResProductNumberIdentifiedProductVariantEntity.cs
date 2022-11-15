using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductNumberIdentifiedProductVariantEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductNumberIdentifiedProductVariantEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Number Identified Product Variant Entity";
            KeyPrefix = "commonDataModel.ecoresproductnumberidentifiedproductvariantentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductNumberIdentifiedProductVariantEntity";

            AddGroup("EcoResProductNumberIdentifiedProductVariantEntity Details", group =>
            {
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
                InternalConfigurationId = group.Add(new VocabularyKey(nameof(InternalConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalSizeId = group.Add(new VocabularyKey(nameof(InternalSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalColorId = group.Add(new VocabularyKey(nameof(InternalColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalStyleId = group.Add(new VocabularyKey(nameof(InternalStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalVersionId = group.Add(new VocabularyKey(nameof(InternalVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationProductDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(ConfigurationProductDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SizeProductDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(SizeProductDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColorProductDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(ColorProductDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StyleProductDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(StyleProductDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionProductDimensionAttributeRecId = group.Add(new VocabularyKey(nameof(VersionProductDimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
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
        public VocabularyKey InternalConfigurationId { get; private set; }
        public VocabularyKey InternalSizeId { get; private set; }
        public VocabularyKey InternalColorId { get; private set; }
        public VocabularyKey InternalStyleId { get; private set; }
        public VocabularyKey InternalVersionId { get; private set; }
        public VocabularyKey ConfigurationProductDimensionAttributeRecId { get; private set; }
        public VocabularyKey SizeProductDimensionAttributeRecId { get; private set; }
        public VocabularyKey ColorProductDimensionAttributeRecId { get; private set; }
        public VocabularyKey StyleProductDimensionAttributeRecId { get; private set; }
        public VocabularyKey VersionProductDimensionAttributeRecId { get; private set; }
    }
}