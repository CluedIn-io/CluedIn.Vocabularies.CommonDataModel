using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UnitOfMeasureTranslationEntityVocabulary : SimpleVocabulary
    {
        public UnitOfMeasureTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model UnitOfMeasureTranslationEntity";
            KeyPrefix = "commonDataModel.unitofmeasuretranslationentity";
            KeySeparator = ".";
            Grouping = "/UnitOfMeasureTranslationEntity";

            AddGroup("Common Data Model UnitOfMeasureTranslationEntity Details", group =>
            {
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedDescription = group.Add(new VocabularyKey(nameof(TranslatedDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedDescription { get; private set; }


    }
}