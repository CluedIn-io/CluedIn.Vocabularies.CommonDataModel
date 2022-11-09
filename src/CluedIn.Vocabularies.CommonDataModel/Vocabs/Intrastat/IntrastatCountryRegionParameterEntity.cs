using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatCountryRegionParameterEntityVocabulary : SimpleVocabulary
    {
        public IntrastatCountryRegionParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatCountryRegionParameterEntity";
            KeyPrefix = "commonDataModel.intrastatcountryregionparameterentity";
            KeySeparator = ".";
            Grouping = "/IntrastatCountryRegionParameterEntity";

            AddGroup("Common Data Model IntrastatCountryRegionParameterEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionType = group.Add(new VocabularyKey(nameof(CountryRegionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCode = group.Add(new VocabularyKey(nameof(IntrastatCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BlackListedCountry = group.Add(new VocabularyKey(nameof(BlackListedCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryThreeDigitCode = group.Add(new VocabularyKey(nameof(CountryThreeDigitCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey CountryRegionType { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey IntrastatCode { get; private set; }
public VocabularyKey BlackListedCountry { get; private set; }
public VocabularyKey CountryThreeDigitCode { get; private set; }


    }
}