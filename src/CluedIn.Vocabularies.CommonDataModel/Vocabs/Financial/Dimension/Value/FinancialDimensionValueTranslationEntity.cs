using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialDimensionValueTranslationEntityVocabulary : SimpleVocabulary
    {
        public FinancialDimensionValueTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model FinancialDimensionValueTranslationEntity";
            KeyPrefix = "commonDataModel.financialdimensionvaluetranslationentity";
            KeySeparator = ".";
            Grouping = "/FinancialDimensionValueTranslationEntity";

            AddGroup("Common Data Model FinancialDimensionValueTranslationEntity Details", group =>
            {
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FinancialDimensionValue = group.Add(new VocabularyKey(nameof(FinancialDimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedDescription = group.Add(new VocabularyKey(nameof(TranslatedDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionFinancialTag = group.Add(new VocabularyKey(nameof(DimensionFinancialTag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FinancialDimension { get; private set; }
public VocabularyKey FinancialDimensionValue { get; private set; }
public VocabularyKey LanguageCode { get; private set; }
public VocabularyKey TranslatedDescription { get; private set; }
public VocabularyKey DimensionFinancialTag { get; private set; }


    }
}