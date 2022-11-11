using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventManagementActivityVocabulary : SimpleVocabulary
    {
        public EventManagementActivityVocabulary()
        {
            VocabularyName = "Common Data Model EventManagementActivity";
            KeyPrefix = "commonDataModel.eventmanagementactivity";
            KeySeparator = ".";
            Grouping = "/EventManagementActivity";

            AddGroup("Common Data Model EventManagementActivity Details", group =>
            {
                actionStatus = group.Add(new VocabularyKey(nameof(actionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activityadditionalparams = group.Add(new VocabularyKey(nameof(activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                durationInMilliseconds = group.Add(new VocabularyKey(nameof(durationInMilliseconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                eventManagementActivityId = group.Add(new VocabularyKey(nameof(eventManagementActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                processingResult = group.Add(new VocabularyKey(nameof(processingResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey actionStatus { get; private set; }
        public VocabularyKey activityadditionalparams { get; private set; }
        public VocabularyKey durationInMilliseconds { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey eventManagementActivityId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey processingResult { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}