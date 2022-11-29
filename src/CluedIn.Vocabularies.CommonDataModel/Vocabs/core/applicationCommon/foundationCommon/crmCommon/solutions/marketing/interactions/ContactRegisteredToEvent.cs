using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Interactions
{
    public class ContactRegisteredToEventVocabulary : SimpleVocabulary
    {
        public ContactRegisteredToEventVocabulary()
        {
            VocabularyName = "Contact Registered To Event";
            KeyPrefix = "commonDataModel.contactregisteredtoevent.interactions";
            KeySeparator = ".";
            Grouping = "/ContactRegisteredToEvent";

            AddGroup("ContactRegisteredToEvent Details for Interactions", group =>
            {
			    InteractionId = group.Add(new VocabularyKey(nameof(InteractionId), "Interaction Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventId = group.Add(new VocabularyKey(nameof(EventId), "Event ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EventRegistrationId = group.Add(new VocabularyKey(nameof(EventRegistrationId), "eventregistrationid", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InteractionType = group.Add(new VocabularyKey(nameof(InteractionType), "Interaction type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer Journey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey EventId { get; private set; }
        public VocabularyKey EventRegistrationId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
    }
}