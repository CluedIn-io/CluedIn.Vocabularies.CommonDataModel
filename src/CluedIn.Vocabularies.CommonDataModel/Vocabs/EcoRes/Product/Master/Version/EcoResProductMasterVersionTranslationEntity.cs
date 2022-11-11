using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterVersionTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterVersionTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductMasterVersionTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterversiontranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterVersionTranslationEntity";

            AddGroup("EcoResProductMasterVersionTranslationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterVersionId = group.Add(new VocabularyKey(nameof(ProductMasterVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedVersionName = group.Add(new VocabularyKey(nameof(TranslatedVersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedVersionDescription = group.Add(new VocabularyKey(nameof(TranslatedVersionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductMasterVersionId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedVersionName { get; private set; }
        public VocabularyKey TranslatedVersionDescription { get; private set; }


    }
}