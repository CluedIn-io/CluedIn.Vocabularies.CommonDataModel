using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCountryRegionParametersEntityVocabulary : SimpleVocabulary
    {
        public TaxCountryRegionParametersEntityVocabulary()
        {
            VocabularyName = "TaxCountryRegionParametersEntity";
            KeyPrefix = "commonDataModel.taxcountryregionparametersentity";
            KeySeparator = ".";
            Grouping = "/TaxCountryRegionParametersEntity";

            AddGroup("TaxCountryRegionParametersEntity Details", group =>
            {
                CheckTaxExemptNumber = group.Add(new VocabularyKey(nameof(CheckTaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CheckTaxExemptNumber { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }


    }
}