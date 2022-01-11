using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressCountryRegionTranslationEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressCountryRegionTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressCountryRegionTranslationEntity";
            KeyPrefix = "commonDataModel.logisticsaddresscountryregiontranslationentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressCountryRegionTranslationEntity";

            AddGroup("Common Data Model LogisticsAddressCountryRegionTranslationEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LongName = group.Add(new VocabularyKey(nameof(LongName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey LongName { get; private set; }
public VocabularyKey ShortName { get; private set; }


    }
}