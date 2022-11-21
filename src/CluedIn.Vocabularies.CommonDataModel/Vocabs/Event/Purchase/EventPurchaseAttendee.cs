using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseAttendeeVocabulary : SimpleVocabulary
    {
        public EventPurchaseAttendeeVocabulary()
        {
            VocabularyName = "Event Purchase Attendee";
            KeyPrefix = "commonDataModel.eventpurchaseattendee";
            KeySeparator = ".";
            Grouping = "/EventPurchaseAttendee";

            AddGroup("EventPurchaseAttendee Details", group =>
            {
                EventPurchaseAttendeeId = group.Add(new VocabularyKey(nameof(EventPurchaseAttendeeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EventPurchaseAttendeeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}