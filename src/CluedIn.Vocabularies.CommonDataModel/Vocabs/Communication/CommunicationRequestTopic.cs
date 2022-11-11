using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestTopicVocabulary : SimpleVocabulary
    {
        public CommunicationRequestTopicVocabulary()
        {
            VocabularyName = "CommunicationRequestTopic";
            KeyPrefix = "commonDataModel.communicationrequesttopic";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestTopic";

            AddGroup("CommunicationRequestTopic Details", group =>
            {
                communicationRequestTopicId = group.Add(new VocabularyKey(nameof(communicationRequestTopicId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                topic = group.Add(new VocabularyKey(nameof(topic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey communicationRequestTopicId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey topic { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}