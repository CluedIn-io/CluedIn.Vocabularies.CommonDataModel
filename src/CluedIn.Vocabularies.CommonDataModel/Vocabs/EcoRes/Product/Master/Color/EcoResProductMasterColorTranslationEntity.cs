using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterColorTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterColorTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductMasterColorTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmastercolortranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterColorTranslationEntity";

            AddGroup("EcoResProductMasterColorTranslationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterColorId = group.Add(new VocabularyKey(nameof(ProductMasterColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedColorName = group.Add(new VocabularyKey(nameof(TranslatedColorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedColorDescription = group.Add(new VocabularyKey(nameof(TranslatedColorDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductMasterColorId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedColorName { get; private set; }
        public VocabularyKey TranslatedColorDescription { get; private set; }


    }
}