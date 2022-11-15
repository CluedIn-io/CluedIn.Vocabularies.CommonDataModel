using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReasonVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonVocabulary()
        {
            VocabularyName = "Communication Request Reason";
            KeyPrefix = "commonDataModel.communicationrequestreason";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReason";

            AddGroup("CommunicationRequestReason Details", group =>
            {
                CommunicationRequestReasonId = group.Add(new VocabularyKey(nameof(CommunicationRequestReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestReasonId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}