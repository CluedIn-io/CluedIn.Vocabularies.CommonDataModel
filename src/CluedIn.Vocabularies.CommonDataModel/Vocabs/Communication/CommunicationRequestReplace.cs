using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReplaceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReplaceVocabulary()
        {
            VocabularyName = "Communication Request Replace";
            KeyPrefix = "commonDataModel.communicationrequestreplace";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReplace";

            AddGroup("CommunicationRequestReplace Details", group =>
            {
                CommunicationRequestReplaceId = group.Add(new VocabularyKey(nameof(CommunicationRequestReplaceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestReplaceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}