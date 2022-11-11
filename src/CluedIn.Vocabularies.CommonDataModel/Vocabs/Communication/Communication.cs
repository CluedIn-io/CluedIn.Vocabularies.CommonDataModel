using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationVocabulary : SimpleVocabulary
    {
        public CommunicationVocabulary()
        {
            VocabularyName = "Common Data Model Communication";
            KeyPrefix = "commonDataModel.communication";
            KeySeparator = ".";
            Grouping = "/Communication";

            AddGroup("Common Data Model Communication Details", group =>
            {
                communicationId = group.Add(new VocabularyKey(nameof(communicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                display = group.Add(new VocabularyKey(nameof(display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                preferredCommunication = group.Add(new VocabularyKey(nameof(preferredCommunication), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey communicationId { get; private set; }
        public VocabularyKey display { get; private set; }
        public VocabularyKey preferredCommunication { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}