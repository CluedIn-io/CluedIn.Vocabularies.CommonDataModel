using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestRecipientVocabulary : SimpleVocabulary
    {
        public CommunicationRequestRecipientVocabulary()
        {
            VocabularyName = "Communication Request Recipient";
            KeyPrefix = "commonDataModel.communicationrequestrecipient";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestRecipient";

            AddGroup("CommunicationRequestRecipient Details", group =>
            {
                CommunicationRequestRecipientId = group.Add(new VocabularyKey(nameof(CommunicationRequestRecipientId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientType = group.Add(new VocabularyKey(nameof(RecipientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestRecipientId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RecipientType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}