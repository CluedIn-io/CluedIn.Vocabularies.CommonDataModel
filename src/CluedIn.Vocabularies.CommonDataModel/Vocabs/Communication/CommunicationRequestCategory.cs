using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestCategoryVocabulary : SimpleVocabulary
    {
        public CommunicationRequestCategoryVocabulary()
        {
            VocabularyName = "Communication Request Category";
            KeyPrefix = "commonDataModel.communicationrequestcategory";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestCategory";

            AddGroup("CommunicationRequestCategory Details", group =>
            {
                CommunicationRequestCategoryId = group.Add(new VocabularyKey(nameof(CommunicationRequestCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommunicationRequestCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}