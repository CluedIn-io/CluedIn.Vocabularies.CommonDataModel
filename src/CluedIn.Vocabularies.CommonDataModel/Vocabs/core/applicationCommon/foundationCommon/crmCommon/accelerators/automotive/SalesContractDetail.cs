using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class SalesContractDetailVocabulary : SimpleVocabulary
    {
        public SalesContractDetailVocabulary()
        {
            VocabularyName = "Sales Contract Detail";
            KeyPrefix = "commonDataModel.salescontractdetail.automotive";
            KeySeparator = ".";
            Grouping = "/SalesContractDetail";

            AddGroup("SalesContractDetail Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BuybackDate = group.Add(new VocabularyKey(nameof(BuybackDate), "Buyback Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BuybackValue = group.Add(new VocabularyKey(nameof(BuybackValue), "Buyback Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BuybackValueBase = group.Add(new VocabularyKey(nameof(BuybackValueBase), "Buyback Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesContractDetailId = group.Add(new VocabularyKey(nameof(SalesContractDetailId), "Sales Contract Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey BuybackDate { get; private set; }
        public VocabularyKey BuybackValue { get; private set; }
        public VocabularyKey BuybackValueBase { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SalesContractDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}