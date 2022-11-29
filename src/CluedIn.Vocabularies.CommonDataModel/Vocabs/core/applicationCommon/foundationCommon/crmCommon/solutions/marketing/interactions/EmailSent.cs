using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Interactions
{
    public class EmailSentVocabulary : SimpleVocabulary
    {
        public EmailSentVocabulary()
        {
            VocabularyName = "Email Sent";
            KeyPrefix = "commonDataModel.emailsent.interactions";
            KeySeparator = ".";
            Grouping = "/EmailSent";

            AddGroup("EmailSent Details for Interactions", group =>
            {
			    InteractionId = group.Add(new VocabularyKey(nameof(InteractionId), "Interaction Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SendingId = group.Add(new VocabularyKey(nameof(SendingId), "Sending ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MessageId = group.Add(new VocabularyKey(nameof(MessageId), "Message ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer Journey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyIterationId = group.Add(new VocabularyKey(nameof(CustomerJourneyIterationId), "Customer journey iteration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UsageType = group.Add(new VocabularyKey(nameof(UsageType), "Usage type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InteractionType = group.Add(new VocabularyKey(nameof(InteractionType), "Interaction type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddressUsed = group.Add(new VocabularyKey(nameof(EmailAddressUsed), "Email address used", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailDomain = group.Add(new VocabularyKey(nameof(EmailDomain), "Email domain", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), "Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey SendingId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey MessageId { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerJourneyIterationId { get; private set; }
        public VocabularyKey UsageType { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey EmailAddressUsed { get; private set; }
        public VocabularyKey EmailDomain { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
    }
}