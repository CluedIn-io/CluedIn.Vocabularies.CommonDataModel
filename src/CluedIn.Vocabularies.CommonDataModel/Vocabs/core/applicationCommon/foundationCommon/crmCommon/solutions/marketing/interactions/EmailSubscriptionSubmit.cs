using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EmailSubscriptionSubmitVocabulary : SimpleVocabulary
    {
        public EmailSubscriptionSubmitVocabulary()
        {
            VocabularyName = "Email Subscription Submit";
            KeyPrefix = "commonDataModel.emailsubscriptionsubmit";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EmailSubscriptionSubmit;

            AddGroup("EmailSubscriptionSubmit Details for Interactions", group =>
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
			    CountryIsoCode = group.Add(new VocabularyKey(nameof(CountryIsoCode), "Country ISO code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    City = group.Add(new VocabularyKey(nameof(City), "City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), "Postal code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BrowserId = group.Add(new VocabularyKey(nameof(BrowserId), "Browser ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BrowserVersion = group.Add(new VocabularyKey(nameof(BrowserVersion), "Browser version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OperatingSystemId = group.Add(new VocabularyKey(nameof(OperatingSystemId), "Operating system ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OperatingSystemVersion = group.Add(new VocabularyKey(nameof(OperatingSystemVersion), "Operating system version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceType = group.Add(new VocabularyKey(nameof(DeviceType), "Device type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceBrand = group.Add(new VocabularyKey(nameof(DeviceBrand), "Device brand", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceModel = group.Add(new VocabularyKey(nameof(DeviceModel), "Device model", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey CustomerJourneyIterationId { get; private set; }
        public VocabularyKey DeviceBrand { get; private set; }
        public VocabularyKey DeviceModel { get; private set; }
        public VocabularyKey DeviceType { get; private set; }
        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey MessageId { get; private set; }
        public VocabularyKey OperatingSystemId { get; private set; }
        public VocabularyKey OperatingSystemVersion { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey SendingId { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey UsageType { get; private set; }
    }
}