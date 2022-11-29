using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class TradeInVocabulary : SimpleVocabulary
    {
        public TradeInVocabulary()
        {
            VocabularyName = "Trade In";
            KeyPrefix = "commonDataModel.tradein.automotive";
            KeySeparator = ".";
            Grouping = "/TradeIn";

            AddGroup("TradeIn Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AppraisalSource = group.Add(new VocabularyKey(nameof(AppraisalSource), "Appraisal Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AppraisedValue = group.Add(new VocabularyKey(nameof(AppraisedValue), "Appraised Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AppraisedValueBase = group.Add(new VocabularyKey(nameof(AppraisedValueBase), "Appraised Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfferPrice = group.Add(new VocabularyKey(nameof(OfferPrice), "Offer Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OfferPriceBase = group.Add(new VocabularyKey(nameof(OfferPriceBase), "Offer Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TradeInId = group.Add(new VocabularyKey(nameof(TradeInId), "Trade In", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AppraisalSource { get; private set; }
        public VocabularyKey AppraisedValue { get; private set; }
        public VocabularyKey AppraisedValueBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfferPrice { get; private set; }
        public VocabularyKey OfferPriceBase { get; private set; }
        public VocabularyKey TradeInId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}