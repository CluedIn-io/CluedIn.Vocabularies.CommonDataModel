using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductVariantNomenclatureEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductVariantNomenclatureEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductVariantNomenclatureEntity";
            KeyPrefix = "commonDataModel.ecoresproductvariantnomenclatureentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductVariantNomenclatureEntity";

            AddGroup("Common Data Model EcoResProductVariantNomenclatureEntity Details", group =>
            {
                NomenclatureName = group.Add(new VocabularyKey(nameof(NomenclatureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NomenclatureDescription = group.Add(new VocabularyKey(nameof(NomenclatureDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey NomenclatureName { get; private set; }
        public VocabularyKey NomenclatureDescription { get; private set; }


    }
}