using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class EventCustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public EventCustomRegistrationFieldVocabulary()
        {
            VocabularyName = "Event Custom Registration Field";
            KeyPrefix = "commonDataModel.eventcustomregistrationfield.eventmanagement";
            KeySeparator = ".";
            Grouping = "/EventCustomRegistrationField";

            AddGroup("EventCustomRegistrationField Details for EventManagement", group =>
            {
			    EventCustomRegistrationFieldId = group.Add(new VocabularyKey(nameof(EventCustomRegistrationFieldId), "Event Custom Registration Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Order = group.Add(new VocabularyKey(nameof(Order), "Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EventCustomRegistrationFieldId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Order { get; private set; }
    }
}