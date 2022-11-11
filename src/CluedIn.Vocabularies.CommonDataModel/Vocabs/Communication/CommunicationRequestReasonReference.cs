using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public CommunicationRequestReasonReferenceVocabulary()
        {
            VocabularyName = "CommunicationRequestReasonReference";
            KeyPrefix = "commonDataModel.communicationrequestreasonreference";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestReasonReference";

            AddGroup("CommunicationRequestReasonReference Details", group =>
            {
                communicationrequestreasnrefId = group.Add(new VocabularyKey(nameof(communicationrequestreasnrefId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                reasonReferenceType = group.Add(new VocabularyKey(nameof(reasonReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey communicationrequestreasnrefId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey reasonReferenceType { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}