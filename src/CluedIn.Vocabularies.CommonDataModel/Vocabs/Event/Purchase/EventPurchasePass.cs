using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchasePassVocabulary : SimpleVocabulary
    {
        public EventPurchasePassVocabulary()
        {
            VocabularyName = "Event Purchase Pass";
            KeyPrefix = "commonDataModel.eventpurchasepass";
            KeySeparator = ".";
            Grouping = "/EventPurchasePass";

            AddGroup("EventPurchasePass Details", group =>
            {
                EventPurchasePassId = group.Add(new VocabularyKey(nameof(EventPurchasePassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EventPurchasePassId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}