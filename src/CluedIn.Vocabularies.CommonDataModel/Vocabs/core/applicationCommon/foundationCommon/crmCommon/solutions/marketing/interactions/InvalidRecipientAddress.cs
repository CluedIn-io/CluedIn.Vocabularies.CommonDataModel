using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Interactions
{
    public class InvalidRecipientAddressVocabulary : SimpleVocabulary
    {
        public InvalidRecipientAddressVocabulary()
        {
            VocabularyName = "Invalid Recipient Address";
            KeyPrefix = "commonDataModel.invalidrecipientaddress.interactions";
            KeySeparator = ".";
            Grouping = "/InvalidRecipientAddress";

            AddGroup("InvalidRecipientAddress Details for Interactions", group =>
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
			    BlockedReason = group.Add(new VocabularyKey(nameof(BlockedReason), "Blocked reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
        public VocabularyKey BlockedReason { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
    }
}