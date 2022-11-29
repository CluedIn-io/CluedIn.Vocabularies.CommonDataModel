using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class LimitVocabulary : SimpleVocabulary
    {
        public LimitVocabulary()
        {
            VocabularyName = "Limit";
            KeyPrefix = "commonDataModel.limit.banking";
            KeySeparator = ".";
            Grouping = "/Limit";

            AddGroup("Limit Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AvailableLimit = group.Add(new VocabularyKey(nameof(AvailableLimit), "Available Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AvailableLimitBase = group.Add(new VocabularyKey(nameof(AvailableLimitBase), "Available Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimit = group.Add(new VocabularyKey(nameof(ImplementedLimit), "Implemented Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimitBase = group.Add(new VocabularyKey(nameof(ImplementedLimitBase), "Implemented Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LimitExpiry = group.Add(new VocabularyKey(nameof(LimitExpiry), "Limit Expiry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitId = group.Add(new VocabularyKey(nameof(LimitId), "Limit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitName = group.Add(new VocabularyKey(nameof(LimitName), "Limit Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitType = group.Add(new VocabularyKey(nameof(LimitType), "Limit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimit = group.Add(new VocabularyKey(nameof(UtilizedLimit), "Utilized Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimitBase = group.Add(new VocabularyKey(nameof(UtilizedLimitBase), "Utilized Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AvailableLimit { get; private set; }
        public VocabularyKey AvailableLimitBase { get; private set; }
        public VocabularyKey ImplementedLimit { get; private set; }
        public VocabularyKey ImplementedLimitBase { get; private set; }
        public VocabularyKey LimitExpiry { get; private set; }
        public VocabularyKey LimitId { get; private set; }
        public VocabularyKey LimitName { get; private set; }
        public VocabularyKey LimitType { get; private set; }
        public VocabularyKey UtilizedLimit { get; private set; }
        public VocabularyKey UtilizedLimitBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}