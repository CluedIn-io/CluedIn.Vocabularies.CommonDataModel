using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestCategoryVocabulary : SimpleVocabulary
    {
        public CommunicationRequestCategoryVocabulary()
        {
            VocabularyName = "CommunicationRequestCategory";
            KeyPrefix = "commonDataModel.communicationrequestcategory";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestCategory";

            AddGroup("CommunicationRequestCategory Details", group =>
            {
                communicationRequestCategoryId = group.Add(new VocabularyKey(nameof(communicationRequestCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey communicationRequestCategoryId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}