using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class CaseVocabulary : SimpleVocabulary
    {
        public CaseVocabulary()
        {
            VocabularyName = "Case";
            KeyPrefix = "commonDataModel.case.service";
            KeySeparator = ".";
            Grouping = "/Case";

            AddGroup("Case Details for Service", group =>
            {
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Case Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivitiesComplete = group.Add(new VocabularyKey(nameof(ActivitiesComplete), "Activities Complete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ActualServiceUnits = group.Add(new VocabularyKey(nameof(ActualServiceUnits), "Actual Service Units", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    BilledServiceUnits = group.Add(new VocabularyKey(nameof(BilledServiceUnits), "Billed Service Units", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    BlockedProfile = group.Add(new VocabularyKey(nameof(BlockedProfile), "Blocked Profile", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CaseOriginCode = group.Add(new VocabularyKey(nameof(CaseOriginCode), "Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CaseTypeCode = group.Add(new VocabularyKey(nameof(CaseTypeCode), "Case Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckEmail = group.Add(new VocabularyKey(nameof(CheckEmail), "Check Email", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ContractServiceLevelCode = group.Add(new VocabularyKey(nameof(ContractServiceLevelCode), "Service Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerSatisfactionCode = group.Add(new VocabularyKey(nameof(CustomerSatisfactionCode), "Satisfaction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstResponseSLAStatus = group.Add(new VocabularyKey(nameof(FirstResponseSLAStatus), "First Response SLA Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowupBy = group.Add(new VocabularyKey(nameof(FollowupBy), "Follow Up By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowUpTaskCreated = group.Add(new VocabularyKey(nameof(FollowUpTaskCreated), "Follow up Task Created", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncidentStageCode = group.Add(new VocabularyKey(nameof(IncidentStageCode), "Case Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDecrementing = group.Add(new VocabularyKey(nameof(IsDecrementing), "Decrementing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MessageTypeCode = group.Add(new VocabularyKey(nameof(MessageTypeCode), "Received As", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductSerialNumber = group.Add(new VocabularyKey(nameof(ProductSerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResolveBySLAStatus = group.Add(new VocabularyKey(nameof(ResolveBySLAStatus), "Resolve By SLA Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SentimentValue = group.Add(new VocabularyKey(nameof(SentimentValue), "Sentiment Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    InfluenceScore = group.Add(new VocabularyKey(nameof(InfluenceScore), "Influence Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ServiceStage = group.Add(new VocabularyKey(nameof(ServiceStage), "Service Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeverityCode = group.Add(new VocabularyKey(nameof(SeverityCode), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TicketNumber = group.Add(new VocabularyKey(nameof(TicketNumber), "Case Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfChildIncidents = group.Add(new VocabularyKey(nameof(NumberOfChildIncidents), "Child Cases", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Merged = group.Add(new VocabularyKey(nameof(Merged), "Internal Use Only", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RouteCase = group.Add(new VocabularyKey(nameof(RouteCase), "Route Case", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ResolveBy = group.Add(new VocabularyKey(nameof(ResolveBy), "Resolve By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResponseBy = group.Add(new VocabularyKey(nameof(ResponseBy), "First Response By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerContacted = group.Add(new VocabularyKey(nameof(CustomerContacted), "Customer Contacted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstResponseSent = group.Add(new VocabularyKey(nameof(FirstResponseSent), "First Response Sent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsEscalated = group.Add(new VocabularyKey(nameof(IsEscalated), "Is Escalated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EscalatedOn = group.Add(new VocabularyKey(nameof(EscalatedOn), "Escalated On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DecrementEntitlementTerm = group.Add(new VocabularyKey(nameof(DecrementEntitlementTerm), "Decrement Entitlement Terms", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ActivitiesComplete { get; private set; }
        public VocabularyKey ActualServiceUnits { get; private set; }
        public VocabularyKey BilledServiceUnits { get; private set; }
        public VocabularyKey BlockedProfile { get; private set; }
        public VocabularyKey CaseOriginCode { get; private set; }
        public VocabularyKey CaseTypeCode { get; private set; }
        public VocabularyKey CheckEmail { get; private set; }
        public VocabularyKey ContractServiceLevelCode { get; private set; }
        public VocabularyKey CustomerSatisfactionCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FirstResponseSLAStatus { get; private set; }
        public VocabularyKey FollowupBy { get; private set; }
        public VocabularyKey FollowUpTaskCreated { get; private set; }
        public VocabularyKey IncidentStageCode { get; private set; }
        public VocabularyKey IsDecrementing { get; private set; }
        public VocabularyKey MessageTypeCode { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ProductSerialNumber { get; private set; }
        public VocabularyKey ResolveBySLAStatus { get; private set; }
        public VocabularyKey SentimentValue { get; private set; }
        public VocabularyKey InfluenceScore { get; private set; }
        public VocabularyKey ServiceStage { get; private set; }
        public VocabularyKey SeverityCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey TicketNumber { get; private set; }
        public VocabularyKey NumberOfChildIncidents { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey RouteCase { get; private set; }
        public VocabularyKey ResolveBy { get; private set; }
        public VocabularyKey ResponseBy { get; private set; }
        public VocabularyKey CustomerContacted { get; private set; }
        public VocabularyKey FirstResponseSent { get; private set; }
        public VocabularyKey IsEscalated { get; private set; }
        public VocabularyKey EscalatedOn { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey DecrementEntitlementTerm { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}