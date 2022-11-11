using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterSizeTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterSizeTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductMasterSizeTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmastersizetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterSizeTranslationEntity";

            AddGroup("EcoResProductMasterSizeTranslationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterSizeId = group.Add(new VocabularyKey(nameof(ProductMasterSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedSizeName = group.Add(new VocabularyKey(nameof(TranslatedSizeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedSizeDescription = group.Add(new VocabularyKey(nameof(TranslatedSizeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductMasterSizeId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedSizeName { get; private set; }
        public VocabularyKey TranslatedSizeDescription { get; private set; }


    }
}