using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdCountryRegionToRemittanceEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdCountryRegionToRemittanceEntityVocabulary()
        {
            VocabularyName = "TaxWithholdCountryRegionToRemittanceEntity";
            KeyPrefix = "commonDataModel.taxwithholdcountryregiontoremittanceentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdCountryRegionToRemittanceEntity";

            AddGroup("TaxWithholdCountryRegionToRemittanceEntity Details", group =>
            {
                CountryCode = group.Add(new VocabularyKey(nameof(CountryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionCode = group.Add(new VocabularyKey(nameof(CountryRegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionName = group.Add(new VocabularyKey(nameof(CountryRegionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryCode { get; private set; }
        public VocabularyKey CountryRegionCode { get; private set; }
        public VocabularyKey CountryRegionName { get; private set; }


    }
}