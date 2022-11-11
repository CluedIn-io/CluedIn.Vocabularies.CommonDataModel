using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateEntityVocabulary()
        {
            VocabularyName = "ExchangeRateEntity";
            KeyPrefix = "commonDataModel.exchangerateentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateEntity";

            AddGroup("ExchangeRateEntity Details", group =>
            {
                ExchangeRateForStorage = group.Add(new VocabularyKey(nameof(ExchangeRateForStorage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateCurrencyPair = group.Add(new VocabularyKey(nameof(ExchangeRateCurrencyPair), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConversionFactor = group.Add(new VocabularyKey(nameof(ConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromCurrency = group.Add(new VocabularyKey(nameof(FromCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToCurrency = group.Add(new VocabularyKey(nameof(ToCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateTypeDescription = group.Add(new VocabularyKey(nameof(RateTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateTypeName = group.Add(new VocabularyKey(nameof(RateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExchangeRateForStorage { get; private set; }
        public VocabularyKey ExchangeRateCurrencyPair { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ConversionFactor { get; private set; }
        public VocabularyKey ExchangeRateType { get; private set; }
        public VocabularyKey FromCurrency { get; private set; }
        public VocabularyKey ToCurrency { get; private set; }
        public VocabularyKey RateTypeDescription { get; private set; }
        public VocabularyKey RateTypeName { get; private set; }
        public VocabularyKey Rate { get; private set; }


    }
}