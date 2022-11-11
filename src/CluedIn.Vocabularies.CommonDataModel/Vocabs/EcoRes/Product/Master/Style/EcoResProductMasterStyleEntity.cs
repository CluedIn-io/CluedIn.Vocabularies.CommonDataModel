using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterStyleEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterStyleEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductMasterStyleEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterstyleentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterStyleEntity";

            AddGroup("Common Data Model EcoResProductMasterStyleEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplaySequenceNumber = group.Add(new VocabularyKey(nameof(DisplaySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ReplenishmentWeight { get; private set; }
        public VocabularyKey DisplaySequenceNumber { get; private set; }


    }
}