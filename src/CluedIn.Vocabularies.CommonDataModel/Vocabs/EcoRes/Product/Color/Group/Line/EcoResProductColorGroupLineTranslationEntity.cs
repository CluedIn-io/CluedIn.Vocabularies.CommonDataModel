using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductColorGroupLineTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductColorGroupLineTranslationEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Color Group Line Translation Entity";
            KeyPrefix = "commonDataModel.ecoresproductcolorgrouplinetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductColorGroupLineTranslationEntity";

            AddGroup("EcoResProductColorGroupLineTranslationEntity Details", group =>
            {
                ProductColorGroupId = group.Add(new VocabularyKey(nameof(ProductColorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedColorName = group.Add(new VocabularyKey(nameof(TranslatedColorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedColorDescription = group.Add(new VocabularyKey(nameof(TranslatedColorDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductColorGroupId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey TranslatedColorName { get; private set; }
        public VocabularyKey TranslatedColorDescription { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
    }
}