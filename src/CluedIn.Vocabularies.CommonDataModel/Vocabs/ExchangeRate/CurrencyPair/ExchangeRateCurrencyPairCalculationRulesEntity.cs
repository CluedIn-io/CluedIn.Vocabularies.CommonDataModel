using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateCurrencyPairCalculationRulesEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateCurrencyPairCalculationRulesEntityVocabulary()
        {
            VocabularyName = "ExchangeRateCurrencyPairCalculationRulesEntity";
            KeyPrefix = "commonDataModel.exchangeratecurrencypaircalculationrulesentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateCurrencyPairCalculationRulesEntity";

            AddGroup("ExchangeRateCurrencyPairCalculationRulesEntity Details", group =>
            {
                ValidForExchangeRateType = group.Add(new VocabularyKey(nameof(ValidForExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(ExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidForCompany = group.Add(new VocabularyKey(nameof(ValidForCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromCurrency = group.Add(new VocabularyKey(nameof(FromCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToCurrency = group.Add(new VocabularyKey(nameof(ToCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TriangulationCurrency = group.Add(new VocabularyKey(nameof(TriangulationCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidForExchangeRateType { get; private set; }
        public VocabularyKey ExchangeRateTypeRecId { get; private set; }
        public VocabularyKey ExchangeRateType { get; private set; }
        public VocabularyKey ValidForCompany { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey FromCurrency { get; private set; }
        public VocabularyKey ToCurrency { get; private set; }
        public VocabularyKey TriangulationCurrency { get; private set; }


    }
}