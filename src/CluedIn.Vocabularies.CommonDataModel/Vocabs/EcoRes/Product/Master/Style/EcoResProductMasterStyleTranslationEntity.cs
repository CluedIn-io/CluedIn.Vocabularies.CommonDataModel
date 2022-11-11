using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterStyleTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterStyleTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductMasterStyleTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterstyletranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterStyleTranslationEntity";

            AddGroup("EcoResProductMasterStyleTranslationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterStyleId = group.Add(new VocabularyKey(nameof(ProductMasterStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedStyleName = group.Add(new VocabularyKey(nameof(TranslatedStyleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedStyleDescription = group.Add(new VocabularyKey(nameof(TranslatedStyleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductMasterStyleId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedStyleName { get; private set; }
        public VocabularyKey TranslatedStyleDescription { get; private set; }


    }
}