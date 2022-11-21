using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommunicationRequestBasedOnVocabulary : SimpleVocabulary
    {
        public CommunicationRequestBasedOnVocabulary()
        {
            VocabularyName = "Communication Request Based On";
            KeyPrefix = "commonDataModel.communicationrequestbasedon";
            KeySeparator = ".";
            Grouping = "/CommunicationRequestBasedOn";

            AddGroup("CommunicationRequestBasedOn Details", group =>
            {
                BasedOn = group.Add(new VocabularyKey(nameof(BasedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommunicationRequestBasedOnId = group.Add(new VocabularyKey(nameof(CommunicationRequestBasedOnId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BasedOn { get; private set; }
        public VocabularyKey CommunicationRequestBasedOnId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}