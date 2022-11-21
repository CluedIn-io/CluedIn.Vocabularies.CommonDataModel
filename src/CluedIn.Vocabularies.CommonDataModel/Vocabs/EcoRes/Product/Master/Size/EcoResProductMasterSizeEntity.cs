using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterSizeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterSizeEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Master Size Entity";
            KeyPrefix = "commonDataModel.ecoresproductmastersizeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterSizeEntity";

            AddGroup("EcoResProductMasterSizeEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplaySequenceNumber = group.Add(new VocabularyKey(nameof(DisplaySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ReplenishmentWeight { get; private set; }
        public VocabularyKey DisplaySequenceNumber { get; private set; }
    }
}