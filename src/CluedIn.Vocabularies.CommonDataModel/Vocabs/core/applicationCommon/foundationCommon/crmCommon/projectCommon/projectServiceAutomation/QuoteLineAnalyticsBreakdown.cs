using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class QuoteLineAnalyticsBreakdownVocabulary : SimpleVocabulary
    {
        public QuoteLineAnalyticsBreakdownVocabulary()
        {
            VocabularyName = "Quote Line Analytics Breakdown";
            KeyPrefix = "commonDataModel.quotelineanalyticsbreakdown.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/QuoteLineAnalyticsBreakdown";

            AddGroup("QuoteLineAnalyticsBreakdown Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineAnalyticsBreakdownId = group.Add(new VocabularyKey(nameof(QuoteLineAnalyticsBreakdownId), "Quote Line Analytics Breakdown", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionTypeCode = group.Add(new VocabularyKey(nameof(TransactionTypeCode), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey QuoteLineAnalyticsBreakdownId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionTypeCode { get; private set; }
    }
}