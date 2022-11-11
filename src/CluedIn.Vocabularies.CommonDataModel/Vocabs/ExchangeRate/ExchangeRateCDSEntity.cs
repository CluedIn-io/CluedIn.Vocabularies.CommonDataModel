using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateCDSEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExchangeRateCDSEntity";
            KeyPrefix = "commonDataModel.exchangeratecdsentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateCDSEntity";

            AddGroup("Common Data Model ExchangeRateCDSEntity Details", group =>
            {
                ExchangeRateForStorage = group.Add(new VocabularyKey(nameof(ExchangeRateForStorage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateCurrencyPairId = group.Add(new VocabularyKey(nameof(ExchangeRateCurrencyPairId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateTypeId = group.Add(new VocabularyKey(nameof(ExchangeRateTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromCurrencyCode = group.Add(new VocabularyKey(nameof(FromCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToCurrencyCode = group.Add(new VocabularyKey(nameof(ToCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateTypeName = group.Add(new VocabularyKey(nameof(ExchangeRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExchangeRateForStorage { get; private set; }
        public VocabularyKey ExchangeRateCurrencyPairId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ExchangeRateTypeId { get; private set; }
        public VocabularyKey FromCurrencyCode { get; private set; }
        public VocabularyKey ToCurrencyCode { get; private set; }
        public VocabularyKey ExchangeRateTypeName { get; private set; }
        public VocabularyKey Rate { get; private set; }


    }
}