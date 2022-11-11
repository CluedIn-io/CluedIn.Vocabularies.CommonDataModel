using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseAttendeeVocabulary : SimpleVocabulary
    {
        public EventPurchaseAttendeeVocabulary()
        {
            VocabularyName = "Common Data Model EventPurchaseAttendee";
            KeyPrefix = "commonDataModel.eventpurchaseattendee";
            KeySeparator = ".";
            Grouping = "/EventPurchaseAttendee";

            AddGroup("Common Data Model EventPurchaseAttendee Details", group =>
            {
                eventPurchaseAttendeeId = group.Add(new VocabularyKey(nameof(eventPurchaseAttendeeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey eventPurchaseAttendeeId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}