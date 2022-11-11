using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CurrencyISOCodeEntityVocabulary : SimpleVocabulary
    {
        public CurrencyISOCodeEntityVocabulary()
        {
            VocabularyName = "CurrencyISOCodeEntity";
            KeyPrefix = "commonDataModel.currencyisocodeentity";
            KeySeparator = ".";
            Grouping = "/CurrencyISOCodeEntity";

            AddGroup("CurrencyISOCodeEntity Details", group =>
            {
                ISOCurrencyCode = group.Add(new VocabularyKey(nameof(ISOCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ISOCurrencyCodeNum = group.Add(new VocabularyKey(nameof(ISOCurrencyCodeNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ISOCurrencyName = group.Add(new VocabularyKey(nameof(ISOCurrencyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ISOCurrencyCode { get; private set; }
        public VocabularyKey ISOCurrencyCodeNum { get; private set; }
        public VocabularyKey ISOCurrencyName { get; private set; }


    }
}