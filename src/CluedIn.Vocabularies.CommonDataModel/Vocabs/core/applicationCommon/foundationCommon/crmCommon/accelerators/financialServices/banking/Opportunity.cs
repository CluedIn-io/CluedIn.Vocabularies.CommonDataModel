using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.banking";
            KeySeparator = ".";
            Grouping = "/Opportunity";

            AddGroup("Opportunity Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostOfProperty = group.Add(new VocabularyKey(nameof(CostOfProperty), "Cost of Property", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostOfPropertyBase = group.Add(new VocabularyKey(nameof(CostOfPropertyBase), "Cost of Property (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DownPayment = group.Add(new VocabularyKey(nameof(DownPayment), "Down Payment", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    DownPaymentBase = group.Add(new VocabularyKey(nameof(DownPaymentBase), "Down Payment (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), "Interest Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PreferredFollowUpTime = group.Add(new VocabularyKey(nameof(PreferredFollowUpTime), "Preferred Follow-up Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurposeOfLoan = group.Add(new VocabularyKey(nameof(PurposeOfLoan), "Purpose of Loan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedAmount = group.Add(new VocabularyKey(nameof(RequestedAmount), "Requested Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    RequestedAmountBase = group.Add(new VocabularyKey(nameof(RequestedAmountBase), "Requested Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TermOfLoan = group.Add(new VocabularyKey(nameof(TermOfLoan), "Term of Loan", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostOfProperty { get; private set; }
        public VocabularyKey CostOfPropertyBase { get; private set; }
        public VocabularyKey DownPayment { get; private set; }
        public VocabularyKey DownPaymentBase { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey PreferredFollowUpTime { get; private set; }
        public VocabularyKey PurposeOfLoan { get; private set; }
        public VocabularyKey RequestedAmount { get; private set; }
        public VocabularyKey RequestedAmountBase { get; private set; }
        public VocabularyKey TermOfLoan { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}