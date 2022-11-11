using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventCustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public EventCustomRegistrationFieldVocabulary()
        {
            VocabularyName = "Common Data Model EventCustomRegistrationField";
            KeyPrefix = "commonDataModel.eventcustomregistrationfield";
            KeySeparator = ".";
            Grouping = "/EventCustomRegistrationField";

            AddGroup("Common Data Model EventCustomRegistrationField Details", group =>
            {
                eventCustomRegistrationFieldId = group.Add(new VocabularyKey(nameof(eventCustomRegistrationFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                order = group.Add(new VocabularyKey(nameof(order), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey eventCustomRegistrationFieldId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey order { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}