using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionAttributeTranslationEntityVocabulary : SimpleVocabulary
    {
        public DimensionAttributeTranslationEntityVocabulary()
        {
            VocabularyName = "DimensionAttributeTranslationEntity";
            KeyPrefix = "commonDataModel.dimensionattributetranslationentity";
            KeySeparator = ".";
            Grouping = "/DimensionAttributeTranslationEntity";

            AddGroup("DimensionAttributeTranslationEntity Details", group =>
            {
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedFinancialDimension = group.Add(new VocabularyKey(nameof(TranslatedFinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionAttribute { get; private set; }
        public VocabularyKey FinancialDimension { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey TranslatedFinancialDimension { get; private set; }


    }
}