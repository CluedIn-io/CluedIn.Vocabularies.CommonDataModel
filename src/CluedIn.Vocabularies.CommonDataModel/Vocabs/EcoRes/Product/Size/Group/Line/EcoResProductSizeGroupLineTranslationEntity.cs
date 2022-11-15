using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSizeGroupLineTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSizeGroupLineTranslationEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Size Group Line Translation Entity";
            KeyPrefix = "commonDataModel.ecoresproductsizegrouplinetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSizeGroupLineTranslationEntity";

            AddGroup("EcoResProductSizeGroupLineTranslationEntity Details", group =>
            {
                ProductSizeGroupId = group.Add(new VocabularyKey(nameof(ProductSizeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedSizeName = group.Add(new VocabularyKey(nameof(TranslatedSizeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedSizeDescription = group.Add(new VocabularyKey(nameof(TranslatedSizeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductSizeGroupId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey TranslatedSizeName { get; private set; }
        public VocabularyKey TranslatedSizeDescription { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
    }
}