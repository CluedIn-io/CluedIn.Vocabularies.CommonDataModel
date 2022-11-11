using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSizeGroupLineEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSizeGroupLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductSizeGroupLineEntity";
            KeyPrefix = "commonDataModel.ecoresproductsizegrouplineentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSizeGroupLineEntity";

            AddGroup("Common Data Model EcoResProductSizeGroupLineEntity Details", group =>
            {
                ProductSizeGroupId = group.Add(new VocabularyKey(nameof(ProductSizeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SizeName = group.Add(new VocabularyKey(nameof(SizeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SizeDescription = group.Add(new VocabularyKey(nameof(SizeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeNumber = group.Add(new VocabularyKey(nameof(BarcodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductSizeGroupId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey SizeName { get; private set; }
        public VocabularyKey SizeDescription { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey BarcodeNumber { get; private set; }
        public VocabularyKey ReplenishmentWeight { get; private set; }


    }
}