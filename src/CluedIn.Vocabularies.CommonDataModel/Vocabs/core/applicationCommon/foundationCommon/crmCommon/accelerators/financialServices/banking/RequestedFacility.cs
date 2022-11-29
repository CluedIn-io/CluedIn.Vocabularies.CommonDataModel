using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class RequestedFacilityVocabulary : SimpleVocabulary
    {
        public RequestedFacilityVocabulary()
        {
            VocabularyName = "Requested Facility";
            KeyPrefix = "commonDataModel.requestedfacility.banking";
            KeySeparator = ".";
            Grouping = "/RequestedFacility";

            AddGroup("RequestedFacility Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    FundingEvent = group.Add(new VocabularyKey(nameof(FundingEvent), "Funding Event", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InterestRate = group.Add(new VocabularyKey(nameof(InterestRate), "Interest Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingCharges = group.Add(new VocabularyKey(nameof(ProcessingCharges), "Processing Charges", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestedFacilityId = group.Add(new VocabularyKey(nameof(RequestedFacilityId), "Requested Facility", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DeprecatedStageId = group.Add(new VocabularyKey(nameof(DeprecatedStageId), "(Deprecated) Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeprecatedTraversedPath = group.Add(new VocabularyKey(nameof(DeprecatedTraversedPath), "(Deprecated) Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey FundingEvent { get; private set; }
        public VocabularyKey InterestRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessingCharges { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RequestedFacilityId { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey DeprecatedStageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey DeprecatedTraversedPath { get; private set; }
    }
}