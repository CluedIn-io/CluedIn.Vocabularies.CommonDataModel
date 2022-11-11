using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResReleasedProductVariantExternalCodeV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResReleasedProductVariantExternalCodeV2EntityVocabulary()
        {
            VocabularyName = "EcoResReleasedProductVariantExternalCodeV2Entity";
            KeyPrefix = "commonDataModel.ecoresreleasedproductvariantexternalcodev2entity";
            KeySeparator = ".";
            Grouping = "/EcoResReleasedProductVariantExternalCodeV2Entity";

            AddGroup("EcoResReleasedProductVariantExternalCodeV2Entity Details", group =>
            {
                ReleasedProductVariantExternalCodeClassId = group.Add(new VocabularyKey(nameof(ReleasedProductVariantExternalCodeClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeRelationTableId = group.Add(new VocabularyKey(nameof(ExtCodeRelationTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtCodeTableTableId = group.Add(new VocabularyKey(nameof(ExtCodeTableTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReleasedProductVariantExternalCodeClassId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey ExtCodeRelationTableId { get; private set; }
        public VocabularyKey ExtCodeTableTableId { get; private set; }


    }
}