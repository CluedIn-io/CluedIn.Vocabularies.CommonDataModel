using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class QueueVocabulary : SimpleVocabulary
    {
        public QueueVocabulary()
        {
            VocabularyName = "Queue";
            KeyPrefix = "commonDataModel.queue.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Queue";

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