using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchasePassVocabulary : SimpleVocabulary
    {
        public EventPurchasePassVocabulary()
        {
            VocabularyName = "Common Data Model EventPurchasePass";
            KeyPrefix = "commonDataModel.eventpurchasepass";
            KeySeparator = ".";
            Grouping = "/EventPurchasePass";

            AddGroup("Common Data Model EventPurchasePass Details", group =>
            {
                eventPurchasePassId = group.Add(new VocabularyKey(nameof(eventPurchasePassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey eventPurchasePassId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}