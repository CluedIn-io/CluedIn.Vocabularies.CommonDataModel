using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class FormVisitedVocabulary : SimpleVocabulary
    {
        public FormVisitedVocabulary()
        {
            VocabularyName = "Form Visited";
            KeyPrefix = "commonDataModel.formvisited";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.FormVisited;

            AddGroup("FormVisited Details for Interactions", group =>
            {
                InteractionId = group.Add(new VocabularyKey(nameof(InteractionId), "Interaction Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageId = group.Add(new VocabularyKey(nameof(MessageId), "Message ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PageId = group.Add(new VocabularyKey(nameof(PageId), "Page ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormId = group.Add(new VocabularyKey(nameof(FormId), "Form ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer Journey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisitorId = group.Add(new VocabularyKey(nameof(VisitorId), "Visitor ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionId = group.Add(new VocabularyKey(nameof(SessionId), "Session ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryIsoCode = group.Add(new VocabularyKey(nameof(CountryIsoCode), "Country ISO code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "Postal code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrowserId = group.Add(new VocabularyKey(nameof(BrowserId), "Browser ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrowserVersion = group.Add(new VocabularyKey(nameof(BrowserVersion), "Browser version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingSystemId = group.Add(new VocabularyKey(nameof(OperatingSystemId), "Operating system ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingSystemVersion = group.Add(new VocabularyKey(nameof(OperatingSystemVersion), "Operating system version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferrerUri = group.Add(new VocabularyKey(nameof(ReferrerUri), "Referrer URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SendingId = group.Add(new VocabularyKey(nameof(SendingId), "Sending ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchPhrase = group.Add(new VocabularyKey(nameof(SearchPhrase), "Search phrase", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchEngineName = group.Add(new VocabularyKey(nameof(SearchEngineName), "Search engine name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisitDuration = group.Add(new VocabularyKey(nameof(VisitDuration), "Visit duration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisitorReturningStatus = group.Add(new VocabularyKey(nameof(VisitorReturningStatus), "Visitor returning status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisitorAnonymousStatus = group.Add(new VocabularyKey(nameof(VisitorAnonymousStatus), "Visitor anonymous status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadId = group.Add(new VocabularyKey(nameof(LeadId), "Lead ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships

            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey BrowserId { get; private set; }
        public VocabularyKey BrowserVersion { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey CountryIsoCode { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey FormId { get; private set; }
        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey MessageId { get; private set; }
        public VocabularyKey OperatingSystemId { get; private set; }
        public VocabularyKey OperatingSystemVersion { get; private set; }
        public VocabularyKey PageId { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey ReferrerUri { get; private set; }
        public VocabularyKey SearchEngineName { get; private set; }
        public VocabularyKey SearchPhrase { get; private set; }
        public VocabularyKey SendingId { get; private set; }
        public VocabularyKey SessionId { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey VisitDuration { get; private set; }
        public VocabularyKey VisitorAnonymousStatus { get; private set; }
        public VocabularyKey VisitorId { get; private set; }
        public VocabularyKey VisitorReturningStatus { get; private set; }
    }
}