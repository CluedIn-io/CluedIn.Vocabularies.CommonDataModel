using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventCustomRegistrationFieldVocabulary : SimpleVocabulary
    {
        public EventCustomRegistrationFieldVocabulary()
        {
            VocabularyName = "Event Custom Registration Field";
            KeyPrefix = "commonDataModel.eventcustomregistrationfield";
            KeySeparator = ".";
            Grouping = "/EventCustomRegistrationField";

            AddGroup("EventCustomRegistrationField Details", group =>
            {
                EventCustomRegistrationFieldId = group.Add(new VocabularyKey(nameof(EventCustomRegistrationFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Order = group.Add(new VocabularyKey(nameof(Order), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EventCustomRegistrationFieldId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Order { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}