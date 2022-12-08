using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class InviteRedemptionVocabulary : SimpleVocabulary
    {
        public InviteRedemptionVocabulary()
        {
            VocabularyName = "Invite Redemption";
            KeyPrefix = "commonDataModel.inviteredemption.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.InviteRedemption;

            AddGroup("InviteRedemption Details for Portals", group =>
            {
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBilled = group.Add(new VocabularyKey(nameof(IsBilled), "Is Billed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityTypeCode = group.Add(new VocabularyKey(nameof(ActivityTypeCode), "Activity Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDurationMinutes = group.Add(new VocabularyKey(nameof(ScheduledDurationMinutes), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualDurationMinutes = group.Add(new VocabularyKey(nameof(ActualDurationMinutes), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsWorkflowCreated = group.Add(new VocabularyKey(nameof(IsWorkflowCreated), "Is Workflow Created", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InstanceTypeCode = group.Add(new VocabularyKey(nameof(InstanceTypeCode), "Recurring Instance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeriesId = group.Add(new VocabularyKey(nameof(SeriesId), "Series ID", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsRegularActivity = group.Add(new VocabularyKey(nameof(IsRegularActivity), "Is Regular Activity", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LeftVoiceMail = group.Add(new VocabularyKey(nameof(LeftVoiceMail), "Left Voice Mail", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Community = group.Add(new VocabularyKey(nameof(Community), "Social Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsMapiPrivate = group.Add(new VocabularyKey(nameof(IsMapiPrivate), "Is Private", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExchangeWebLink = group.Add(new VocabularyKey(nameof(ExchangeWebLink), "Exchange WebLink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeItemId = group.Add(new VocabularyKey(nameof(ExchangeItemId), "Exchange Item ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryPriorityCode = group.Add(new VocabularyKey(nameof(DeliveryPriorityCode), "Delivery Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SentOn = group.Add(new VocabularyKey(nameof(SentOn), "Date Sent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryLastAttemptedOn = group.Add(new VocabularyKey(nameof(DeliveryLastAttemptedOn), "Date Delivery Last Attempted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SenderMailboxId = group.Add(new VocabularyKey(nameof(SenderMailboxId), "Sender's Mailbox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostponeActivityProcessingUntil = group.Add(new VocabularyKey(nameof(PostponeActivityProcessingUntil), "Delay activity processing until", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ActivityAdditionalParams = group.Add(new VocabularyKey(nameof(ActivityAdditionalParams), "Activity Additional Parameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SortDate = group.Add(new VocabularyKey(nameof(SortDate), "Sort Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "CC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "BCC", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequiredAttendees = group.Add(new VocabularyKey(nameof(RequiredAttendees), "Required Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OptionalAttendees = group.Add(new VocabularyKey(nameof(OptionalAttendees), "Optional Attendees", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Organizer = group.Add(new VocabularyKey(nameof(Organizer), "Organizer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resources = group.Add(new VocabularyKey(nameof(Resources), "Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Customers = group.Add(new VocabularyKey(nameof(Customers), "Customers", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Partners = group.Add(new VocabularyKey(nameof(Partners), "Outsource Vendors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IpAddress = group.Add(new VocabularyKey(nameof(IpAddress), "IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Ad.cdm.json/Ad' with Property 'AdId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'AdPlacement.cdm.json/AdPlacement' with Property 'AdPlacementId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Blog.cdm.json/Blog' with Property 'BlogId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'BlogPost.cdm.json/BlogPost' with Property 'BlogPostId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'CaseDeflection.cdm.json/CaseDeflection' with Property 'CaseDeflectionId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Invitation.cdm.json/Invitation' with Property 'InvitationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ActivityId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'WebPage.cdm.json/WebPage' with Property 'WebpageId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Poll.cdm.json/Poll' with Property 'PollId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'PollSubmission.cdm.json/PollSubmission' with Property 'PollSubmissionId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'PollPlacement.cdm.json/PollPlacement' with Property 'PollPlacementId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'PollOption.cdm.json/PollOption' with Property 'PollOptionId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Website.cdm.json/Website' with Property 'WebsiteId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'SalesOrderId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Contract.cdm.json/Contract' with Property 'ContractId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Site.cdm.json/Site' with Property 'SiteId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'InvoiceId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Entitlement.cdm.json/Entitlement' with Property 'EntitlementId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="ServiceId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Service.cdm.json/Service' with Property 'ServiceId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey IsBilled { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ActivityTypeCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledDurationMinutes { get; private set; }
        public VocabularyKey ActualDurationMinutes { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey IsWorkflowCreated { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey InstanceTypeCode { get; private set; }
        public VocabularyKey SeriesId { get; private set; }
        public VocabularyKey IsRegularActivity { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey LeftVoiceMail { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey IsMapiPrivate { get; private set; }
        public VocabularyKey ExchangeWebLink { get; private set; }
        public VocabularyKey ExchangeItemId { get; private set; }
        public VocabularyKey DeliveryPriorityCode { get; private set; }
        public VocabularyKey SentOn { get; private set; }
        public VocabularyKey DeliveryLastAttemptedOn { get; private set; }
        public VocabularyKey SenderMailboxId { get; private set; }
        public VocabularyKey PostponeActivityProcessingUntil { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ActivityAdditionalParams { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey SortDate { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey RequiredAttendees { get; private set; }
        public VocabularyKey OptionalAttendees { get; private set; }
        public VocabularyKey Organizer { get; private set; }
        public VocabularyKey Resources { get; private set; }
        public VocabularyKey Customers { get; private set; }
        public VocabularyKey Partners { get; private set; }
        public VocabularyKey IpAddress { get; private set; }
    }
}