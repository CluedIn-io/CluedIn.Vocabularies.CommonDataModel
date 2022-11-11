using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductStyleGroupLineTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductStyleGroupLineTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductStyleGroupLineTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductstylegrouplinetranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductStyleGroupLineTranslationEntity";

            AddGroup("EcoResProductStyleGroupLineTranslationEntity Details", group =>
            {
                ProductStyleGroupId = group.Add(new VocabularyKey(nameof(ProductStyleGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedStyleName = group.Add(new VocabularyKey(nameof(TranslatedStyleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedStyleDescription = group.Add(new VocabularyKey(nameof(TranslatedStyleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductStyleGroupId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey TranslatedStyleName { get; private set; }
        public VocabularyKey TranslatedStyleDescription { get; private set; }
        public VocabularyKey LanguageId { get; private set; }


    }
}