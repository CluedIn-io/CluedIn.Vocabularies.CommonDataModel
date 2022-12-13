using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EmailSoftBouncedVocabulary : SimpleVocabulary
    {
        public EmailSoftBouncedVocabulary()
        {
            VocabularyName = "Email Soft Bounced";
            KeyPrefix = "commonDataModel.emailsoftbounced";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EmailSoftBounced;

            AddGroup("EmailSoftBounced Details for Interactions", group =>
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
                Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BounceCategory = group.Add(new VocabularyKey(nameof(BounceCategory), "Bounce category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemoteBounce = group.Add(new VocabularyKey(nameof(RemoteBounce), "Remote bounce", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), "Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships

            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey BounceCategory { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerJourneyIterationId { get; private set; }
        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey MessageId { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey RemoteBounce { get; private set; }
        public VocabularyKey SendingId { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey UsageType { get; private set; }
    }
}