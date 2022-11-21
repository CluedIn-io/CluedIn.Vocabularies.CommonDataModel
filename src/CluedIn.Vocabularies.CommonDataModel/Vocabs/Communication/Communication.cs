using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationVocabulary : SimpleVocabulary
    {
        public CommunicationVocabulary()
        {
            VocabularyName = "Communication";
            KeyPrefix = "commonDataModel.communication";
            KeySeparator = ".";
            Grouping = "/Communication";

            AddGroup("Communication Details", group =>
            {
                CommunicationId = group.Add(new VocabularyKey(nameof(CommunicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Display = group.Add(new VocabularyKey(nameof(Display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredCommunication = group.Add(new VocabularyKey(nameof(PreferredCommunication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationId { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey PreferredCommunication { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}