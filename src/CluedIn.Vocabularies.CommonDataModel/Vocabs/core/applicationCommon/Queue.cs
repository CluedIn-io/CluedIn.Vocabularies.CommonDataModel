using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class QueueVocabulary : SimpleVocabulary
    {
        public QueueVocabulary()
        {
            VocabularyName = "Queue";
            KeyPrefix = "commonDataModel.queue.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Queue;

            AddGroup("Queue Details for ApplicationCommon", group =>
            {
			    QueueId = group.Add(new VocabularyKey(nameof(QueueId), "Queue", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Incoming Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    QueueTypeCode = group.Add(new VocabularyKey(nameof(QueueTypeCode), "Queue Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QueueSemantics = group.Add(new VocabularyKey(nameof(QueueSemantics), "Queue Semantics", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IgnoreUnsolicitedEmail = group.Add(new VocabularyKey(nameof(IgnoreUnsolicitedEmail), "Convert To Email Activities", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsFaxQueue = group.Add(new VocabularyKey(nameof(IsFaxQueue), "Fax Queue", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmailPassword = group.Add(new VocabularyKey(nameof(EmailPassword), "Password (Obsolete)", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    IncomingEmailDeliveryMethod = group.Add(new VocabularyKey(nameof(IncomingEmailDeliveryMethod), "Incoming Email Delivery Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailUsername = group.Add(new VocabularyKey(nameof(EmailUsername), "User Name (Obsolete)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OutgoingEmailDeliveryMethod = group.Add(new VocabularyKey(nameof(OutgoingEmailDeliveryMethod), "Outgoing Email Delivery Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowEmailCredentials = group.Add(new VocabularyKey(nameof(AllowEmailCredentials), "Allow to Use Credentials for Email Processing (Obsolete)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncomingEmailFilteringMethod = group.Add(new VocabularyKey(nameof(IncomingEmailFilteringMethod), "Convert Incoming Email To Activities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfItems = group.Add(new VocabularyKey(nameof(NumberOfItems), "Queue Items", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NumberOfMembers = group.Add(new VocabularyKey(nameof(NumberOfMembers), "No. of Members", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EmailRouterAccessApproval = group.Add(new VocabularyKey(nameof(EmailRouterAccessApproval), "Primary Email Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefaultMailbox = group.Add(new VocabularyKey(nameof(DefaultMailbox), "Mailbox", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    IsEmailAddressApprovedByO365Admin = group.Add(new VocabularyKey(nameof(IsEmailAddressApprovedByO365Admin), "Email Address O365 Admin Approval Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    QueueViewType = group.Add(new VocabularyKey(nameof(QueueViewType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ObjectId"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="BusinessUnitId"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ObjectId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="ObjectId"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="ObjectId"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="PrimaryUserId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="QueueId"/> to Vocab 'Queue.cdm.json/Queue' with Property 'QueueId'
            ///Property <see cref="ObjectId"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="WorkerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="WorkerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="QueueId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="QueueId"/> from Vocab 'Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="QueueId"/> from Vocab 'QueueItem.cdm.json/QueueItem' with Property 'QueueId'
            ///Property <see cref="QueueId"/> from Vocab 'Team.cdm.json/Team' with Property 'QueueId'
            ///Property <see cref="QueueId"/> from Vocab 'User.cdm.json/User' with Property 'QueueId'
            ///Property <see cref="QueueId"/> from Vocab 'foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'EmailSender'
            ///Property <see cref="QueueId"/> from Vocab 'foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'QueueId'
            ///Property <see cref="QueueId"/> from Vocab 'foundationCommon/crmCommon/service/ActivityParty.cdm.json/ActivityParty' with Property 'PartyId'
            ///Property <see cref="QueueId"/> from Vocab 'foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'QueueId'
            #endregion
        }

        public VocabularyKey QueueId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey QueueTypeCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey QueueSemantics { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey IgnoreUnsolicitedEmail { get; private set; }
        public VocabularyKey IsFaxQueue { get; private set; }
        public VocabularyKey EmailPassword { get; private set; }
        public VocabularyKey IncomingEmailDeliveryMethod { get; private set; }
        public VocabularyKey EmailUsername { get; private set; }
        public VocabularyKey OutgoingEmailDeliveryMethod { get; private set; }
        public VocabularyKey AllowEmailCredentials { get; private set; }
        public VocabularyKey IncomingEmailFilteringMethod { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey NumberOfItems { get; private set; }
        public VocabularyKey NumberOfMembers { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey EmailRouterAccessApproval { get; private set; }
        public VocabularyKey DefaultMailbox { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey IsEmailAddressApprovedByO365Admin { get; private set; }
        public VocabularyKey QueueViewType { get; private set; }
    }
}