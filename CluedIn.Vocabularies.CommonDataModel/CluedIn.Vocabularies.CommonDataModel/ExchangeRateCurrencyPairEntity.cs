using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateCurrencyPairEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateCurrencyPairEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExchangeRateCurrencyPairEntity";
            KeyPrefix = "commonDataModel.exchangeratecurrencypairentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateCurrencyPairEntity";

            AddGroup("Common Data Model ExchangeRateCurrencyPairEntity Details", group =>
            {
                ExchangeRateDisplayFactor = group.Add(new VocabularyKey(nameof(ExchangeRateDisplayFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromCurrencyCode = group.Add(new VocabularyKey(nameof(FromCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToCurrencyCode = group.Add(new VocabularyKey(nameof(ToCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateTypeName = group.Add(new VocabularyKey(nameof(ExchangeRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExchangeRateDisplayFactor { get; private set; }
public VocabularyKey ExchangeRateType { get; private set; }
public VocabularyKey FromCurrencyCode { get; private set; }
public VocabularyKey ToCurrencyCode { get; private set; }
public VocabularyKey ExchangeRateTypeName { get; private set; }


    }
}