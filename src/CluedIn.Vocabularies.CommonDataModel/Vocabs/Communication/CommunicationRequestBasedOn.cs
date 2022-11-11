using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestBasedOnVocabulary : SimpleVocabulary
    {
        public CommunicationRequestBasedOnVocabulary()
        {
            VocabularyName = "Common Data Model CommunicationRequestBasedOn";
            KeyPrefix = "commonDataModel.communicationrequestbasedon";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestBasedOn";

            AddGroup("Common Data Model CommunicationRequestBasedOn Details", group =>
            {
                basedOn = group.Add(new VocabularyKey(nameof(basedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                communicationRequestBasedOnId = group.Add(new VocabularyKey(nameof(communicationRequestBasedOnId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey basedOn { get; private set; }
        public VocabularyKey communicationRequestBasedOnId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}