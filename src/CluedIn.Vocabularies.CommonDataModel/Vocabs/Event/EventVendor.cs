using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventVendorVocabulary : SimpleVocabulary
    {
        public EventVendorVocabulary()
        {
            VocabularyName = "EventVendor";
            KeyPrefix = "commonDataModel.eventvendor";
            KeySeparator = ".";
            Grouping = "/EventVendor";

            AddGroup("EventVendor Details", group =>
            {
                eventVendorId = group.Add(new VocabularyKey(nameof(eventVendorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey eventVendorId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}