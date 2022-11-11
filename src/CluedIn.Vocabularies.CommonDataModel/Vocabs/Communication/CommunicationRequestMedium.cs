using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestMediumVocabulary : SimpleVocabulary
    {
        public CommunicationRequestMediumVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestMedium";
            KeyPrefix = "commonDataModel.communicationrequestmedium";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestMedium";

            AddGroup("Common Data Model CommunicationRequestMedium Details", group =>
            {
                communicationRequestMediumId = group.Add(new VocabularyKey(nameof(communicationRequestMediumId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey communicationRequestMediumId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}