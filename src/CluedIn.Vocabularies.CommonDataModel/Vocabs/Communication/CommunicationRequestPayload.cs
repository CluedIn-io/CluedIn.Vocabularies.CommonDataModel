using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestPayloadVocabulary : SimpleVocabulary
    {
        public CommunicationRequestPayloadVocabulary()
        {
            VocabularyName = "Communication Request Payload";
            KeyPrefix = "commonDataModel.communicationrequestpayload";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestPayload";

            AddGroup("CommunicationRequestPayload Details", group =>
            {
                CommunicationRequestPayloadId = group.Add(new VocabularyKey(nameof(CommunicationRequestPayloadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayloadContentReference = group.Add(new VocabularyKey(nameof(PayloadContentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayloadContentString = group.Add(new VocabularyKey(nameof(PayloadContentString), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestPayloadId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PayloadContentReference { get; private set; }
        public VocabularyKey PayloadContentString { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}