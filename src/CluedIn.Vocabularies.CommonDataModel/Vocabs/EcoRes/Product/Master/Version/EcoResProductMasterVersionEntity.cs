using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterVersionEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterVersionEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductMasterVersionEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterversionentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterVersionEntity";

            AddGroup("Common Data Model EcoResProductMasterVersionEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplaySequenceNumber = group.Add(new VocabularyKey(nameof(DisplaySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ReplenishmentWeight { get; private set; }
        public VocabularyKey DisplaySequenceNumber { get; private set; }


    }
}