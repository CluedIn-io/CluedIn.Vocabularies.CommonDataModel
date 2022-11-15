using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventManagementActivityVocabulary : SimpleVocabulary
    {
        public EventManagementActivityVocabulary()
        {
            VocabularyName = "Event Management Activity";
            KeyPrefix = "commonDataModel.eventmanagementactivity";
            KeySeparator = ".";
            Grouping = "/EventManagementActivity";

            AddGroup("EventManagementActivity Details", group =>
            {
                ActionStatus = group.Add(new VocabularyKey(nameof(ActionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Activityadditionalparams = group.Add(new VocabularyKey(nameof(Activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DurationInMilliseconds = group.Add(new VocabularyKey(nameof(DurationInMilliseconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventManagementActivityId = group.Add(new VocabularyKey(nameof(EventManagementActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingResult = group.Add(new VocabularyKey(nameof(ProcessingResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActionStatus { get; private set; }
        public VocabularyKey Activityadditionalparams { get; private set; }
        public VocabularyKey DurationInMilliseconds { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey EventManagementActivityId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessingResult { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}