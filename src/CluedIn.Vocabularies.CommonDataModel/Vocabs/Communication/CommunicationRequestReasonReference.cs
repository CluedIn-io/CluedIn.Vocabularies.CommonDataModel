using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonReferenceVocabulary()
        {
            VocabularyName = "Communication Request Reason Reference";
            KeyPrefix = "commonDataModel.communicationrequestreasonreference";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReasonReference";

            AddGroup("CommunicationRequestReasonReference Details", group =>
            {
                CommunicationrequestreasnrefId = group.Add(new VocabularyKey(nameof(CommunicationrequestreasnrefId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationrequestreasnrefId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}