using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseContactVocabulary : SimpleVocabulary
    {
        public EventPurchaseContactVocabulary()
        {
            VocabularyName = "Event Purchase Contact";
            KeyPrefix = "commonDataModel.eventpurchasecontact";
            KeySeparator = ".";
            Grouping = "/EventPurchaseContact";

            AddGroup("EventPurchaseContact Details", group =>
            {
                Emailaddress1 = group.Add(new VocabularyKey(nameof(Emailaddress1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventPurchaseContactId = group.Add(new VocabularyKey(nameof(EventPurchaseContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullName = group.Add(new VocabularyKey(nameof(FullName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Emailaddress1 { get; private set; }
        public VocabularyKey EventPurchaseContactId { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey FullName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}