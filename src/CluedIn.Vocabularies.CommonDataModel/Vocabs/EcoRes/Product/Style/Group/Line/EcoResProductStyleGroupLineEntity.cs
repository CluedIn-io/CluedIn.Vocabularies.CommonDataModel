using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductStyleGroupLineEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductStyleGroupLineEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Style Group Line Entity";
            KeyPrefix = "commonDataModel.ecoresproductstylegrouplineentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductStyleGroupLineEntity";

            AddGroup("EcoResProductStyleGroupLineEntity Details", group =>
            {
                ProductStyleGroupId = group.Add(new VocabularyKey(nameof(ProductStyleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StyleName = group.Add(new VocabularyKey(nameof(StyleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StyleDescription = group.Add(new VocabularyKey(nameof(StyleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeNumber = group.Add(new VocabularyKey(nameof(BarcodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductStyleGroupId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey StyleName { get; private set; }
        public VocabularyKey StyleDescription { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey BarcodeNumber { get; private set; }
        public VocabularyKey ReplenishmentWeight { get; private set; }
    }
}