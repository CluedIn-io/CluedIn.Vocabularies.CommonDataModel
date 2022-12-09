using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EmailVocabulary : SimpleVocabulary
    {
        public EmailVocabulary()
        {
            VocabularyName = "Email";
            KeyPrefix = "commonDataModel.email";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Email;

            AddGroup("Email Details for ApplicationCommon", group =>
            {
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmittedBy = group.Add(new VocabularyKey(nameof(SubmittedBy), "Submitted By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MimeType = group.Add(new VocabularyKey(nameof(MimeType), "Mime Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReadReceiptRequested = group.Add(new VocabularyKey(nameof(ReadReceiptRequested), "Read Receipt Requested", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TrackingToken = group.Add(new VocabularyKey(nameof(TrackingToken), "Tracking Token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Sender = group.Add(new VocabularyKey(nameof(Sender), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToRecipients = group.Add(new VocabularyKey(nameof(ToRecipients), "To Recipients", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryReceiptRequested = group.Add(new VocabularyKey(nameof(DeliveryReceiptRequested), "Delivery Receipt Requested", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MessageId = group.Add(new VocabularyKey(nameof(MessageId), "Message ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryAttempts = group.Add(new VocabularyKey(nameof(DeliveryAttempts), "No. of Delivery Attempts", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Compressed = group.Add(new VocabularyKey(nameof(Compressed), "Compression", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Notifications = group.Add(new VocabularyKey(nameof(Notifications), "Notifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AttachmentCount = group.Add(new VocabularyKey(nameof(AttachmentCount), "Attachment Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    InReplyTo = group.Add(new VocabularyKey(nameof(InReplyTo), "In Reply To Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BaseConversationIndexHash = group.Add(new VocabularyKey(nameof(BaseConversationIndexHash), "Conversation Index (Hash)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConversationIndex = group.Add(new VocabularyKey(nameof(ConversationIndex), "Conversation Index", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CorrelationMethod = group.Add(new VocabularyKey(nameof(CorrelationMethod), "Correlation Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostponeEmailProcessingUntil = group.Add(new VocabularyKey(nameof(PostponeEmailProcessingUntil), "Delay email processing until", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsUnsafe = group.Add(new VocabularyKey(nameof(IsUnsafe), "IsUnsafe", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AttachmentOpenCount = group.Add(new VocabularyKey(nameof(AttachmentOpenCount), "Attachment Open Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ConversationTrackingId = group.Add(new VocabularyKey(nameof(ConversationTrackingId), "Conversation Tracking Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    DelayedEmailSendTime = group.Add(new VocabularyKey(nameof(DelayedEmailSendTime), "Send Later", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastOpenedTime = group.Add(new VocabularyKey(nameof(LastOpenedTime), "Last Opened Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinksClickedCount = group.Add(new VocabularyKey(nameof(LinksClickedCount), "Links Clicked Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenCount = group.Add(new VocabularyKey(nameof(OpenCount), "Open Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ReplyCount = group.Add(new VocabularyKey(nameof(ReplyCount), "Reply Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EmailTrackingId = group.Add(new VocabularyKey(nameof(EmailTrackingId), "Email Tracking Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    FollowEmailUserPreference = group.Add(new VocabularyKey(nameof(FollowEmailUserPreference), "Following", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsEmailFollowed = group.Add(new VocabularyKey(nameof(IsEmailFollowed), "Followed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmailReminderExpiryTime = group.Add(new VocabularyKey(nameof(EmailReminderExpiryTime), "Email Reminder Expiry Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailReminderType = group.Add(new VocabularyKey(nameof(EmailReminderType), "Email Reminder Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailReminderStatus = group.Add(new VocabularyKey(nameof(EmailReminderStatus), "Email Reminder Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailReminderText = group.Add(new VocabularyKey(nameof(EmailReminderText), "Email Reminder Text", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), "ID for template used.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReminderActionCardId = group.Add(new VocabularyKey(nameof(ReminderActionCardId), "Reminder Action Card Id.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsEmailReminderSet = group.Add(new VocabularyKey(nameof(IsEmailReminderSet), "Reminder Set", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Email Details for CrmCommon", group =>
            {
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "Bcc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "Cc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EmailSender"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EmailSender"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="EmailSender"/> to Vocab 'Queue.cdm.json/Queue' with Property 'QueueId'
            ///Property <see cref="EmailSender"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ParentActivityId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="EmailSender"/> to Vocab 'Queue.cdm.json/Queue' with Property 'QueueId'
            ///Property <see cref="SLAId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ActivityId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ActivityId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="ActivityId"/> from Vocab 'Email.cdm.json/Email' with Property 'ParentActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'QueueItem.cdm.json/QueueItem' with Property 'ObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            #endregion
        }

        public VocabularyKey AttachmentCount { get; private set; }
        public VocabularyKey AttachmentOpenCount { get; private set; }
        public VocabularyKey BaseConversationIndexHash { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey Compressed { get; private set; }
        public VocabularyKey ConversationIndex { get; private set; }
        public VocabularyKey ConversationTrackingId { get; private set; }
        public VocabularyKey CorrelationMethod { get; private set; }
        public VocabularyKey DelayedEmailSendTime { get; private set; }
        public VocabularyKey DeliveryAttempts { get; private set; }
        public VocabularyKey DeliveryReceiptRequested { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmailReminderExpiryTime { get; private set; }
        public VocabularyKey EmailReminderStatus { get; private set; }
        public VocabularyKey EmailReminderText { get; private set; }
        public VocabularyKey EmailReminderType { get; private set; }
        public VocabularyKey EmailTrackingId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey FollowEmailUserPreference { get; private set; }
        public VocabularyKey InReplyTo { get; private set; }
        public VocabularyKey IsEmailFollowed { get; private set; }
        public VocabularyKey IsEmailReminderSet { get; private set; }
        public VocabularyKey IsUnsafe { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey LastOpenedTime { get; private set; }
        public VocabularyKey LinksClickedCount { get; private set; }
        public VocabularyKey MessageId { get; private set; }
        public VocabularyKey MimeType { get; private set; }
        public VocabularyKey Notifications { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey OpenCount { get; private set; }
        public VocabularyKey PostponeEmailProcessingUntil { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey ReadReceiptRequested { get; private set; }
        public VocabularyKey ReminderActionCardId { get; private set; }
        public VocabularyKey ReplyCount { get; private set; }
        public VocabularyKey Sender { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubmittedBy { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey ToRecipients { get; private set; }
        public VocabularyKey TrackingToken { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}