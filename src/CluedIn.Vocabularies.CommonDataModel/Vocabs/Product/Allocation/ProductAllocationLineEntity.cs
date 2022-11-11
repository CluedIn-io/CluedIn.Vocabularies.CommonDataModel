using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductAllocationLineEntityVocabulary : SimpleVocabulary
    {
        public ProductAllocationLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductAllocationLineEntity";
            KeyPrefix = "commonDataModel.productallocationlineentity";
            KeySeparator = ".";
            Grouping = "/ProductAllocationLineEntity";

            AddGroup("Common Data Model ProductAllocationLineEntity Details", group =>
            {
                ProductAllocationKeyId = group.Add(new VocabularyKey(nameof(ProductAllocationKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAllocationPercentage = group.Add(new VocabularyKey(nameof(ProductAllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductAllocationKeyId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProductAllocationPercentage { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }


    }
}