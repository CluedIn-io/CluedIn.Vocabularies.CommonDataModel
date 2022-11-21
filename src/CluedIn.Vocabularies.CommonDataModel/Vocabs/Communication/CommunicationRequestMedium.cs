using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestMediumVocabulary : SimpleVocabulary
    {
        public CommunicationRequestMediumVocabulary()
        {
            VocabularyName = "Communication Request Medium";
            KeyPrefix = "commonDataModel.communicationrequestmedium";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestMedium";

            AddGroup("CommunicationRequestMedium Details", group =>
            {
                CommunicationRequestMediumId = group.Add(new VocabularyKey(nameof(CommunicationRequestMediumId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestMediumId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}