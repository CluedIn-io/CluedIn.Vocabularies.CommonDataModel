using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class FssForecastVocabulary : SimpleVocabulary
    {
        public FssForecastVocabulary()
        {
            VocabularyName = "Fss Forecast";
            KeyPrefix = "commonDataModel.fssforecast.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/FssForecast";

            AddGroup("FssForecast Details for NonProfitIati", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Amount_Base = group.Add(new VocabularyKey(nameof(Amount_Base), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FssForecastId = group.Add(new VocabularyKey(nameof(FssForecastId), "FSS Forecast", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Year = group.Add(new VocabularyKey(nameof(Year), "Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Amount_Base { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey FssForecastId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}